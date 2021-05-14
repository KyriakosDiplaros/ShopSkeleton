using System;
using System.Collections.Generic;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstStaffDataCollection
    {
        [TestMethod]
        public void InstanceOK()
        {

        
            clsStaffDataCollection AllStaffs = new clsStaffDataCollection();
        Assert.IsNotNull(AllStaffs);
        
        }
    }
}


[TestMethod]
public void StaffListOK()
{
    clsStaffDataCollection AllStaffs = new clsStaffDataCollection();
    List<clsStaffData> TestList = new List<clsStaffData>();
    clsStaffData TestItem = new clsStaffData();
    TestItem.StaffID = 10;
    TestItem.FirstName = "Kyriakos";
    TestItem.LastName = "Diplaros";
    TestItem.Department = "Owner";
    TestItem.JoinDate = DateTime.Now.Date;
    TestList.Add(TestItem);
    AllStaffs.StaffList = TestList;
    Assert.AreEqual(AllStaffs.StaffList, TestList);
}

[TestMethod]
public void ListAndCountOk()
{
    clsStaffDataCollection AllStaffs = new clsStaffDataCollection();
    List<clsStaffData> TestList = new List<clsStaffData>();
    clsStaffData TestItem = new clsStaffData();
    TestItem.StaffID = 10;
    TestItem.FirstName = "Kyriakos";
    TestItem.LastName = "Diplaros";
    TestItem.Department = "Owner";
    TestItem.JoinDate = DateTime.Now.Date;
    TestList.Add(TestItem);
    AllStaffs.StaffList = TestList;
    Assert.AreEqual(AllStaffData.Count, TestList.Count);
}

[TestMethod]
public void CountPropertyOK()
{
    clsStaffDataCollection AllStaffs = new clsStaffDataCollection();
    Int32 SomeCount = 10;
    AllStaffs.Count = SomeCount;
    Assert.AreEqual(AllStaffs.Count, SomeCount);
}

[TestMethod]
public void TwoRecordsPresent()
{
    clsStaffDataCollection AllStaffs = new clsStaffDataCollection();
    Assert.AreEqual(AllAddresses.Count, 2);
}