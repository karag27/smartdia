using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public static class clsUtilities
{


    public static string CiftBosluklariTemizle(string sParagraf)
    {
        while (sParagraf.IndexOf("  ") != -1)
        {
            sParagraf = sParagraf.Replace("  ", " ");
        }
        return sParagraf;
    }

    public static string ElenenKelimeleriTemizle(string sParagraf, List<clsKelime> ElenenKelimeler)
    {
        foreach (clsKelime ElenenKelime in ElenenKelimeler)
        {
            sParagraf.Replace(" " + ElenenKelime.sAdi + " ", " ");
            sParagraf.Replace("." + ElenenKelime.sAdi + " ", ".");
            sParagraf.Replace(" " + ElenenKelime.sAdi + ".", ".");
        }
        return sParagraf;
    }

    public static List<clsCumle> CumlelereBol(string sParagraf, List<clsKelime> CumleAyraclari)
    {
        List<clsCumle> Cumleler = new List<clsCumle>();
        clsCumle Cumle;
        string[] sCumleler;
        string[] sKelimeler;
        string[] sCumleAyiranNoktalamaIsaretleri = { ".", ":", ";" };
        foreach (clsKelime CumleAyraci in CumleAyraclari)
        {
            sParagraf = sParagraf.Replace(" " + CumleAyraci.sAdi + " ", "#");
        }

        foreach (string sCumleAyiranNoktalamaIsareti in sCumleAyiranNoktalamaIsaretleri)
        {
            sParagraf = sParagraf.Replace(sCumleAyiranNoktalamaIsareti, "#");
        }

        sCumleler = sParagraf.Split('#');

        foreach (string sCumle in sCumleler)
        {
            Cumle = new clsCumle();
            Cumle.sAdi = CiftBosluklariTemizle(sCumle);
            sKelimeler = Cumle.sAdi.Split(' ');
            foreach (string sKelime in sKelimeler)
            {
                Cumle.KelimeEkle(sKelime);
            }
            Cumle.KelimeGrubuOlustur();
            Cumleler.Add(Cumle);
        }

        return Cumleler;
    }

    public static string sTeshisKosulOlustur(List<clsCumle> Cumleler)
    {
        string sKosul = " 1=0 ";
        foreach (clsCumle Cumle in Cumleler)
        {
            foreach (string[] sGrup in Cumle.KelimeGruplari)
            {
                if (sGrup[1] != "")
                    sKosul = sKosul + " OR (B.Adi LIKE '%" + sGrup[0] + "%' AND B.Adi LIKE '%" + sGrup[1] + "%')";
                else
                {
                    sKosul = sKosul + " OR (B.Adi LIKE '%" + sGrup[0] + "%' AND DirektAl = 0)";
                    sKosul = sKosul + " OR (B.Adi LIKE '" + sGrup[0] + "' AND DirektAl = 1)";
                }
            }
        }
        return sKosul;
    }
}