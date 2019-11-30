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

    char[] _sKirliAyrac;
    public char[] sKirliAyrac
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


    public void EdatTemizle()
    {
        for(int j=0;j<sCumleler.Length;j++)
        {
            for (int i = 0; i < sKirliAyrac.Length; i++)
            {
                if (( sCumleler[j].IndexOf(sKirliAyrac[i]))!=-1)
                {
                  char[] cDonustur = sCumleler[j].ToCharArray();
                    int deger=sCumleler[j].IndexOf(sKirliAyrac[i]);
                    if (cDonustur[deger - 1]!=' ' && cDonustur[deger+ sKirliAyrac.Length+1] != ' ')
                    {
                        sCumleler[j] = sCumleler[j].Replace(sKirliAyrac[i], ' ');
                    } 

                    

                }

            }

        }
       
    }


 

    public void bosluklariAl()
    {
      
            for (int i = 0; i < sCumleler.Length; i++)
            {
               

            while (sCumleler[i].IndexOf("  ") != -1)
            {

                sCumleler[i] = sCumleler[i].Replace("  ", " ");
            }
        }
       
    }

    


    public string[] CumleleriAyir(string sParagraf)
    {

        foreach (char  item in sKirliAyrac)
        {
            sParagraf=sParagraf.Replace(item,' ');

        }

       
        foreach (string item in sAyracListe)
        {
            sCumleler = sParagraf.Split(Convert.ToChar(item));
        }

        EdatTemizle();
        bosluklariAl();
        return sCumleler;

    }


}
