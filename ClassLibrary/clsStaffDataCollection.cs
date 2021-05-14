using System;
using ClassLibrary;
using System.Collections.Generic;



namespace ClassLibrary
{

    public class clsStaffDataCollection()
    {
        List<clsStaffData> mStaffList = new List<clsStaffData>();
    clsStaffData mThisStaffData = new clsStaffData();



}

    public clsStaffDataCollection()
    {
        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblStaffData_SelectAll");
        RecordCount = DB.Count;
        while (Index < RecordCount )
        {
            AStaff.Status = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
            AStaff.FirstName = Convert.ToString(DB.DataTable.Rows[Index]["FirstName"]);
            AStaff.LastName = Convert.ToString(DB.DataTable.Rows[Index]["LastName"]);
            AStaff.Department = Convert.ToString(DB.DataTable.Rows[Index]["Department"]);
            AStaff.StaffID = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffID"]);
            AStaff.JoinDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["JoinDate"]);
        }
    }

    public class clsStaffDataCollection
    {
        List<clsStaffData> mStaffData = new List<clsStaffData>();   
        {
public List<clsStaffData> StaffList { get; set; }
    }
    }
public List<clsStaffData> StaffList
{
    get
    {
        return mStaffData;
    }
    set
    {
        mStaffData = value;
    }

public int Count
{
    get
    {
        return mStaffData.Count;
    }
    set
    {

    }
}

public clsStaffData ThisStaffData
{
    get
    {
        return mThisStaffData;
    }
    set
    {
        mThisAddress = value;
    }
}


public int Add()
    {
    clsDataConnection DB = new clsDataConnection
    DB.AddParameter("@StaffID", mThisStaffData.StaffID);
    DB.AddParameter("@FirstName", mThisStaffData.FirstName);
    DB.AddParameter("@LastName", mThisStaffData, LastName);
    DB.AddParameter("@Department", mThisStaffData, Department);
    DB.AddParameter("@JoinDate", mThisStaffData, JoinDate);
    DB.AddParameter("@Active", mThisStaffData, Active);
    return DB.Execute("sproc_tblStaffData_Insert");
