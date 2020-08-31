using System;
using System.Collections.Generic;
using System.Text;

namespace _03.Validation_Of_Data
{
    class CommonValidator
    {
        public static void ValidateNull(object value, string typeName, string propertyName)
        {
            if (value == null)
            {
                throw new NullReferenceException($"{typeName}.{propertyName} cannot be null");
            }
        }

        public static void ValidateMinimum(int value, int minimum, string typeName, string propertyName)
        {
            if (value < minimum)
            {
                throw new ArgumentOutOfRangeException($"{typeName}.{propertyName} cannot be less than minimum");
            }
        }
        public static void ValidateMinimum<T>(T value, T minimum, string typeName, string propertyName)
            where T : IComparable<T>
        {
            if (value.CompareTo(minimum) < 0)
            {
                throw new ArgumentOutOfRangeException($"{typeName}.{propertyName} cannot be less than minimum");
            }
        }
    }
}
