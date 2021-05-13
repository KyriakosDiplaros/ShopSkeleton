using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : Page
{ 
   
    
    

    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clStaffData
        clsFirstName AnFirstName = new clsFirstName();
        //get the data from the session object
        AnFirstName = (clsFirstName)Session["AnFirstName"];
        //display the staff data for this entity
        Response.Write(AnFirstName.FirstName);
    }
}