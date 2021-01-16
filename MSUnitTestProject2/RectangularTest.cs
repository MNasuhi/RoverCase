using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1;
using ConsoleApp1.Business.Concrete;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSUnitTestProject2
{
    [TestClass]
   public class RectangularTest
    {
        [TestMethod]
        public void Rectangular_WhenValuesUnderZero_Error()
        {
            var rc = new RectangularManager();
            rc.Rectangular("-1 -1");
            rc.Rectangular("-3 3");
            rc.Rectangular("8 -8");
        }

        [TestMethod]
        public void Rectangular_WhenLengthDifferent2_Error()
        {
            var rc = new RectangularManager();
            rc.Rectangular("3");
            rc.Rectangular("f");
            rc.Rectangular("5 5 5");
        }

        [TestMethod]
        public void Rectangular_WhenValuesNotInt_Error()
        {
            var rc = new RectangularManager();
            string[] s1 = { "5", "m" };
            string[] s2 = { "d", "m" };
            string[] s3 = { "g", "7" };
            rc.Control(s1, null);
            rc.Control(s2, null);
            rc.Control(s3, null);
        }

        [TestMethod]
        public void Rectangular_WhenCorrectInput_Success()
        {
            var rc = new RectangularManager();
            rc.Rectangular("5 5");
            rc.Rectangular("3 3");
        }
    }
}
