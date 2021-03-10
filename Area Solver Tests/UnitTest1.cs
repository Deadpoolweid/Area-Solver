using System;
using Area_Solver_Library;
using NUnit.Framework;

namespace Area_Solver_Tests
{
    public class Tests
    {
        public AreaSolver areaSolver;

        [SetUp]
        public void Setup()
        {
            areaSolver = new AreaSolver();
        }

        [Test]
        public void GetCircleAreaTest()
        {
            Assert.AreEqual(78.53981633974483,areaSolver.GetCircleArea(5),double.Epsilon);
        }

        [Test]
        public void GetTriangleAreaTest()
        {
            Assert.AreEqual(6,areaSolver.GetTriangleArea(3,4,5));
        }

        [Test]
        public void GetAreaTest()
        {
            Assert.AreEqual(50.26548245743669, areaSolver.GetArea(4), double.Epsilon);
            Assert.AreEqual(34.977671449083054, areaSolver.GetArea(7,12,10), double.Epsilon);
            Assert.Throws<Exception>(() => areaSolver.GetArea(1, 2));
        }

        [Test]
        public void IsTriangleRightTest()
        {
            Assert.True(areaSolver.IsTriangleRight(3,4,5));
        }


        }
}