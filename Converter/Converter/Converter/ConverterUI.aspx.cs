using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Converter.Model;

namespace Converter
{
    public partial class Converter : System.Web.UI.Page
    {
        private ConverterLogic logic ;
        protected void Page_Load(object sender, EventArgs e)
        {
            logic = new ConverterLogic();
            FillDropDownList(DropDownList1);
            FillDropDownList(DropDownList2);
            
        }

        protected void FillDropDownList(DropDownList list)
        {
            if (!IsPostBack)
            {
                foreach (var currency in logic.Currencies)
                {
                    list.Items.Add(currency.Name);    
                }    
            }            
        }

        

        protected void ChangeCourse(object sender, EventArgs args)
        {
            if (sender == DropDownList1)
            {
                ChangeTextBoxValue(DropDownList1, TextBox1);
            }
            else if (sender == DropDownList2)
            {
                ChangeTextBoxValue(DropDownList2, TextBox3);
            }
        }

        protected void ChangeTextBoxValue(DropDownList list, TextBox textBox)
        {
            string name = list.SelectedValue;
            textBox.Text = logic.Currencies.FirstOrDefault(cur => cur.Name == name).ExchangeRate.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double ammount = Double.Parse(TextBox2.Text);
            double fromCourse = Double.Parse(TextBox1.Text);
            double toCourse = Double.Parse(TextBox3.Text);
            result.Text = logic.Exchange(ammount, fromCourse, toCourse).ToString();
        }
    }
    
}