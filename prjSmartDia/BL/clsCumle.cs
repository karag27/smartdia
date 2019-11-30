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

    string[] sAyracListe = { "." };
    char[] sKirliAyrac = { '_', '-', '!', '<', '>', ' ', '\u0022', '+', '/', '*', '|' };
    string[] sEdat= {"ve","veya" };


    private string[] _sCumeleler;

    public string[] sCumleler
    {
        get { return _sCumeleler; }
        set { _sCumeleler = value; }
    }


    //Cumleyi kelimelere bölecek
    //String dizi . ayraçlar
    //Cumleleri . ayırma 




    public void TemizKelimeler()
    {

        for (int k=0;k<sKelimeler.Length;k++)
        {
            char[] cHarf = sKelimeler[k].ToCharArray();
            string sYeniKelime = "";

            for (int i = 0; i < sKirliAyrac.Length; i++)
            {
         
                for (int j = 0; j < cHarf.Length; j++)
                {

                    if (cHarf[j] != sKirliAyrac[i])
                    {
                        sYeniKelime += Convert.ToString(cHarf[i]);
                        break;
                    }



                }
                sKelimeler[k] = sYeniKelime;
                sYeniKelime = "";

            }



        }

    }




    public void EdatTemizle()
    {

        for (int k = 0; k < sKelimeler.Length; k++)
        {
            char[] cHarf = sKelimeler[k].ToCharArray();
            string sYeniKelime = "";

            for (int i = 0; i < sEdat.Length; i++)
            {
                char[] sEdatParcala = sEdat[i].ToCharArray();
                int iSayac = 0;
                for (int j = 0; j < cHarf.Length; j++)
                {

                    if (cHarf[j] == sEdatParcala[i])
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


    public void KelimeAyirma()
    {
        foreach (string item in sCumleler)
        {

            sKelimeler = item.Split(' ');


        }
    }

    public void CumleleriAyir(string sCumle)
    {

        //sAyraçlistesindeki cahara göre split ediliyor.
        foreach (string item in sAyracListe)
        {
            char cAyrac = Convert.ToChar(item);
            sCumleler = sCumle.Split(cAyrac);


        }

    }


}
