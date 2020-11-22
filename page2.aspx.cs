using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawwaz
{
    public partial class page2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == false)
            {
                CheckBox1.Checked = true;
                Button1.BackColor = System.Drawing.Color.Green;
                CheckBox1.Text = "Fawwaz";
            }
            else
            {
                CheckBox1.Checked = false;
                Button1.BackColor = System.Drawing.Color.Pink;
                CheckBox1.Text = "Mango";
            }
              
        }
    }
}