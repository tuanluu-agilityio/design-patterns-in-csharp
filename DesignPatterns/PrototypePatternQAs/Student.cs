using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePatternQAs
{
    public class Student
    {
        int rollNo;
        string name;

        // Instance constructor
        public Student(int rollNo, string name)
        {
            this.rollNo = rollNo;
            this.name = name;
        }

        // copy constructor
        public Student(Student student)
        {
            this.rollNo = student.rollNo;
            this.name = student.name;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student name: {0}, Roll no: {1}", name, rollNo);
        }
    }
}
