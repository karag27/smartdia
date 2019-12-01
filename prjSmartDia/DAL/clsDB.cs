using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SQLite;
public class clsDB
{
    string sConnectionString = "";
    public clsDB()
    {
        sConnectionString = "Data Source=" + HttpContext.Current.Server.MapPath("~/SQLite/SmartDia.db") + "; Version=3;";
    }

    public void RunQuery(string sQuery)
    {
        SQLiteConnection con;
        SQLiteCommand cmd;

        con = new SQLiteConnection(sConnectionString);
        con.Open();
        cmd = new SQLiteCommand(con);
        cmd.CommandText = sQuery;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public int RunQueryReturnID(string sQuery, string sTableName)
    {
        DataTable dtData;
        SQLiteConnection con;
        SQLiteCommand cmd;

        con = new SQLiteConnection(sConnectionString);
        con.Open();
        cmd = new SQLiteCommand(con);
        cmd.CommandText = sQuery;
        cmd.ExecuteNonQuery();
        con.Close();

        sQuery = "SELECT Kodu FROM " + sTableName + " ORDER BY Kodu DESC LIMIT 1";
        dtData = RunQueryReturnDataTable(sQuery);

        return int.Parse(dtData.Rows[0][0].ToString());
    }

    public DataTable RunQueryReturnDataTable(string sQuery)
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter adap;
        DataTable dtData = new DataTable("Data");

        con = new SQLiteConnection(sConnectionString);
        con.Open();
        cmd = new SQLiteCommand(con);
        adap = new SQLiteDataAdapter(cmd);
        cmd.CommandText = sQuery;
        adap.Fill(dtData);

        con.Close();
        return dtData;
    }

    public DataTable GetHastaliklar()
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT * FROM tblHastaliklar";
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetHastalikBelirtileri(int iHastalikKodu)
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT HB.Kodu, HB.HastalikKodu, HB.BelirtiKodu, B.Adi AS BelirtiAdi FROM tblHastalikBelirtileri HB " +
                 " INNER JOIN tblHastaliklar H ON HB.HastalikKodu=H.Kodu " +
                 " INNER JOIN tblBelirtiler B ON HB.BelirtiKodu=B.Kodu " +
                 " WHERE H.Kodu = " + iHastalikKodu.ToString();
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetElenenKelimeler()
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT * FROM tblElenenKelimeler WHERE CumleBaglaciMi = 0";
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetEslesenKelimeler()
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT * FROM tblEslesenKelimeler";
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetCumleAyraclari()
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT * FROM tblElenenKelimeler WHERE CumleBaglaciMi = 1";
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetTeshis(string sKosul)
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT H.Kodu, H.Adi, COUNT(DISTINCT HB.Kodu) AS Sayi FROM tblHastaliklar H " +
                " INNER JOIN tblHastalikBelirtileri HB ON H.Kodu = HB.HastalikKodu " +
                " INNER JOIN tblBelirtiler B ON HB.BelirtiKodu = B.Kodu " +
                " LEFT JOIN tblEslesenKelimeler EK ON EK.Adi = B.Adi " +
                " WHERE " + sKosul +
                " GROUP BY H.Kodu, H.Adi " +
                " ORDER BY COUNT(DISTINCT HB.Kodu) DESC ";
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }
    
    public DataTable GetTalepler(int iTalepKodu)
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT * FROM tblTalepler WHERE Kodu = " + iTalepKodu.ToString();
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public DataTable GetTalepTeshisleri(int iTalepKodu)
    {
        string sQuery = "";
        DataTable dtData = null;
        sQuery = "SELECT T.*, H.Adi AS HastalikAdi, H.Aciklama AS HastalikAciklamasi, " +
                 " H.BelirtiAciklamasi AS HastalikBelirtiAciklamasi FROM tblTeshisler T " +
                 " INNER JOIN tblHastaliklar H ON T.HastalikKodu = H.Kodu WHERE TalepKodu = " + iTalepKodu.ToString();
        dtData = RunQueryReturnDataTable(sQuery);
        return dtData;
    }

    public int SaveTalep(string sAdi, string sSoyadi, string sEmail, string sAciklama)
    {
        string sQuery = "";
        sQuery = " INSERT INTO tblTalepler (Kodu,Adi,Soyadi,MailAdresi,Aciklama,TalepTarihi) VALUES (";
        sQuery = sQuery + GetNextID("tblTalepler").ToString() + ",";
        sQuery = sQuery + "'" + sAdi + "','" + sSoyadi + "','" + sEmail + "','" + sAciklama + "'";
        sQuery = sQuery + ",date('now')) ";
        return RunQueryReturnID(sQuery, "tblTalepler");
    }

    public int SaveTeshis(int iTalepKodu, int iHastalikKodu, int iYuzde, string sAciklama)
    {
        string sQuery = "";
        sQuery = " INSERT INTO tblTeshisler (Kodu,TalepKodu,HastalikKodu,Yuzde,Aciklama) VALUES (";
        sQuery = sQuery + GetNextID("tblTeshisler").ToString() + ",";
        sQuery = sQuery + "" + iTalepKodu.ToString() + "," + iHastalikKodu.ToString() + "," + iYuzde.ToString() + ",'" + sAciklama + "'";
        sQuery = sQuery + ") ";
        return RunQueryReturnID(sQuery, "tblTeshisler");
    }

    public int GetNextID(string sTableName)
    {
        string sQuery = "";
        int iID = 1;
        DataTable dtData;
        sQuery = "SELECT Kodu FROM " + sTableName + " ORDER BY Kodu DESC LIMIT 1";
        dtData = RunQueryReturnDataTable(sQuery);
        if (dtData.Rows.Count > 0)
            iID = int.Parse(dtData.Rows[0][0].ToString()) + 1;
        return iID;
    }
}