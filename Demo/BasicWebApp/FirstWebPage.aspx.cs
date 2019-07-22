using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebApp
{
    public partial class FirstWebPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList alist = new ArrayList();
            int i;
            string arrayValue;
            for (i = 0; i < 5; i++)
            {
                arrayValue = "i = " + i.ToString();
                alist.Add(arrayValue);
            }
            i = DisplayArray(alist);
            Label1.Text = TextBox1.Text + ", welcome to Visual Studio!";
        }

        private int DisplayArray(ArrayList alist)
        {
            int i;
            for (i = 0; i < alist.Count; i++)
            {
                Response.Write("<br />" + alist[i]);
            };
            return i;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = Calendar1.SelectedDate.ToString("yyyy-MM-dd");
        }
    }
}