using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace prjSmartDia.UserControls
{
    public partial class Diagnosisimage : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateData();
        }
        private void PopulateData()
        {
            clsDB DB = new clsDB();
            DataTable dtData;
            int iTalepKodu = 0 ;

            iTalepKodu = int.Parse(Request["TalepKodu"].ToString());

            dtData = DB.GetTalepTeshisleri(iTalepKodu);
           
            rptrTeshisler.DataSource = dtData;
            rptrTeshisler.DataBind();

            if(dtData.Rows.Count==0)
            {
                Response.Redirect("wfDiagnosis.aspx?NoResults=1");
            }

        }

        protected void rptrTeshisler_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            DataRow drData = (e.Item.DataItem as DataRowView).Row;
            Literal ltrlHastalikAdi = e.Item.FindControl("ltrlHastalikAdi") as Literal;
            Literal ltrlImage = e.Item.FindControl("ltrlImage") as Literal;
            Literal ltrlYuzde = e.Item.FindControl("ltrlYuzde") as Literal;
            Literal ltrlHastalikAciklama = e.Item.FindControl("ltrlHastalikAciklama") as Literal;
            Literal ltrlHastalikBelirtiAciklamasi = e.Item.FindControl("ltrlHastalikBelirtiAciklamasi") as Literal;
            Literal ltrlHastalikSistemAciklamasi = e.Item.FindControl("ltrlHastalikSistemAciklamasi") as Literal;

            ltrlImage.Text = "<img src=\"img/hastalik" + drData["HastalikKodu"].ToString() + ".png\" alt=\"\">";
            ltrlYuzde.Text = "<div class=\"progress-bar color-1\"" +
                            " role=\"progressbar\" style=\"width: " + drData["Yuzde"].ToString() + "%\" aria-valuenow=\"" + drData["Yuzde"].ToString() + "\" aria-valuemin=\"0\"" +
                            " aria-valuemax=\"100\">%" + drData["Yuzde"].ToString() + "</div>";

            ltrlHastalikAciklama.Text = drData["HastalikAciklamasi"].ToString();
            ltrlHastalikBelirtiAciklamasi.Text = drData["HastalikBelirtiAciklamasi"].ToString();
            ltrlHastalikSistemAciklamasi.Text = drData["Aciklama"].ToString();

            ltrlHastalikAdi.Text = drData["HastalikAdi"].ToString();
        }
    }
}