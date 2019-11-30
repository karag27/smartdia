<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfContact.aspx.cs" Inherits="prjSmartDia.WebForm2" %>

<%@ Register Src="~/UserControls/BannerContent.ascx" TagPrefix="uc1" TagName="BannerContent" %>
<%@ Register Src="~/UserControls/Banner2.ascx" TagPrefix="uc1" TagName="Banner2" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <uc1:BannerContent runat="server" ID="BannerContent" />
    <uc1:Contact runat="server" id="Contact" />

</asp:Content>
