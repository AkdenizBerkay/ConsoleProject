using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleProject.Model.Mars mars = new ConsoleProject.Model.Mars(5,5);
            ConsoleProject.Model.Rover rover = new ConsoleProject.Model.Rover();
            rover.way = "N";
            rover.x = 1;
            rover.y = 2;
            string commands = "LMLMLMLMM";
            var result = ConsoleProject.Helper.Utilities.ApplyCommands(mars, rover,commands);
            Assert.AreEqual("1 3 N", result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            ConsoleProject.Model.Mars mars = new ConsoleProject.Model.Mars(5, 5);
            ConsoleProject.Model.Rover rover = new ConsoleProject.Model.Rover();
            rover.way = "E";
            rover.x = 3;
            rover.y = 3;
            string commands = "MMRMMRMRRM";
            var result = ConsoleProject.Helper.Utilities.ApplyCommands(mars, rover, commands);
            Assert.AreEqual("5 1 E", result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                ConsoleProject.Model.Mars mars = new ConsoleProject.Model.Mars(5, 5);
                ConsoleProject.Model.Rover rover = new ConsoleProject.Model.Rover();
                rover.way = "S";
                rover.x = 2;
                rover.y = 2;
                string commands = "LLMMRRMMLLLLMMM";
                var result = ConsoleProject.Helper.Utilities.ApplyCommands(mars, rover, commands);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Rover left orbit", ex.Message);
            }
        }

    }
}
