using Microsoft.VisualStudio.TestTools.UnitTesting;
using EventApp;

namespace EventAppTests
{
    [TestClass]
    public class EventTests
    {
        [TestMethod]
        //Test discount if lowercase d is passed
        public void CalculateDiscount_LowerCased()
        {
            //Arrange
            Event birthday = new Event(4, "Crete", 2000);
            //Act
            double discount = birthday.doDiscount("d");
            //Assert
            Assert.AreEqual(discount, 1800);
        }

        [TestMethod]
        //Test discount if uppercase d is passed.
        public void CalculateDiscount_UpperCaseD()
        {
            //Arrange
            Event graduation = new Event(3, "Lincoln", 2000);
            //Act
            double discount = graduation.doDiscount("D");
            //Assert
            Assert.AreEqual(discount, 1800);
        }

        [TestMethod]
        //Test late fee if lowercase l is passed.
        public void CalculateLateFee_lowercasel()
        {
            //Arrange
            Event wedding = new Event(2, "Kansas", 2000);
            //Act
            double lateFee = wedding.doDiscount("l");
            //Assert
            Assert.AreEqual(lateFee, 2200);
        }

        [TestMethod]
        //Test late fee if uppercase l is passed.
        public void CalculateLateFee_UpperCaseL()
        {
            //Arrange
            Event wedding = new Event(1, "Kansas", 2000);
            //Act
            double lateFee = wedding.doDiscount("L");
            //Assert
            Assert.AreEqual(lateFee, 2200);
        }

        [TestMethod]
        //Test late fee if nothing is passed.
        public void CalculateDiscount_NoInput()
        {
            //Arrange
            Event birthday = new Event(5, "Crete", 2000);
            //Act
            double discount = birthday.doDiscount("");
            //Assert
            Assert.AreEqual(discount, 2000);
        }
    }
}
