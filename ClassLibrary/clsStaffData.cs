using System;

namespace ClassLibrary
{
    public class clsStaffData
    {
        public string FirstName { get; set; }
        public int StaffID { get; set; }
        public bool Active { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public DateTime JoinDate { get; set; }

        public bool Find(int staffID)
        {
            //always return true
            return true;
        }
    }
}