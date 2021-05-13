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

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaffData
        ClassLibrary.clsFirstName AnStaffData = new ClassLibrary.clsFirstName();
        //capture the staff id
        AnStaffData.FirstName = txtStaffID.Text;
        //store the address in the session object
        Session["AnStaffData"] = AnStaffData;
        //navigate to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}