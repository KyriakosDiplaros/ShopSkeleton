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

            clsStaffData AStaffID = new clsStaffData();

            Assert.IsNotNull(AStaffID);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {

            clsStaffData AnFirstName = new clsStaffData();

            String TestData = "Kyriakos";

            AnFirstName.FirstName = TestData;

            Assert.AreEqual(AnFirstName.FirstName, TestData);

        }

        [TestMethod]
        public void SecondNamePropertyOK()
        {

            clsStaffData AStaff = new clsStaffData();

            string TestData = "Diplaros";

            AStaff.LastName = TestData;

            Assert.AreEqual(AStaff.LastName, TestData);
        }

        [TestMethod]
        public void DepartmentPropertyOK()
        {

            clsStaffData ADepartment = new clsStaffData();

            string TestData = "Owner";

            ADepartment.Department = TestData;

            Assert.AreEqual(ADepartment.Department, TestData);

        }


        [TestMethod]
        public void JoinDatePropertyOK()
        {

            clsStaffData AJoinDate = new clsStaffData();

            DateTime TestData = DateTime.Now.Date;

            AJoinDate.JoinDate = TestData;

            Assert.AreEqual(AJoinDate.JoinDate, TestData);
        }


        [TestMethod]
        public void ActivePropertyOK()
        {

            clsStaffData AStaff = new clsStaffData();

            Boolean TestData = true;

            AStaff.Active = TestData;

            Assert.AreEqual(AStaff.Active, TestData);
        }



        [TestMethod]
        public void StaffIDOK()
        {
            clsStaffData AStaff = new clsStaffData();
            Int32 TestData = 10;
            AStaff.StaffID = TestData;
            Assert.AreEqual(AStaff.StaffID, TestData);

        }
        public void StaffStatusTrue()
        {

            clsStaffData AnStaffData = new clsStaffData();

            Boolean TestData = true;

            AnStaffData.Active = TestData;

            Assert.AreEqual(AnStaffData.Active, TestData);
        }

        [TestMethod]

        public void FindMethodOK()
        {

            clsStaffData AStaff = new clsStaffData();

            Boolean found = false;
            Int32 StaffID = 10;
            
            found = AStaff.Find(StaffID);

            Assert.IsTrue(found);
        }
    }
    [TestMethod]
    public void TestStaffIDFound()
    {
        
        clsStaffData AStaff = new clsStaffData();
        
        Boolean Found = false;
      
        Boolean OK = true;
        
        Int32 StaffID = 10;
        
        Found = AStaff.Find(StaffID);
        
        if (AStaff.StaffID != 10)
        {
            OK = false;
        }
        //test to see if result is true
        Assert.IsTrue(OK);
    }
}

[TestMethod]
public void FirstNamePropertyOK()
{
    clsStaffData AStaff = new clsStaffData();
    string TestData = "Kyriakos";
    AStaff.FirstName = TestData;
    Assert.AreEqual(AStaff.FirstName, TestData);
}

[TestMethod]
public void LastNamePropertyOK()
{
    clsStaffData AStaff = new clsStaffData();
    string TestData = "Diplaros";
    AStaff.LastName = TestData;
    Assert.AreEqual(AStaff.LastName, TestData);
}

[TestMethod]
public void DepartmentPropertyOK()
{
    clsStaffData AStaff = enw clsStaffData
        string TestData = "Owner";
    AStaff.Department = TestData;
    Assert.AreEqual(AStaff.Department, TestData);
}

[TestMethod]
public void TestJoinDateFound()
{
    clsStaffData AStaff = new clsStaffData();
    Boolean Found = false;
    Boolean OK = true;
    Int32 StaffID = 10;
    Found = AStaff.Find(StaffID);
    if (AStaff.JoinDate != Convert.ToDateTime("03/05/2019"))
    {
        OK = false;
    }
    Assert.IsTrue(OK);
}

