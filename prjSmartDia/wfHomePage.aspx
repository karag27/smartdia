<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfHomePage.aspx.cs" Inherits="prjSmartDia.WebForm1" %>

<%@ Register Src="~/UserControls/Banner1.ascx" TagPrefix="uc1" TagName="Banner1" %>
<%@ Register Src="~/UserControls/Slogan.ascx" TagPrefix="uc1" TagName="Slogan" %>
<%@ Register Src="~/UserControls/Detail1.ascx" TagPrefix="uc1" TagName="Detail1" %>
<%@ Register Src="~/UserControls/Disease.ascx" TagPrefix="uc1" TagName="Disease" %>
<%@ Register Src="~/UserControls/Team.ascx" TagPrefix="uc1" TagName="Team" %>

<asp:Content ID="MainContent1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Banner1 runat="server" ID="Banner1" />
    <uc1:Slogan runat="server" ID="Slogan" />
    <uc1:Detail1 runat="server" ID="Detail1" />
    <uc1:Disease runat="server" ID="Disease" />
    <uc1:Team runat="server" ID="Team" />

</asp:Content>
