using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Indexers
{
    public class HttpCookie
    {
        // There is a special kind of property called indexers 
        // Indexers allow us to store different types of values by assigning it an index like in a list or array
        // To begin setting up an indexer, we need initialise a Dictionary class instance
        // This will be where the values are stored 
        // The types of values and indexes of the dictionary are entered in the <> brackets below
        private readonly Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        // Much like a property, an indexer requires a getter and a setter and is created similar to one
        // One difference is that instead of a name we have a this keyword along with the type of the index and index name
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
    class Indexers
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            // With the line below, the value("John") is being set to the index("name") in the dictionary instance named "cookie"
            cookie["name"] = "John";
            Console.WriteLine(cookie["name"]);
        }
    }
}
