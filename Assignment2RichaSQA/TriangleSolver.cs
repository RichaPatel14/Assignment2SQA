using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2RichaSQA
{
    public static class TriangleSolver
    {
        // SET ATTRIBUTE BY DEFAULT
        private static double side1ForTriangle = 1;
        private static double side2ForTriangle = 1;
        private static double side3ForTriangle = 1;

        //ENCAPSULATE PROPERTIES GET AND ASSIGN VALUE 
        public static double Side1ForTriangle { get => side1ForTriangle; set => side1ForTriangle = value; }
        public static double Side2ForTriangle { get => side2ForTriangle; set => side2ForTriangle = value; }
        public static double Side3ForTriangle { get => side3ForTriangle; set => side3ForTriangle = value; }


        //CREATE METHOD THAT FETCH VALUES OF SIDES FROM PROGRAM CLASS
        public static string Analyze(double side1ForTriangle, double side2ForTriangle, double side3ForTriangle)
        {

            String hello = "Your ";

            //CHECKS LENGTH OF SIDES ARE LESS THAN ZERO OR NOT

            if (side1ForTriangle < 0 || side2ForTriangle < 0 || side3ForTriangle < 0)
            {
                hello = hello + "input is invalid";
            }

            if (side1ForTriangle > 0 && side2ForTriangle > 0 && side3ForTriangle > 0)
            {
                //CHECKS SUM OF TWO SIDS ARE GREATER THAN THIRD SIDE
                //VALID FORM OF TRIANGLE
                if (side1ForTriangle + side2ForTriangle > side3ForTriangle && side1ForTriangle + side3ForTriangle > side2ForTriangle && side2ForTriangle + side3ForTriangle > side1ForTriangle)
                {
                    // CHECKS ALL SIDES ARE SAME
                    //TRIANGLE IS FORM OF EQUILATERAL
                    if ((side1ForTriangle == side2ForTriangle) && (side2ForTriangle == side3ForTriangle))
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello = hello + "Triangle is equilateral.";
                    }

                    // CHECKS ANY TWO SIDES ARE SAME
                    //TRIANGLE IS FORM OF ISOSCELES
                    else if (side1ForTriangle == side2ForTriangle || side2ForTriangle == side3ForTriangle || side1ForTriangle == side3ForTriangle)
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello = hello + "Triangle is isosceles.";
                    }

                    //CHECK ALL SIDES ARE NOT SAME
                    //TRIANGLE IS FORM OF SCALENE
                    else
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello = hello + "Triangle is scalene.";
                    }
                }
                // CHECK SUM OF ANY TWO SIDE IS NOT GREATER THAN THIRD SIDE
                //INVALID FORM OF TRIANGLE
                else { hello = hello + "Triangle is in incorrect form"; }
               
            }
            return hello;
        }
    }
}
