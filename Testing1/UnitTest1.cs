using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffFinder AnStaffFinder = new clsStaffFinder();
            Assert.IsNotNull(AnStaffFinder);
        }
    }
}
