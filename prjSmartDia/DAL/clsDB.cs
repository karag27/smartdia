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
        cmd = new SQLiteCommand(con);
        cmd.CommandText = sQuery;
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public DataTable RunQueryReturnDataTable(string sQuery)
    {
        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataAdapter adap;
        DataTable dtData = new DataTable("Data");

        con = new SQLiteConnection(sConnectionString);
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
        sQuery = "SELECT * FROM tblElenenKelimeler";
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
}