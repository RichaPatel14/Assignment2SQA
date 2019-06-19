using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2RichaSQA
{
    public static class TriangleSolver
    {
        private static int side1 = 1;
        private static int side2 = 1;
        private static int side3 = 1;        

        public static void Analyze(int side1ForTriangle, int side2ForTriangle, int side3ForTriangle)
        {
            if ((side1ForTriangle == side2ForTriangle) && (side2ForTriangle == side3ForTriangle))
            {
                //break;
            }

            else if (side1ForTriangle == side2ForTriangle || side2ForTriangle == side3ForTriangle || side1ForTriangle == side3ForTriangle)
            {
               // break;
            }

            else
            {
             //   break;
            }

        }



    }

}
