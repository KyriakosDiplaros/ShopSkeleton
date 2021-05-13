using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        [TestMethod]
        public void StaffIDOK()
        {
            clsStaffFinder AnStaffFinder = new clsStaffFinder();
            Assert.IsNotNull(AnStaffFinder);

        }
        public void StaffStatusTrue()
        { 
        //create an instance of the class we want to create
        clsStaffFinder AnStaffFinder = new clsStaffFinder();
            //create some test data
            Boolean TestData = true;
            //assign data to the property
            AnStaffFinder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaffFinder.Active, TestData);
        }
   
    }

}
