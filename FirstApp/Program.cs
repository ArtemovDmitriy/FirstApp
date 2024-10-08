using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Dmitriy";
            byte MyAge = 33;
            bool HaveIApet = false;
            int MyShoeSize = 41;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);

            Console.ReadKey();

        }
    }
}
