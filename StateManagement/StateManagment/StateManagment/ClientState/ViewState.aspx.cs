using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagment.Pages
{
    public partial class ViewState : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (ViewState["savedState"] != null)
            {
                SavedValueTextBox.Text = (string)ViewState["savedState"];
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewState["savedState"] = SavingValueTextBox.Text;
        }
    }
}