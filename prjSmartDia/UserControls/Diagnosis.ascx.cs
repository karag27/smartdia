using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjSmartDia.UserControls
{
    public partial class Diagnosis : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTespit_Click(object sender, EventArgs e)
        {
            int iTalepID = 0;
            string sURL = "";
            sURL = "~/wfDiagnosisResult.aspx?TalepID=" + iTalepID.ToString();
            Response.Redirect(sURL);
        }
    }
}