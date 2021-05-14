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
            //create an instance of the class we want to create
            clsStaffData anStaffID = new clsStaffData();
            //test to see that it exists
            Assert.IsNotNull(anStaffID);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffData AnFirstName = new clsStaffData();
            //create some test data to assign to the property
            String TestData = "Kyriakos";
            //assign the data to the property
            AnFirstName.FirstName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFirstName.FirstName, TestData);

        }

        [TestMethod]
        public void SecondNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffData AStaff = new clsStaffData();
            //create some test data to assign to the property
            string TestData = "Diplaros";
            //assign the data to the property
            AStaff.LastName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //creaet an instance of the class we want to create
            clsStaffData ADepartment = new clsStaffData();
            //create some test data to assign to the property
            string TestData = "Owner";
            //assign the data to the property
            ADepartment.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADepartment.Department, TestData);

        }
        

        [TestMethod]
        public void JoinDatePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffData AJoinDate = new clsStaffData();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AJoinDate.JoinDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AJoinDate.JoinDate, TestData);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsStaffData AStaff = new clsStaffData();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStaff.Active, TestData);
        }



        [TestMethod]
        public void StaffIDOK()
        {
            clsStaffData AStaff = new clsStaffData();
            Int32 TestData = 1;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);

        }
        public void StaffStatusTrue()
        { 
        //create an instance of the class we want to create
        clsStaffData AnStaffData = new clsStaffData();
            //create some test data
            Boolean TestData = true;
            //assign data to the property
            AnStaffData.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaffData.Active, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStaffData AStaff = new clsStaffData();
            //boolean variable to store the results of the validation
            Boolean found = false;
            Int32 StaffID = 1;
            //invoke the method
            found = AStaff.Find(StaffID);
            //test to see if the result is true
            Assert.IsTrue(found);
        }
    }

   

}
