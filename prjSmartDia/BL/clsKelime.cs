using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsKelime
{
    int _iKodu = 0;
    string _sAdi = "";
    
    public int iKodu
    {
        get { return _iKodu; }
        set { _iKodu = value; }
    }

    public string sAdi
    {
        get { return _sAdi; }
        set { _sAdi = value; }
    }

    public clsKelime()
    {

    }
}