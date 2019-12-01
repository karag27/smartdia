<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfDiagnosis.aspx.cs" Inherits="prjSmartDia.wfDiagnosis" %>

<%@ Register Src="~/UserControls/BannerDiagnosis.ascx" TagPrefix="uc1" TagName="BannerDiagnosis" %>
<%@ Register Src="~/UserControls/Diagnosis.ascx" TagPrefix="uc1" TagName="Diagnosis" %>
<%@ Register Src="~/UserControls/BlockQuotes.ascx" TagPrefix="uc1" TagName="BlockQuotes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:BannerDiagnosis runat="server" id="BannerDiagnosis" />
    <uc1:Diagnosis runat="server" id="Diagnosis" />
</asp:Content>
