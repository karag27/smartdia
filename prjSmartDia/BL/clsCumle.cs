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
    // string[] sAyracListe = { "." };
    // char[] sKirliAyrac = { '_', '-', '!', '<', '>', '\'', '\u0022', '+', '/', '*', '|','?' };
    //   string[] sEdat= {"ve", "ile", "de", "ki","gibi","ama","ancak","fakat","bazı","bir","bu","çok","diğer", "diye","gibi","dolayı","eğer","falan","filan","hangi","hem","beri","bile","böyle","böylece","göre","halen","hatta","hep","her","hiç","için","ise","kadar","madem","mı","mu","mü","o","öbür","öyle","oysa","pek","rağmen","şayet","şey","şu","tamam","tüm","var","yine","yoksa","zaten","zira" };
    //Cumleyi kelimelere bölecek
    //String dizi . ayraçlar
    //Cumleleri . ayırma 
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
    string[] _sEdat;
    public string[] sEdat
    {
        get { return _sEdat; }
        set { _sEdat = value; }
    }

    private List<string> _sCumleler;

    public List<string> sCumleler
    {
        get { return _sCumleler; }
        set { _sCumleler = value; }
    }










    public void EdatTemizle()
    {

        for (int k = 0; k < sKelimeler.Length; k++)
        {
         //   char[] cHarf = sKelimeler[k].Trim().ToCharArray();
            string sYeniKelime = "";

            for (int i = 0; i < sEdat.Length; i++)
            {
                char[] sEdatParcala = sEdat[i].ToCharArray();
                int iSayac = 0;
                for (int j = 0; j <sKelimeler[k].Trim().Length; j++)
                {

                    if (sKelimeler[k].ElementAt(j) == sEdatParcala[i])
                    {
                        iSayac++;
                    }

                }

                if (iSayac== sEdatParcala.Length)
                {
                    sKelimeler[k] ="";
                    sYeniKelime = "";
                    break;

                }
                else
                {
                    sKelimeler[k] = sYeniKelime;
                    sYeniKelime = "";
                }
            }



        }






    }


    public void KelimeAyir()
    {
        foreach (string item in sCumleler)
        {

            sKelimeler = item.Split(' ');


        }
    }


    public void CumleleriAyir(string sParagraf)
    {

        foreach (char  item in sKirliAyrac)
        {
            sParagraf.Replace(item,' ').Trim();
        }

       
        foreach (string item in sAyracListe)
        {
          
            sCumleler = sParagraf.Split(Convert.ToChar(item)).ToList();
        }

    }


}
