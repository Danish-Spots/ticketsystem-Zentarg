using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibraryUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCarPrice()
        {
            //Arrange
            Car car = new Car();

            //Act
            double price = car.Price();

            //Assert
            Assert.AreEqual(240, price);
        }

        [TestMethod]
        public void TestCarVehicleType()
        {
            //Arrange
            Car car = new Car();

            //Act
            string vehicleType = car.VehicleType();

            //Assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        public void TestMCPrice()
        {
            //Arrange
            MC mc = new MC();

            //Act
            double price = mc.Price();

            //Assert
            Assert.AreEqual(125, price);
        }

        [TestMethod]
        public void TestMCVehicle()
        {
            //Arrange
            MC mc = new MC();

            //Act
            string vehicleType = mc.Vehicle();

            //Assert
            Assert.AreEqual("M C", vehicleType);
        }
    }
}
