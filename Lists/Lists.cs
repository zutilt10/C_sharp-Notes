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
        }
    }
}