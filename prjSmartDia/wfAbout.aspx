<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfAbout.aspx.cs" Inherits="prjSmartDia.wfAbout" %>

<%@ Register Src="~/UserControls/Banner2.ascx" TagPrefix="uc1" TagName="Banner2" %>
<%@ Register Src="~/UserControls/Detail1.ascx" TagPrefix="uc1" TagName="Detail1" %>
<%@ Register Src="~/UserControls/Slogan.ascx" TagPrefix="uc1" TagName="Slogan" %>




<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <uc1:Banner2 runat="server" ID="Banner2" />
    <uc1:Detail1 runat="server" ID="Detail1" />
    <uc1:Slogan runat="server" ID="Slogan" />

</asp:Content>
