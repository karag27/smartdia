<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfContact.aspx.cs" Inherits="prjSmartDia.WebForm2" %>

<%@ Register Src="~/UserControls/Contact.ascx" TagPrefix="uc1" TagName="Contact" %>
<%@ Register Src="~/UserControls/Banner2.ascx" TagPrefix="uc1" TagName="Banner2" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:Banner2 runat="server" ID="Banner2" />
    <uc1:Contact runat="server" id="Contact" />

</asp:Content>
