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
        AStaff.FirstName = txtFirstName.Text;
        Session["AStaff"] = AStaff;
        Response.Redirect("StaffViewer.aspx");
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtStaffID_TextChanged(object sender, EventArgs e)
    {

    }
}