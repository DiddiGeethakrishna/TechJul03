using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] str = new string[] { "Select", "BMW", "Tata", "Kia" };
                for (int i = 0; i < str.Length; i++)
                {
                    DropDownList1.Items.Add(str[i]);
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = DropDownList1.Text;
            Image1.ImageUrl = "~/images/" + str + ".jfif";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Select")
            {
                Label1.Text = "Please Select a Car";
            }
            else if (DropDownList1.Text == "BMW")
            {
                Label1.Text = "Rs.2000000";
            }
            else if (DropDownList1.Text == "Tata")
            {
                Label1.Text = "Rs.800000";
            }
            else if (DropDownList1.Text == "Kia")
            {
                Label1.Text = "Rs.1000000";
            }
            else
                Label1.Text = "";
        }
    }
}