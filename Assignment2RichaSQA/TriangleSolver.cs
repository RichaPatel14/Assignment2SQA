using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2RichaSQA
{
    enum TringleType
    {
        Equilateral,
        Isosceles,
        Scalene,
        Error
    }
    public static class TriangleSolver
    {
        private static int side1ForTriangle = 1;
        private static int side2ForTriangle = 1;
        private static int side3ForTriangle = 1;

        public static int Side1ForTriangle { get => side1ForTriangle; set => side1ForTriangle = value; }
        public static int Side2ForTriangle { get => side2ForTriangle; set => side2ForTriangle = value; }
        public static int Side3ForTriangle { get => side3ForTriangle; set => side3ForTriangle = value; }

        //int[] values = new int[3] { side1ForTriangle, side2ForTriangle, side3ForTriangle };
        //public static TringleType GetAnalyze(int side1ForTriangle, int side2ForTriangle, int side3ForTriangle) { 
        //    if(side1ForTriangle<=0 || side2ForTriangle<=0 || side3ForTriangle <= 0)
        //        {
        //            return TringleType.Error;
        //        }
        //}
        public static string Analyze(int side1ForTriangle, int side2ForTriangle, int side3ForTriangle)
        {
             String hello = "your";
            do
            { 
               
                    if ((side1ForTriangle == side2ForTriangle) && (side2ForTriangle == side3ForTriangle))
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello= hello +"Triangle is equilateral.";
                      //  Console.WriteLine("Triangle is equilateral.");
                    }

                    else if (side1ForTriangle == side2ForTriangle || side2ForTriangle == side3ForTriangle || side1ForTriangle == side3ForTriangle)
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello= hello + "Triangle is isosceles.";
                   // Console.WriteLine("Triangle is isosceles.");
                    }

                    else
                    {
                        Console.WriteLine("Triangle sides: {0} x {1} x {2}", Side1ForTriangle, Side2ForTriangle, Side3ForTriangle);
                        hello= hello + "Triangle is scalene.";
                    //Console.WriteLine("Triangle is scalene.");
                    }
                
            } while (!(side1ForTriangle + side2ForTriangle > side3ForTriangle || side1ForTriangle + side3ForTriangle > side2ForTriangle || side2ForTriangle + side3ForTriangle > side1ForTriangle));
            return hello;
        }
    }
}
