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
            //DECLARE VARIABLES THAT USED BY STORING LENGTH OF SIDES
            String side1 = "";
            double side1ForTriangle;

            String side2 = "";
            double side2ForTriangle;

            String side3 = "";
            double side3ForTriangle;

            Console.WriteLine("Length must be greater than 0.");

            //LOOP EXCUTES WHEN CONDITION WILL TRUE
            while (true)
            {
                Console.WriteLine("\n1. Enter triangle dimension.");
                Console.WriteLine("\n2. Exit");

                string Choice = Console.ReadLine();
                int ch = int.Parse(Choice);

                //CHECKS CHOICE ENTER BY USER WHETHER IT  IS EXIST OR NOT
                //LOOP BREAKS WHEN USER ENTER 2
                if (ch == 2)
                {
                    Console.WriteLine("Thank you");
                    break;
                }

                //CHECKS CHOICE ENTER BY USER
                //LOOP EXECUTE WHEN USER ENTER 1
                else if (ch == 1)
                {
                    //LOOP EXECUTE UNTIL USER ENTER VALID DATA
                    do
                    {
                        Console.WriteLine("Please Enter length of side1.");
                        side1 = Console.ReadLine();
                        side1ForTriangle = double.Parse(side1);
                    } while (!double.TryParse(side1, out side1ForTriangle) || (side1ForTriangle < 1));
                    //LOOP EXECUTE UNTIL USER ENTER VALID DATA
                    do
                    {
                        Console.WriteLine("Please Enter length of side2.");
                        side2 = Console.ReadLine();
                        side2ForTriangle = double.Parse(side2);
                    } while (!double.TryParse(side2, out side2ForTriangle) || (side2ForTriangle < 1));
                    //LOOP EXECUTE UNTIL USER ENTER VALID DATA
                    do
                    {
                        Console.WriteLine("Please Enter length of side3.");
                        side3 = Console.ReadLine();
                        side3ForTriangle = double.Parse(side3);
                    } while (!double.TryParse(side3, out side3ForTriangle) || (side3ForTriangle < 1));
                    //CHECKS TRIANGLE HAS VALID FORM OR NOT
                    if (side1ForTriangle+side2ForTriangle>side3ForTriangle || side1ForTriangle+side3ForTriangle>side2ForTriangle || side2ForTriangle+side3ForTriangle>side1ForTriangle )
                        {
                            //SET DATA IN TRIANGLE CLASS
                            TriangleSolver.Side1ForTriangle = side1ForTriangle;
                            TriangleSolver.Side2ForTriangle = side2ForTriangle;
                            TriangleSolver.Side3ForTriangle = side3ForTriangle;
                        //SET DATA INTO ANALYZE METHOD IN TRIANGLE DATA
                            Console.WriteLine(TriangleSolver.Analyze(side1ForTriangle, side2ForTriangle, side3ForTriangle));
                        }
                    //IF TRIANGLE HAS NOT VALID FORM LOOP BREAK
                        else { Console.WriteLine("These are not sides of triangle"); break; }
                    }
                //IF USER DOES NOT ENTER VALID DATA OF EITHER 0 OR 1 LOOP START AGAIN
                else { continue; }
            }
        }
    }
}

