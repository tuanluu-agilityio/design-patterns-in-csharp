using System;

namespace PrototypePatternQAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** A simple copy constructor demo***\n");
            
            Student student1 = new Student(1, "John");
            Console.WriteLine("The details of student1 is as follow:");
            student1.DisplayDetails();

            Console.WriteLine("\n Copying student1 to student2 now");
            Student student2 = new Student(student1);
            Console.WriteLine("The details of student2 is as follow:");
            student2.DisplayDetails();

            Console.ReadKey();
        }
    }
}
