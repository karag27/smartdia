using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public class clsKernel
{
    clsDB DB = new clsDB();
    List<clsHastalik> Hastaliklar = new List<clsHastalik>();

    string sHastaAciklama = "";

    public clsKernel()
    {


    }

    public void Initialize()
    {
        clsHastalik Hastalik;
        clsBelirti Belirti;
        DataTable dtHastaliklar = DB.GetHastaliklar();
        DataRow drHastalik,drBelirti;
        int i = 0;
        for (i = 0; i < dtHastaliklar.Rows.Count; i++)
        {
            Hastalik = new clsHastalik();
            drHastalik = dtHastaliklar.Rows[0];
            Hastalik.
            iHastalikKodu = (int)drHastalik["Kodu"];
            iHastalikKodu = (int)drHastalik["Kodu"];
        }

    }

}