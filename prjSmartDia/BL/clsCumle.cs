using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class clsCumle
{
    string _sAdi = "";
    List<clsKelime> _Kelimeler = new List<clsKelime>();
    List<string[]> _KelimeGruplari = new List<string[]>();
    int iMaxGrupAraligi = 5;

    public string sAdi
    {
        get { return _sAdi; }
        set { _sAdi = value; }
    }

    public List<clsKelime> Kelimeler
    {
        get { return _Kelimeler; }
        set { _Kelimeler = value; }
    }

    public List<string[]> KelimeGruplari
    {
        get { return _KelimeGruplari; }
        set { _KelimeGruplari = value; }
    }

    public void KelimeEkle(string sKelime)
    {
        //kelimenin kokunu ve kendisini eklemelisin
        clsKelime Kelime;
        if (sKelime.Trim() != "")
        {
            Kelime = new clsKelime();
            Kelime.sAdi = sKelime;
            _Kelimeler.Add(Kelime);
        }
    }

    public void KelimeGrubuOlustur()
    {
        string[] sGrup = new string[2];
        for (int i = 0; i < Kelimeler.Count; i++)
        {
            sGrup = new string[2];
            sGrup[0] = Kelimeler[i].sAdi;
            sGrup[1] = "";
            _KelimeGruplari.Add(sGrup);

            sGrup = new string[2];
            sGrup[0] = Kelimeler[i].sKok;
            sGrup[1] = "";
            _KelimeGruplari.Add(sGrup);

            for (int j = i + 1; j < Kelimeler.Count && j < i + iMaxGrupAraligi; j++)
            {
                if (Kelimeler[i].sKok != "" && Kelimeler[j].sKok != "")
                {
                    sGrup = new string[2];
                    sGrup[0] = Kelimeler[i].sKok;
                    sGrup[1] = Kelimeler[j].sKok;
                    _KelimeGruplari.Add(sGrup);
                }
            }
        }
    }

    public clsCumle()
    {

    }

}
