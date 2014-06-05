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
    public partial class HiddenField : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            string str = HiddenField1.Value;
            byte[] b1 = Convert.FromBase64String(str);
            string savedValue = Encoding.UTF8.GetString(b1);
            SavedValueTextBox.Text = savedValue;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = SavingValueTextBox.Text;
            byte[] b1 = Encoding.UTF8.GetBytes(str);
            string data64 = Convert.ToBase64String(b1);
            HiddenField1.Value = data64;
            
        }
    }
}