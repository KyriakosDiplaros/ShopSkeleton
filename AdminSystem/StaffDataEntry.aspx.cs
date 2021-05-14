using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of the class
        clsStaffData AStaff = new clsStaffData();
        AStaff = (clsStaffData)Session["AStaff"];
        Response.Write(AStaff.FirstName);

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsStaffData AStaff = new clsStaffData();
        string FirstName = txtFirstName.Text;
        string LastName = txtLastName.Text;
        string Department = txtDepartment.Text;
        string StaffID = txtStaffID.Text;
        string JoinDate = txtJoinDate.Text;
        string Error = "";
        Error = AStaff.Valid(FirstName, LastName, Department, StaffID, JoinDate);
        if (Error == "")
        {
            AStaff.FirstName = FirstName;
            AStaff.LastName = LastName;
            AStaff.Department = Department;
            AStaff.StaffID = StaffID;
            AStaff.JoinDate = Convert.ToDateTime(JoinDate);
            clsStaffDataCollection StaffList = new clsStaffDataCollection();
            StaffList.ThisStaff = AStaff;
            StaffList.Add();
            Response.Write("StaffList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsStaffData AStaff = new clsStaffData();
        Int32 StaffID;
        Boolean Found = false;
        StaffID = Convert.ToInt32(txtStaffID.Text);
        Found = AStaff.Find(StaffID);
        if (Found == true)
        {
            txtStaffID.Text = AStaff.StaffID;
            txtFirstName.Text = AStaff.FirstName;
            txtLastName.Text = AStaff.LastName;
            txtDepartment.Text = AStaff.Department;
            txtJoinDate.Text = AStaff.JoinDate;
           
        }
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("AStaff.aspx");

    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 StaffID;
        if (lstStaffList.SelectIndex != -1)
        {
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            Session["StaffID"] = StaffID;
            Response.Redirect("AStaff.aspx");

        }
        else
        {
            lblError.Text = "Please select a record from the list";
        }
    }
}