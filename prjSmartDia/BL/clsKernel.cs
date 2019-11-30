using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public class clsKernel
{
    clsDB DB = new clsDB();
    List<clsHastalik> _Hastaliklar = new List<clsHastalik>();

    string _sHastaAciklama = "";




    public List<clsHastalik> Hastaliklar
    {
        get { return _Hastaliklar; }
        set { _Hastaliklar = value; }
    }

    public string sHastaliklar
    {
        get { return _sHastaAciklama; }
        set { _sHastaAciklama = value; }
    }





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