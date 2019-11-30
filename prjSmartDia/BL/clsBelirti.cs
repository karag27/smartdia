using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsBelirti
{
    int _iKodu = 0;
    int _iHastalikBelirtiKodu = 0;
    string _sAdi = "";



    public string sAdi
    {
        get { return _sAdi; }
        set { _sAdi = value; }
    }


    public int iKodu
    {
        get { return _iKodu; }
        set { _iKodu = value; }
    }

    public int iHastalikBelirtiKodu
    {
        get { return _iHastalikBelirtiKodu; }
        set { _iHastalikBelirtiKodu = value; }
    }


    public clsBelirti()
    {

    }
}