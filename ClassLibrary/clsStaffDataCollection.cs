using System;
using ClassLibrary;
using System.Collections.Generic;



namespace ClassLibrary
{

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
