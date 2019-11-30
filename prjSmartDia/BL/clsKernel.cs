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
        DataTable dtHastaliklar, dtHastalikBelirtileri;
        DataRow drHastalik, drBelirti;

        dtHastaliklar = DB.GetHastaliklar();

        int i = 0, j = 0, iHastalikKodu = 0;
        for (i = 0; i < dtHastaliklar.Rows.Count; i++)
        {
            Hastalik = new clsHastalik();
            drHastalik = dtHastaliklar.Rows[i];
            Hastalik.iKodu = (int)drHastalik["Kodu"];
            Hastalik.sAdi = drHastalik["Adi"].ToString();
            dtHastalikBelirtileri = DB.GetHastalikBelirtileri(Hastalik.iKodu);
            for (j = 0; j < dtHastalikBelirtileri.Rows.Count; i++)
            {
                Belirti = new clsBelirti();
                drBelirti = dtHastalikBelirtileri.Rows[j];
                Belirti.iKodu = (int)dtHastalikBelirtileri["BelirtiKodu"];
                Belirti.sAdi = dtHastalikBelirtileri["BelirtiAdi"].ToString();
                Belirti.iHastalikBelirtiKodu = (int)dtHastalikBelirtileri["HastalikBelirtiKodu"];
                Hastalik.Belirtiler.Add(Belirti);
            }
            Hastaliklar.Add(Hastalik);
        }

    }

}