using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace TriangleChecker.Test
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_IsTriange_True_3_4_5()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), true);
        }

        [TestMethod]
        public void Triangle_IsTriange_True_6_6_11()
        {
            var a = 3;
            var b = 4;
            var c = 5;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), true);
        }

        [TestMethod]
        public void Triangle_IsTriange_True_1_1_1()
        {
            var a = 1;
            var b = 1;
            var c = 1;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), true);
        }

        [TestMethod]
        public void Triangle_IsTriange_True_6_7_12()
        {
            var a = 6;
            var b = 7;
            var c = 12;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), true);
        }

        [TestMethod]
        public void Triangle_IsTriange_False_1_1_3()
        {
            var a = 1;
            var b = 1;
            var c = 3;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), false);
        }

        [TestMethod]
        public void Triangle_IsTriange_False_0_0_0()
        {
            var a = 0;
            var b = 0;
            var c = 0;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), false);
        }

        [TestMethod]
        public void Triangle_IsTriange_False_13_12_27()
        {
            var a = 1;
            var b = 1;
            var c = 3;
            Assert.AreEqual(Triangle.IsTriangle(a, b, c), false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_IsTriange_Exception_Argument_a()
        {
            var a = -1;
            var b = 2;
            var c = 3;
            Triangle.IsTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_IsTriange_Exception_Argument_b()
        {
            var a = 1;
            var b = -2;
            var c = 3;
            Triangle.IsTriangle(a, b, c);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Triangle_IsTriange_Exception_Argument_c()
        {
            var a = 1;
            var b = 2;
            var c = -3;
            Triangle.IsTriangle(a, b, c);
        }
    }
}
