using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;

namespace MiniORM
{
	public abstract  class DbContext
    {
        private readonly DatabaseConnection connection;
        private readonly Dictionary<Type, PropertyInfo> dbSetProperties;

        internal static readonly Type[] AllowedSqlTypes =
        {
            typeof(string),
            typeof(int),
            typeof(uint),
            typeof(long),
            typeof(ulong),
            typeof(decimal),
            typeof(bool),
            typeof(DateTime),
        };

        protected DbContext (string connectionString)
        {
            this.connection = new DatabaseConnection(connectionString);
            this.dbSetProperties = this.DiscoverDbSets();
            using(new ConnectionManager(connection))
            {
                this.IntializeDbSet();
            }
            //Navigatinal Properties
            this.MapAllRelations();
        }
        public void SaveChanges()
        {
            object[] dbSets = this.dbSetProperties
                .Select(kvp => kvp.Value.GetValue(this))
                .ToArray();

            foreach (IEnumerable<object> dbSet in dbSets)
            {
                object[] invalidEntities = dbSet
                    .Where(entity => IsObjectValid(entity))
                    .ToArray();


                if (invalidEntities.Any())
                {
                    throw new InvalidOperationException($"{invalidEntities.Length} Invalid Entities found in " +
                        $"{dbSet.GetType().Name}!");
                }
            }
            using (new ConnectionManager(this.connection))
            {
                using (SqlTransaction transaction = this.connection.StartTransaction())
                {
                    foreach (IEnumerable dbSet in dbSets)
                    {
                        Type dbSetType = dbSet.GetType()
                            .GetGenericArguments()
                            .First();
                        MethodInfo persistMethod = typeof(DbContext)
                            .GetMethod("Persist", BindingFlags.Instance | 
                            BindingFlags.NonPublic)
                            .MakeGenericMethod(dbSetType);

                        try
                        {
                            persistMethod.Invoke(this, new object[] { dbSet });
                        }
                        catch(TargetInvocationException tie)
                        {
                            throw tie.InnerException;
                        }
                        catch (InvalidOperationException)
                        {
                            transaction.Rollback();
                            throw;
                        }
                        catch (SqlException)
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                    transaction.Commit();
                }
            }
        }

        private bool IsObjectValid(object entity)
        {
            var validationContext = new ValidationContext(entity);
            var validationErrors = new List<ValidationResult>();

            var validationResult =
                Validator.TryValidateObject(entity, validationContext, validationErrors, validateAllProperties: true);

            return validationResult;
        }

        private IEnumerable<TEntity> LoadTableEntities<TEntity>()
            where TEntity : class
        {
            var table = typeof(TEntity);
            var columns = GetEntityColumnNames(table);
            var tableName = GetTableName(table);
            var fetchedRows = this.connection.FetchResultSet<TEntity>(tableName, columns).ToArray(0);
            return fetchedRows;
        }

        private string GetTableName(Type tableType)
        {
            var tableName = ((TableAttribute)Attribute.GetCustomAttribute(tableType, typeof(TableAttribute))).Name;

            if (tableName == null) 
            {
                tableName = this.dbSetProperties[tableType].Name;
            }
            return tableName;
        }

        private void MapNavigationProperties<TEntity>(DbSet<TEntity> dbSet)
            where TEntity : class, new()
        {
            var entityType = typeof(TEntity);
            var foreignKeys = entityType.GetProperties()
                .Where(pi => pi.HasAttribute<ForeignKeyAttribute>())
                .ToArray();

            foreach (var foreignKey in foreignKeys)
            {
                var navigationPropertyName =
                    foreignKey.GetCustomAttribute<ForeignKeyAttribute>().Name;
                var navigationProperty = entityType.GetProperty(navigationPropertyName);

                var navigationDbSet = this.dbSetProperties[navigationProperty.PropertyType]
                    .GetValue(this);

                var navigationPrimaryKey = navigationProperty.PropertyType.GetProperties()
                    .First(pi => pi.HasAttribute<KeyAttribute>());

                foreach (var entity in dbSet)
                {
                    var foreignKeyValue = foreignKey.GetValue(entity);
                    var navigationPropertyValue = ((IEnumerable<object>)navigationDbSet)
                        .First(currentNavigationProperty =>
                        navigationPrimaryKey.GetValue(currentNavigationProperty).Equals(foreignKeyValue));
                    navigationProperty.SetValue(entity, navigationPropertyValue);
                }
            }
        }
        private void MapAllRelations()
        {
            foreach (KeyValuePair<Type,PropertyInfo> dbSetProperty in this.dbSetProperties)
            {
                Type dbSetType = dbSetProperty.Key;
                MethodInfo mapRelationsGenericMethod = typeof(DbContext)
                    .GetMethod("Map Relations",
                    BindingFlags.Instance |
                    BindingFlags.NonPublic)
                    .MakeGenericMethod(dbSetType);

                object dbSet = dbSetProperty.Value.GetValue(this);
                mapRelationsGenericMethod.Invoke(this, new object[] { dbSet });
            }
        }

        private void IntializeDbSet()
        {
            foreach (KeyValuePair<Type,PropertyInfo> dbSet in this.dbSetProperties)
            {
                Type dbSetType = dbSet.Key;
                PropertyInfo dbSetProperty = dbSet.Value;

                MethodInfo populateMethod = typeof(DbContext)
                    .GetMethod("PopulateDbSet", BindingFlags.Instance |
                    BindingFlags.NonPublic)
                    .MakeGenericMethod(dbSetType);

                populateMethod.Invoke(this, new object[]
                { dbSetProperty });
            }
        }

        private void PersistDbSet<TEntity> (PropertyInfo dbSet)
            where TEntity : class, new()
        {
            IEnumerable<TEntity> entities = 
                this.LoadTableEntities<TEntity>();

            DbSet<TEntity> dbSetInstance = new DbSet<TEntity>(entities);
            ReflectionHelper.ReplaceBackingField(this, dbSet.Name, dbSetInstance);
        }

       private string [] GetEntityColumnNames (Type table)
        {
            var tableName = this.GetTableName(table);
            var dbColumns =
                this.connection.FetchColumnNames(tableName);
            var columns = table.GetProperties()
                .Where(pi => dbColumns.Contains(pi.Name) &&
                !pi.HasAttribute<NotMappedAttribute>() &&
                AllowedSqlTypes.Contains(pi.PropertyType))
                .Select(pi => pi.Name)
                .ToArray();

            return columns;
        }

        private Dictionary<Type, PropertyInfo> DiscoverDbSets()
        {
            var dbSets = this.GetType().GetProperties()
                .Where(pi => pi.PropertyType.GetGenericTypeDefinition() == typeof(DbSet<>))
                .ToDictionary(pi => pi.PropertyType.GetGenericArguments().First(), pi => pi);
            return dbSets;
        }

        private void Persist<TEntity>(DbSet<TEntity> dbSet)
            where TEntity :class, new()
        {
            string tableName = this.GetTableName(typeof(TEntity));
            string[] columns = this.connection
                .FetchColumnNames(tableName)
                .ToArray();

            if (dbSet.ChangeTracker.Added.Any())
            {
                this.connection
                    .InsertEntities(dbSet.ChangeTracker.Added, tableName, columns);
            }
            IEnumerable<TEntity> modifiedEntites = dbSet.ChangeTracker
                .GetModifiedEntities(dbSet)
                .ToArray();

            if (modifiedEntites.Any())
            {
                this.connection
                    .UpdateEntities(modifiedEntites, tableName, columns);
            }
            if (dbSet.ChangeTracker.Removed.Any())
            {
                this.connection
                    .DeleteEntities(dbSet.ChangeTracker.Removed,
                    tableName,columns)
            }
        } 
   
        private void MapRelations<TEntity>(DbSet<TEntity> dbSet)
            where TEntity:class, new()
        {
            Type entityType = typeof(TEntity);
            this.MapNavigationProperties(dbSet);
            PropertyInfo[] collections = entityType.GetProperties()
                .Where(pi =>
                pi.PropertyType.IsGenericType &&
                pi.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                .ToArray();

            foreach (PropertyInfo collection in collections)
            {
                Type collectionType = collection
                    .PropertyType
                    .GetGenericArguments()
                    .First();
                MethodInfo mapCollectionsMethod = typeof(DbContext)
                    .GetMethod("Map Collection", BindingFlags.Instance |
                    BindingFlags.NonPublic)
                    .MakeGenericMethod(entityType, collectionType);

                mapCollectionsMethod.Invoke(this, new object[] 
                { dbSet, collection });
            }
        }

        private void MapCollection<TDbSet, TCollection>(DbSet<TDbSet> dbSet, PropertyInfo collectionProperty)
            where TDbSet : class, new()
            where TCollection: class, new()
        {
            Type entityType = typeof(TDbSet);
            Type collectionType = typeof(TCollection);

            PropertyInfo[] primaryKeys = collectionType.GetProperties()
                .Where(pi => pi.HasAttribute<KeyAttribute>())
                .ToArray();

            PropertyInfo primaryKey = primaryKeys.First();
            PropertyInfo foreignKey = entityType.GetProperties()
                .First(pi => pi.HasAttribute<KeyAttribute>());

            bool isManyToMany = primaryKeys.Length >= 2;

            if (isManyToMany)
            {
                primaryKey = collectionType.GetProperties()
                    .First(pi => collectionType.GetProperty
                    (pi.GetCustomAttribute<ForeignKeyAttribute>().Name)
                    .PropertyType == entityType);
            }
            DbSet<TCollection> navigationDbSet = 
                (DbSet<TCollection>)this.dbSetProperties[collectionType]
                .GetValue(this);

            foreach (TDbSet entity in dbSet)
            {
                object primaryKeyValue = foreignKey.GetValue(entity);

                TCollection[] navigationsEntities = navigationDbSet
                    .Where(navigationEntity => primaryKey
                    .GetValue(navigationEntity)
                    .Equals(primaryKeyValue))
                    .ToArray();

                ReflectionHelper.ReplaceBackingField(entity, collectionProperty.Name, navigationsEntities);
            }
        }
    }
}