using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment.Pages
{
    public partial class QueryString : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (Request.QueryString.Get("Value") != null)
            {
                SavedValueTextBox.Text = Request.QueryString.Get("Value");
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryString.aspx?Value=" + SavingValueTextBox.Text);
        }
    }
}