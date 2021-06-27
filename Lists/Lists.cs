using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Lists
{
    class Lists
    {
        static void Main(string[] args)
        {
            // One of the disadvantages of arrays is that they have a fixed number of items
            // When we do not know beforehand how many items we want to store, we should use lists
            // We do not need to specify the number of items in the list before we create it
            // To use a list we need to inculde another namespace
            // Namespaces are like groups of functionality that we can import to do different things
            // Namespaces being used can be seen at the very top
            // Lists are inside of the System.Collections.Generic namespace
            // The syntax for lists is: List<<type of data>> <name of list> = new List<<type of data>>();
            // It is also possible to add values to the list once it's created
            // Simply add the values at the very end of the List creation in {}

            var numbers = new List<int>() { 1, 2, 3, 4};

            // The .Add method adds a value to the list as the very last value in the list with the biggest index
            numbers.Add(1);
            // The .AddRange method adds a entire list to another list
            numbers.AddRange(new int[3] { 5, 6, 7});

            // With .IndexOf and .LastIndexOf methods we can get the index of certain values
            Console.WriteLine(numbers.IndexOf(1));
            Console.WriteLine(numbers.LastIndexOf(1));

            List<string> shoppingList = new List<string>(); 

            shoppingList.Add("Eggs");
            shoppingList.Add("Chocolate");
            shoppingList.Add("Milk");

            // When we want to get the length of the list, unlike arrays, we use .Count
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Milk");
            shoppingList.RemoveAt(0);

            Console.WriteLine("------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.ReadKey();
            // Note: It is not possible to change the values of a list in a foreach loop 
        }
    }
}