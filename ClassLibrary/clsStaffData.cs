using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary
{
    public class clsStaffData
    {

        private Int32 mStaffID;
        
        public Int32 StaffID
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
                return mFirstName
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
                return mLastName
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
                return mDepartment
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
            mStaffID = 10;
            mFirstName = "Kyriakos";
            mLastName = "Diplaros";
            mDepartment = "Owner";
            mJoinDate = Convert.ToDateTime("03/05/2019")
            mActive = true;
            

        
            //always return true
            return true;
        }
    }
}