<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfDiagnosisResult.aspx.cs" Inherits="prjSmartDia.WebForm3" %>

<%@ Register Src="~/UserControls/BannerDiagnosisResult.ascx" TagPrefix="uc1" TagName="BannerDiagnosisResult" %>
<%@ Register Src="~/UserControls/DiagnosisImage.ascx" TagPrefix="uc1" TagName="DiagnosisImage" %>
<%@ Register Src="~/UserControls/BlockQuotes.ascx" TagPrefix="uc1" TagName="BlockQuotes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:BannerDiagnosisResult runat="server" id="BannerDiagnosisResult" />
    <uc1:DiagnosisImage runat="server" id="DiagnosisResult" />
</asp:Content>