using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace butgem_github_test_repo1
{
    public partial class kayitsayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string gelenad = Request.QueryString[0];
            
            kayit.InnerHtml=("Adınız: " + gelenad);
        }
    }
}