using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Array
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // Arrays allow us to store mutiple values in a single variable
            // The syntax is: <type of variables that we want our array to store>[] <name of variable> = {<values to be stored>};
            // Each value will have a number associated with them called an index
            // The first value will have an index of 0, the second will have 1, the third will have 2 and so on and so froth
            // To access the individual values, we use the list's name and a "[]" with the value's index inside the bracket
            // Eg. Console.Write(favorites[1]); (This will allow us to write out the first value in the list called favorites)

            string[] games = { "Dead Cells", "Genshin Impact", "Terraria", "Minecraft" };

            for (int i = 0; i < games.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + games[i]);
            }

            Console.ReadKey();

            // Sometimes we won't know what will be in the array beforehand like if we want the user's input
            // When this happens, we create an empty array and populate it one by one
            // Creating an empty array is similar to just creating an array
            // Instead of inputing some values ourselves inside of {}, we just type in: new <variable type>[<number of values we want to be inputed>]

            string[] _games = new string[4];

            Console.WriteLine("Type in four games: ");

            for (int i = 0; i < _games.Length; i++)
            {
                _games[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are in alphabetical order: ");

            //Array.Sort(_games);

            for (int i = 0; i < _games.Length; i++)
            {
                Console.WriteLine(_games[i]);
            }

            // 2D arrays are arrays that contain arrays
            // The syntax for creating a 2D array is: <type of variables that we want our array to store>[,] <name of variable> = {{arrays}}; 

            int[,] numberGrid =
            {
                {1, 2 },
                {3, 4 },
                {7, 8 }
            };

            // When accessing the values in the 2D array, similar to lists, we simply need to type out their index position
            // We type in 2 numbers in [] brackets when we want to access the items in the 2D array
            // The first number will be the index of the array itself and the second number will be the index of the item inside in array
            Console.WriteLine(numberGrid[0, 1]);

            Console.ReadKey();

        }
    }
}