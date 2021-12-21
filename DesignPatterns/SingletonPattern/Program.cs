using System;

namespace SingletonPattern
{
    // sealed: prevents the further derivation of the class
    public sealed class Singleton
    {
        // can be assigned at runtime or assigned at compile time and changed at runtime
        // this variable's value can only be changed in the static constructor
        // and can't be changed further.
        // It can change only once at runtime.
        private static readonly Singleton instance = new Singleton();
        private int numberOfInstances = 0;

        // Private constructor is used to prevent
        // creation of instances with 'new' keyword outside this class
        // This will help you refer to the one instance that can exist in the system.
        private Singleton()
        {
            Console.WriteLine("Instantiating inside the private constructor.");
            numberOfInstances++;
            Console.WriteLine("Number of instances = {0}", numberOfInstances);
        }

        // A global point of access.
        public static Singleton Instance
        { 
            get
            {
                Console.WriteLine("We already have an instance now. Use it.");
                return instance;
            }
        }
        public static int MyInt = 25;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Singleton Pattern Demo ***\n");

            //Example 1
            // Private constructor, so we can't use `new` keyword.
            Console.WriteLine("Trying to create instance s1.");
            Singleton s1 = Singleton.Instance;
            Console.WriteLine("Trying to create instance s2.");
            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                Console.WriteLine("Only one instance exists.");
            }
            else
            {
                Console.WriteLine("Different instances exist.");
            }

            // Example 2
            // still created an instance of the Singleton class
            Console.WriteLine(Singleton.MyInt);

            Console.Read();
        }
    }
}   
