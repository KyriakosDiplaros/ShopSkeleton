using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaffData
    {

        private String mStaffID;
        
        public string StaffID
        {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        

        private string mFirstName;

        public string FirstName
        {
            get
            {
                return mFirstName;
            }
            set
            {
                mFirstName = value;
            }
        }

        private string mLastName;

        public string LastName
        {
            get
            {
                return mLastName;
            }
            set
            {
                mLastName = value;
            }
        }


        private string mDepartment;

        public string Department
        {
            get
            {
                return mDepartment;
            }
            set
            {
                mDepartment = value;
            }
        }


        private DateTime mJoinDate;

        public DateTime JoinDate
        {
            get
            {
                return mJoinDate;
            }
            set
            {
                mJoinDate = value;
            }
        }

        private Boolean mActive;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }

        }



        public bool Find(int staffID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", StaffID);
            DB.Execute("sproc_tblStaffData_FilterByStaffID");
            if (DB.Count == 1)
            {


                mStaffID = Convert.ToString(DB.DataTable.Rows[0]["StaffID"]);
                mFirstName = Convert.ToString(DB.DataTable.Rows[0]["FirstName"]);
                mLastName = Convert.ToString(DB.DataTable.Rows[0]["LastName"]);
                mDepartment = Convert.ToString(DB.DataTable.Rows[0]["Department"]);
                mJoinDate = Convert.ToDateTime(DB.DataTable.Rows[0]["JoinDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
            }
            else
            {
                return false;
            }
        
            //always return true
            return true;
        }

        public string Valid(string StaffID,
                            string FirstName,
                            string LastName,
                            string Department,
                            DateTime JoinDate)
        {
            return "";
        }

        public string Valid(object staffID, object firstName, object lastName, object deparment, object joinDate)
        {
            throw new NotImplementedException();
        }

        public string Valid(string staffID, object firstName, object lastName, object department, object joinDate)
        {
            throw new NotImplementedException();
        }
    }

    public string Valid(string staffID, string firstName, string lastName, string department, string joinDate)
    {
        String Error = "";
        DateTime DateTemp;
        if (firstName.Length == 0)
        {
            Error = Error + "The First Name may not be blank: ";
        }

        if (firstName.Length > 50)
        {
            Error = Error + "The First Name must be less than 50 characters: ";
        }

        try
        {
           
        }
        DateTemp = Convert.ToDateTime(joinDate);
        if (DateTemp > DateTime.Now.Date)
        {
            Error = Error + "The date cannot be in the future: ";
        }
        catch
        {
            Error = Error + "The date was invalid: ";
        }
        if (lastName.Lenght == 0)
        {
            Error = Error + "The Last Name may not be blank: ";
        }
        if (lastName.Length > 50)
        {
            Error = Error + " The Last Name may be less than 50 characters: ";
        }

        if (department.Length == 0)
        {
            Error = Error + "The Department may not be empty: ";
        }
        if (department.Length > 50)
        {
            Error = Error + "The department may be less than 50 characters: ";
        }
        return Error;
    }




}