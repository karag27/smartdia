using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public static class clsKernel
{
    static List<clsHastalik> _Hastaliklar = new List<clsHastalik>();
    static List<clsKelime> _ElenenKelimeler = new List<clsKelime>();
    static List<clsEslesenKelime> _EslesenKelimeler = new List<clsEslesenKelime>();
    static string _sHastaAciklama = "";
    static List<string> _sHastaAciklamaKelimeleri = new List<string>();


    public static List<clsEslesenKelime> EslenenKelimeler
    {
        get { return _EslesenKelimeler; }
        set { _EslesenKelimeler = value; }
    }

    public static List<clsKelime> ElenenKelimeler
    {
        get { return _ElenenKelimeler; }
        set { _ElenenKelimeler = value; }
    }
        
    public static List<clsHastalik> Hastaliklar
    {
        get { return _Hastaliklar; }
        set { _Hastaliklar = value; }
    }

    public static string sHastaAciklama
    {
        get { return _sHastaAciklama; }
        set { _sHastaAciklama = value; }
    }

    public static void Initialize()
    {
        clsDB DB = new clsDB();
        clsHastalik Hastalik;
        clsBelirti Belirti;
        clsKelime Kelime;
        clsEslesenKelime EslesenKelime;
        DataTable dtHastaliklar, dtHastalikBelirtileri, dtElenenKelimeler,dtEslesenKelimeler;
        DataRow drHastalik, drHastalikBelirtisi, drElenenKelime,drEslesenKelime, drBelirti;

        dtHastaliklar = DB.GetHastaliklar();

        int i = 0, j = 0;
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
                drHastalikBelirtisi = dtHastalikBelirtileri.Rows[j];
                Belirti.iKodu = (int)drHastalikBelirtisi["BelirtiKodu"];
                Belirti.sAdi = drHastalikBelirtisi["BelirtiAdi"].ToString();
                Belirti.iHastalikBelirtiKodu = (int)drHastalikBelirtisi["HastalikBelirtiKodu"];
                Hastalik.Belirtiler.Add(Belirti);
            }
            _Hastaliklar.Add(Hastalik);
        }
        
        dtElenenKelimeler = DB.GetElenenKelimeler();
        for (i = 0; i < dtElenenKelimeler.Rows.Count; i++)
        {
            Kelime = new clsKelime();
            drElenenKelime = dtElenenKelimeler.Rows[i];
            Kelime.iKodu = (int)drElenenKelime["Kodu"];
            Kelime.sAdi = drElenenKelime["Adi"].ToString();
            _ElenenKelimeler.Add(Kelime);
        }

        dtEslesenKelimeler = DB.GetEslesenKelimeler();
        for (i = 0; i < dtEslesenKelimeler.Rows.Count; i++)
        {
            EslesenKelime = new clsEslesenKelime();
            drEslesenKelime = dtEslesenKelimeler.Rows[i];
            EslesenKelime.iKodu = (int)drEslesenKelime["Kodu"];
            EslesenKelime.sAdi = drEslesenKelime["Adi"].ToString();
            EslesenKelime.sEslenigi = drEslesenKelime["Eslenigi"].ToString();
            _EslesenKelimeler.Add(EslesenKelime);
        }
    }

    public static void Process()
    {
        _sHastaAciklamaKelimeleri.Clear();
        _sHastaAciklamaKelimeleri.Add("Erkek");
        _sHastaAciklamaKelimeleri.Add("idrar");
        _sHastaAciklamaKelimeleri.Add("zor");

//        SELECT* FROM tblHastaliklar H
// INNER JOIN tblHastalikBelirtileri HB ON H.Kodu = HB.HastalikKodu
// INNER JOIN tblBelirtiler B ON HB.BelirtiKodu = B.Kodu
// LEFT JOIN tblEslesenKelimeler EK ON EK.Adi = B.Adi
//WHERE B.Adi IN('Baş','Ağrı')

        foreach (string sKelime in _sHastaAciklamaKelimeleri)
        {


        }


    }

}