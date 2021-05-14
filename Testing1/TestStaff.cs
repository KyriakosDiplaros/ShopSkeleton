using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

string StaffID { get;  set; }
string FirstName { get;  set; }
string LastName { get;  set; }
string Deparment { get;  set; }
DateTime JoinDate { get;  set; }

namespace Testing1
{
    [TestClass]
    public class TestStaff
    {
        int StaffID = 10;
        string FirstName = "Kyriakos";
        string LastName = "Diplaros";
        string Department = "Owner";
        string JoinDate = DateTime.Now.Date.ToString();

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
    clsStaffData AStaff = new clsStaffData();
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
[TestMethod]
public void ValidMethodOK()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    Error = AStaff.Valid(FirstName, LastName, Deparment, JoinDate);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMinLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "";
    Error = AStaff.Valid( FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}
[TestMethod]
public void FirstNameMin()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "1";
    Error = AStaff.Valid( FirstName, lastName, department, joinDate);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMinPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "11";
    Error = AStaff.Valid(FirstName, lastName, department, joinDate);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMaxLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "11111";
    Error = AStaff.Valid(FirstName, lastName, department, joinDate);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMax()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "111111";
    Error = AStaff.Valid(FirstName, lastName, department, joinDate);
    Assert.AreEqual(Error, "");
}
[TestMethod]
public void FirstNameMid()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "111";
    Error = AStaff.Valid(FirstName, lastName, department, joinDate);
    Assert.AreEqual(Error, "");
}

[TestMethod]
public void FirstNameMaxPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "aaaaaaa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod] 
public void FirstNameExtremeMax()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string FirstName = "";
    FirstName = FirstName.PadRight(500, 'a')
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void JoinDateExtremeMin()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    DateTime TestDate;
    TestDate = DateTime.Now.Date;
    TestDate = TestDate.AddYears(+100);
    string JoinDate = TestDate.ToString();
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void JoinDateInvalidData()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string joinDate = "This is not a date.";
    Error = AStaff.Valid(firstName, lastName, department, joinDate);
    Assert.AreNotEqual(Error, "");
}


[TestMethod]
public void LastNameMinLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMin()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "a";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMinPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "aa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMaxLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMax()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMaxPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void LastNameMid()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string LastName = "aaaaaaaaaaaaaaaaaaaaaaaaa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMinLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMin()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "a";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}


[TestMethod]
public void DepartmentMinPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "aa";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMaxLessOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "";
    Department = Department.PadRight(49, 'a');
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMax()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "";
    Department = Department.PadRight(50, 'a');
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMaxPlusOne()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "";
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}

[TestMethod]
public void DepartmentMid()
{
    clsStaffData AStaff = new clsStaffData();
    String Error = "";
    string Department = "";
    Department = Department.PadRight(25, 'a');
    Error = AStaff.Valid(FirstName, LastName, Department, JoinDate);
    Assert.AreNotEqual(Error, "");
}