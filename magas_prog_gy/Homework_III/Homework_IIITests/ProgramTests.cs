using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_III;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Homework_III;

namespace Homework_III.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        static List<string> cityNames = new List<string>() { "HongKong", "London", "Sajópetri" };
        static List<int> cityPopulations = new List<int>() { 7000000, 9000000, 1419 };

        [TestMethod()]
        public void GetMoreLargestCitiesTest1()
        {
            List<string> result = Homework_III.Program.GetMoreLargestCities(cityNames, cityPopulations);
            Assert.AreEqual("HongKong", result[0]);
        }

        [TestMethod()]
        public void GetMoreLargestCitiesTest2()
        {
            List<string> result = Homework_III.Program.GetMoreLargestCities(cityNames, cityPopulations);
            Assert.AreEqual("London", result[1]);
        }

        [TestMethod()]
        public void GetMoreLargestCitiesTest3()
        {
            List<string> result = Homework_III.Program.GetMoreLargestCities(cityNames, cityPopulations);
            Assert.AreEqual(2, result.Count);
        }
    }
}