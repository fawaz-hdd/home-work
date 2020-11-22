using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Fawwaz
{
    public partial class page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == string.Empty)
            {
                TextBox1.Text = TextBox2.Text;
                TextBox2.Text = string.Empty;
            }
            else //if(TextBox2.Text == string.Empty)
            {
                TextBox2.Text = TextBox1.Text;
                TextBox1.Text = string.Empty;
            }
        }
    }
}