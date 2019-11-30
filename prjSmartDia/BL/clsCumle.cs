using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


    public class clsCumle
    {

    private string[] _sKelimeler;

    public string[] sKelimeler
    {
        get { return _sKelimeler; }
        set { _sKelimeler = value; }
    }

    //method kelimeleri ayırma kelimeleri parçalama 
    //bağlaçlarda ayırma yontemi

    string[] sAyracListe = {"." };
    string[] sKirliAyrac = {"_","-","!","<",">","'","\u0022","+","/","*","|"};
    string[] sEdat;


    private string[] _sCumeleler;

    public string[] sCumleler
    {
        get { return _sCumeleler; }
        set { _sCumeleler = value; }
    }


    //Cumleyi kelimelere bölecek
    //String dizi . ayraçlar
    //Cumleleri . ayırma 
   
        public void CumleleriAyir(string sCumle)
    {
        foreach (string item in sAyracListe )
        {
            char cAyrac = Convert.ToChar(item);
            sCumleler = sCumle.Split(cAyrac);


        }

    }


    public void TemizKelimeler()
    {
        foreach (string item in sKelimeler)
        {
            char[] cHarf = item.ToCharArray();
         

            for (int i = 0; i <sKirliAyrac.Length ; i++)
            {



            }   



        }

    }


    public void KelimeAyirma()
    {
        foreach (string item in sCumleler)
        {

            sKelimeler = item.Split(' ');


        }
    }



}
