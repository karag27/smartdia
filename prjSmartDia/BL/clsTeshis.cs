using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class clsTeshis
{
    clsHastalik _Hastalik = new clsHastalik();
    string sBelirtiKodlari = "";
    string sAyrac = "|";
    
    public clsHastalik Hastalik
    {
        get { return _Hastalik; }
        set { _Hastalik = value; }
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