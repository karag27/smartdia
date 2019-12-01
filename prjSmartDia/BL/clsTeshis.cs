using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class clsTeshis : clsHastalik;
{
    string sBelirtiKodlari = "";
    string sAyrac = "|";
    int _iSayi = 0;
    int _iYuzde = 0;
    int _iEsikDeger = 50;

    public int iSayi
    {
        get { return _iSayi; }
        set { _iSayi = value; }
    }

    public int iYuzde
    {
        get { return _iYuzde; }
        set { _iYuzde = value; }
    }

    public void BelirtiEkle(int iBelirtiKodu)
    {
        if (!bBelirtiVarmi(iBelirtiKodu))
            sBelirtiKodlari = sBelirtiKodlari + sAyrac + iBelirtiKodu.ToString() + sAyrac;
    }

    public bool bBelirtiVarmi(int iBelirtiKodu)
    {
        bool bVarMi = false;
        bVarMi = sBelirtiKodlari.IndexOf(sAyrac + iBelirtiKodu.ToString() + sAyrac) !=-1;
        return bVarMi;
    }

    public clsTeshis()
    {
        
    }
}