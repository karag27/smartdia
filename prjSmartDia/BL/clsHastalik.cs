using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class clsHastalik
{
    int _iKodu = 0;
    string _sAdi = "";
    List<clsBelirti> _Belirtiler = new List<clsBelirti>();



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



    public List<clsBelirti> Belirtiler
    {
        get { return _Belirtiler; }
        set { _Belirtiler = value; }
    }


    public clsHastalik()
    {

    }
}