using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Profile;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment.Pages
{
    public partial class Profiles : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (Application["Value"] != null)
            {
                SavedValueTextBox.Text = (string)Application["Value"];
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          //  Profile.Name = SavingValueTextBox.Text;
           // Profile.VisitedOn = DateTime.Now;
           // Profile.Save();
        }
    }
}