using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//I see no difference in Variables compared to Java.

namespace cSharpVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            int age = 35;
            char grade = 'A';
            bool isFemale = false;


            Console.WriteLine("My name is "+ name +"\nMy age is "+age);
            Console.WriteLine("My test grade is "+ grade);
            Console.WriteLine("Am I a Female? "+ isFemale);
            Console.ReadLine();
        }
    }
}
