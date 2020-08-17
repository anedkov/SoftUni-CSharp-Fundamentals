using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Pokemon_Dont_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listPokemons = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToList();

            int sumRemoved = 0;

            string newLine = Console.ReadLine();
            while (newLine != null)
            {
                int index = int.Parse(newLine);

                int removedPokemon;

                if (index < 0)
                {
                    removedPokemon = listPokemons[0];
                    listPokemons.RemoveAt(0);

                    if (listPokemons.Count > 0)
                    {
                        listPokemons.Insert(0, listPokemons[listPokemons.Count - 1]);
                    }
                }
                else if (index >= listPokemons.Count)
                {
                    removedPokemon = listPokemons[listPokemons.Count - 1];
                    listPokemons.RemoveAt(listPokemons.Count - 1);

                    if (listPokemons.Count > 0)
                    {
                        listPokemons.Add(listPokemons[0]);
                    }
                }
                else
                {
                    removedPokemon = listPokemons[index];
                    listPokemons.RemoveAt(index);
                }

                sumRemoved += removedPokemon;

                if (listPokemons.Count == 0)
                {
                    Console.WriteLine(sumRemoved);

                    return;
                }

                RecalculatePokemons(listPokemons, removedPokemon);

                newLine = Console.ReadLine();
            }
        }

        static private void RecalculatePokemons(List<int> listPokemons, int removedPokemon)
        {
            for (int i = 0; i < listPokemons.Count; i++)
            {
                if (listPokemons[i] <= removedPokemon)
                {
                    listPokemons[i] += removedPokemon;
                }
                else
                {
                    listPokemons[i] -= removedPokemon;
                }
            }
        }
    }
}
