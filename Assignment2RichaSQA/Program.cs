using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2RichaSQA
{
    class Program
    {
        static void Main(string[] args)
        {
            Program f = new Program();
            f.MainClassOfTriangle();
            Console.ReadKey();
        }
        public void MainClassOfTriangle()
        {
            String side1 = "";
            int side1ForTriangle;

            String side2 = "";
            int side2ForTriangle;

            String side3 = "";
            int side3ForTriangle;

            Console.WriteLine("Length must be greater than 0.");

            while (true)
            {
                Console.WriteLine("\n1. Enter triangle dimension.");
                Console.WriteLine("\n2. Exit");

                string Choice = Console.ReadLine();
                int ch = int.Parse(Choice);

                if (ch == 2)
                {
                    Console.WriteLine("thank you");
                    break;
                }
                else if (ch == 1)
                {
                   

                    }
                else { continue; }

            }
        }
    }
}

