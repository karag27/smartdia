using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using net.zemberek.erisim;
using net.zemberek.yapi;
using net.zemberek.tr.yapi;
using net.zemberek.yapi.ek;




public class clsZemberek
    {
    private string sKelime;

    public string  _Kelime
    {
        get { return sKelime; }
        set { sKelime = value; }
    }

     Zemberek zKok = new Zemberek(new TurkiyeTurkcesi());
    public string KokGetir(string sKelime)
    {
        Kelime[] cozumler = zKok.kelimeCozumle(sKelime);

        if (cozumler.Length == 0)
        {

            return sKelime;
        }


        Kelime kelime1 = cozumler[0];
        return  kelime1.kok().icerik(); 



    }



    Zemberek zGovde = new Zemberek(new TurkiyeTurkcesi());
    public string GovdeGetir(string skelime)
    {
        Kelime[] cozumler = zGovde.kelimeCozumle(skelime);

        if (cozumler.Length == 0)
        {

            return skelime;
        }

        int igUzunluk = 0;
        int maxIndex = 0;
        for (int i = 0; i < cozumler.Length; i++)
        {
            if (igUzunluk < cozumler[i].ekler().Count)
            {
                igUzunluk = cozumler[i].ekler().Count;
                maxIndex = i;
            }

        }

        Kelime kelime1 = cozumler[maxIndex];

        List<Ek> ekler = kelime1.ekler();
        List<Ek> yeni_ekler = new List<Ek>();

        int j = 0;
        for (int i = 0; i < ekler.Count; i++)
        {

            Boolean cekimEkiMi = false;

            if (    // Cogul Ekleri -ler, -lar
                    (Convert.ToString(ekler[i]).Contains("ISIM_COGUL_LER"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_COGUL_LAR"))

                    // Durum (hal) Ekleri -i, -e, -de, -den
                    || (Convert.ToString(ekler[i]).Contains("ISIM_BELIRTME_I"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_YONELME_E"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KALMA_DE"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_CIKMA_DEN"))

                    // Tamlama
                    || (Convert.ToString(ekler[i]).Contains("ISIM_TAMLAMA_"))
                    /*
                    || (Convert.ToString(ekler[i]).Contains("ISIM_TAMLAMA_I"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_TAMLAMA_IN"))
                     */

                    // Iyelik -im, -in
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_"))
                    /*
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_BEN_IM"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_SEN_IN"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_O_I"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_BIZ_IMIZ"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_SIZ_INIZ"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_SAHIPLIK_ONLAR_LERI"))
                     */

                    // Kisi
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KISI_"))
                    /*
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KISI_BEN_IM"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KISI_SEN_SIN"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KISI_BIZ_IZ"))
                    || (Convert.ToString(ekler[i]).Contains("ISIM_KISI_SIZ_SINIZ"))
                     */

                    // Diger
                    || (Convert.ToString(ekler[i]).Contains("ISIM_TANIMLAMA_DIR"))

                    // Fiiler icin

                    || (Convert.ToString(ekler[i]).Contains("FIIL_GECMISZAMAN_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_SIMDIKIZAMAN_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_GENISZAMAN_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_GELECEKZAMAN_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_KISI_"))
                    //    || (Convert.ToString(ekler[i]).Contains("FIIL_OLUMSUZLUK_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_EMIR_"))
                    //|| (Convert.ToString(ekler[i]).Contains("FIIL_DONUSUM_"))
                    //  || (Convert.ToString(ekler[i]).Contains("ISIM_DONUSUM_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_SART_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_ISTEK_"))
                    || (Convert.ToString(ekler[i]).Contains("IMEK_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_SUREKLILIK_"))
                    || (Convert.ToString(ekler[i]).Contains("FIIL_ZORUNLULUK_"))
                      || (Convert.ToString(ekler[i]).Contains("FIIL_MASTAR_"))
                    )
            {

                cekimEkiMi = true;
            }
            if (cekimEkiMi)
            {
                break;
            }
            else
            {

                yeni_ekler.Add(ekler[i]);
                j++;
            }
        }

        String kelimeson = "";

        if (j > 0)
        {
            kelimeson = zGovde.kelimeUret(kelime1.kok(), yeni_ekler);
        }
        else
        {
            kelimeson = kelime1.kok().icerik();
        }

        return kelimeson;



    }


}