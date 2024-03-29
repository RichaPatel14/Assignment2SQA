﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2RichaSQA;
using NUnit.Framework;

namespace TestCaseTriangle
{
    [TestFixture]
    public class Class1
    {
        // TEST CASE FOR POSITIVE VALUE OF SIDES FOR SCALENE
        [Test]       
        public void TestCase_Scalene()
        {
            double side1 = 3, side2 = 5, side3 = 7;
            String name = "scalene";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name,side);
        }
        // TEST CASE FOR POSITIVE VALUE OF SIDES FOR EQUILATERAL
        [Test]
        public void TestCase_Equilateral()
        {
            double side1 = 3, side2 = 3, side3 = 3;
            String name = "equilateral";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        //// TEST CASE FOR POSITIVE VALUE OF SIDES FOR ISOSCELES
        [Test]
        public void TestCase_Isosceles()
        {
            double side1 = 3, side2 = 5, side3 = 3;
            String name = "isosceles";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        //// TEST CASE FOR NEGATIVE VALUE OF SIDES FOR EQUILATERAL
        [Test]
        public void TestCase_EquilateralNagative()
        {
            double side1 = 3, side2 = -3, side3 = 3;
            String name = "invalid";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        //TEST CASE FOR NEGATIVE VALUE OF SIDES FOR SCALENE
        [Test]
        public void TestCase_ScaleneNagative()
        {
            double side1 = 3, side2 = -2, side3 = 7;
            String name = "invalid";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        // TEST CASE FOR NEGATIVE VALUE OF SIDES FOR ISOSCELES
        [Test]
        public void TestCase_IsoscelesNagative()
        {
            double side1 = 3, side2 = -5, side3 = -7;
            String name = "invalid";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        // TEST CASE FOR NEGATIVE VALUE OF SIDES
        [Test]
        public void TestCase_Error()
        {
            double side1 = -3, side2 = 3, side3 = 5;
            String name = "invalid";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
        // TEST CASE FOR SUM OF TWO SIDE IS GREATER THAN THIRD SIDE
        // TEST CASE FOR CHECK FORM OF TRIANGLE
        [Test]
        public void TestCase_Side()
        {
            double side1 = 1, side2 =3 , side3 = 25;
            String name = "incorrect";
            String side = TriangleSolver.Analyze(side1, side2, side3);
            StringAssert.Contains(name, side);
        }
    }
}
