using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment.Pages
{
    public partial class Cookies : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (Request.Cookies["MyCookie"] != null)
            {
                SavedValueTextBox.Text = Request.Cookies["MyCookie"]["Value"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("MyCookie");
            cookie["Value"] = SavingValueTextBox.Text;
            Request.Cookies.Add(cookie); 
        }
    }
}