using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OldERa
{
    public partial class Customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder sbError = new StringBuilder("");
                
                if (txtName.Text.Equals(""))
            {
                sbError.Append("First Name is Required"+Environment.NewLine);
            }
             if(txtLastName.Text.Equals(""))
            {

                sbError.Append("Last Name is Required");
            }


            if (!string.IsNullOrEmpty(sbError.ToString()))
            {
                lblResultMessage.Text = sbError.ToString();
                return;
            }
            Response.Write(txtName.Text + txtLastName.Text);
        }
    }
}