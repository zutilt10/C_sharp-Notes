using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Delegates
{
    class Delegates
    {
        // 1.Creating a delegate is simple. Simply write a delegate keyword and create something akin to a method
        // 2.Add any parameters needed
        delegate void DelegateExample(int a);

        void Start()
        {
            // 5.We can make an instance of the delegate and set it to be equal with the Foo method because it is compatible
            DelegateExample myDelegate = Foo;
            // 6.We can then call the method by writing: <Delegate instance name>.Invoke(<Values for parameters>)
            myDelegate.Invoke(5);
            // 7.A shortcut can be to simply call the delegate instance as if it were the stored method
            myDelegate(6);

            myDelegate = Bar;

            // 10.Like this, we can use a method to call another one with the delegate 
            Foobar(myDelegate);
            // 11.It is not necessary to create a delegate instance in order to call the other methods
            // 12. We can simply pass the compatible methods into the method itself 
            Foobar(Bar);
        }

        // 8.Now that we can store references to methods inside of variables, we can pass methods into other methods
        // 9.For example, the method below takes a delegate as a parameter 
        void Foobar(DelegateExample myDelegate)
        {
            // 13. Whichever compatible method we choose to pass in, we can call it in this method the same way as shown before
            // 14. We simply write the delegate parameter and pass in the proper values we want
            myDelegate(50);
        }

        // 3.Then we can create another method that has parameters and a return type that match those of the delegate 
        // 4. We can say that this method Foo is compatible with the delegate 
        void Foo(int a)
        {

        }

        void Bar(int a)
        {

        }
        static void Main(string[] args)
        {

        }
    }
}