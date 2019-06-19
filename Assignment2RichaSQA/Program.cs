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
                    do
                    {
                        Console.WriteLine("Please Enter length of side1.");
                        side1 = Console.ReadLine();
                        side1ForTriangle = int.Parse(side1);
                    } while (!int.TryParse(side1, out side1ForTriangle) || (side1ForTriangle < 1));
                    do
                    {
                        Console.WriteLine("Please Enter length of side2.");
                        side2 = Console.ReadLine();
                        side2ForTriangle = int.Parse(side2);
                    } while (!int.TryParse(side2, out side2ForTriangle) || (side2ForTriangle < 1));
                    do
                    {
                        Console.WriteLine("Please Enter length of side3.");
                        side3 = Console.ReadLine();
                        side3ForTriangle = int.Parse(side3);
                    } while (!int.TryParse(side3, out side3ForTriangle) || (side3ForTriangle < 1));
                    string formType = "";

                    do
                    {
                        Console.WriteLine("Triangle if form of triangle.(y/n)");
                        formType = Console.ReadLine();

                        if (formType.Equals("y") || formType.Equals("Y"))
                        {
                            TriangleSolver.Analyze(side1ForTriangle,side2ForTriangle,side3ForTriangle);
                        }
                        else if (formType.Equals("n") || formType.Equals("N")) { Console.WriteLine("These are not sides of triangle"); break; }
                    } while (!formType.Equals("y") && !formType.Equals("n") && !formType.Equals("Y") && !formType.Equals("N"));
                }
                else { continue; }

            }
        }
    }
}

