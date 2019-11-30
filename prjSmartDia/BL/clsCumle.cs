using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class clsCumle
    {

    string[] _sAyracListe;

    public string[] sAyracListe
    {
        get { return _sAyracListe; }
        set {_sAyracListe = value; }
    }

    string[] _sKirliAyrac;
    public string[] sKirliAyrac
    {
        get { return _sKirliAyrac; }
        set { _sKirliAyrac = value; }
    }
  

    private string[] _sCumleler;

    public string[] sCumleler
    {
        get { return _sCumleler; }
        set { _sCumleler = value; }
    }


    public void EdatTemizle(string sParagraf)
    {
        for (int i = 0; i < sKirliAyrac.Length; i++)
        {
            while (sParagraf.IndexOf(sKirliAyrac[i])!=-1)
            {
                if (sParagraf[sParagraf.IndexOf(sKirliAyrac[i])-1]==' ' && sParagraf[sParagraf.IndexOf(sKirliAyrac[i])+sKirliAyrac[i].Length ] ==' ')
                {
                    sParagraf = sParagraf.Replace(sKirliAyrac[i], " ");
                }

            }

        }
       
    }


 

    public void bosluklariAl(string sParagraf)
    {
      

            while (sParagraf.IndexOf("  ") != -1)
            {

            sParagraf = sParagraf.Replace("  ", " ");
            }
        
       
    }

    


    public string[] CumleleriAyir(string sParagraf)
    {
       
        /*foreach (char  item in sKirliAyrac)
        {
            sParagraf=sParagraf.Replace(item,' ');

        }
        */
       
  

        EdatTemizle(sParagraf);
        bosluklariAl(sParagraf);
        return sCumleler;

    }


}
