using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsEslesenKelime: clsKelime
{
    string _sEslenigi = "";
    

    public string sEslenigi
    {
        get { return _sEslenigi; }
        set { _sEslenigi = value; }
    }


}