using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjSmartDia.UserControls
{
    public partial class Diagnosisimage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void PopulateData()
        {
            string sData = "";
            int iYuzde = 60;
            sData = "<div class=\"progress-bar color-1\"" +
                " role=\"progressbar\" style=\"width: " + iYuzde.ToString() + "%\" aria-valuenow=\"" + iYuzde.ToString() + "\" aria-valuemin=\"0\"" +
                " aria-valuemax=\"100\">%" + iYuzde.ToString() + "</div>";

        }
    }
}