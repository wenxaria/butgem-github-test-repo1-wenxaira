using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace butgem_github_test_repo1
{
    public partial class index : System.Web.UI.Page
    {
        string ad,soyad;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            ad = TextBox1.Text;

            soyad = TextBox2.Text;
            
            Response.Redirect("kayitsayfa.aspx?ad=" + ad + "&soyad=" + soyad) ;
        }
    }
}