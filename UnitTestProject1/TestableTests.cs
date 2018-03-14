using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class TestableTests
    {
        [TestMethod()]
        public void getMultiplyTest()
        {
            decimal a = 23.1M;
            decimal b = 23.09M;

            var obj = new Testable();
            var result = obj.getMultiply(a, b);


            Assert.IsNotNull(result, "result is null");
        }
    }
}