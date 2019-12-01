<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="wfDiagnosis.aspx.cs" Inherits="prjSmartDia.wfDiagnosis" %>

<%@ Register Src="~/UserControls/BannerDiagnosis.ascx" TagPrefix="uc1" TagName="BannerDiagnosis" %>
<%@ Register Src="~/UserControls/Diagnosis.ascx" TagPrefix="uc1" TagName="Diagnosis" %>
<%@ Register Src="~/UserControls/BlockQuotes.ascx" TagPrefix="uc1" TagName="BlockQuotes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <uc1:BannerDiagnosis runat="server" ID="BannerDiagnosis" />

    <asp:UpdatePanel runat="server" ID="upPanel" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="section-top-border">
                <div class="container">
                    <div class="row">
                        <div class="col-md-6">
                            <h3 class="mb-30 title_color">Hasta Şikayet Formu</h3>
                            <div id="divForm">
                                <div class="mt-10" style="border: solid 1px #aaa;">
                                    <asp:TextBox ID="txtAdi" placeholder="Adınız" class="single-input" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-10" style="border: solid 1px #aaa;">
                                    <asp:TextBox ID="txtSoyadi" placeholder="Soyadınız" class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Soyadınız'" runat="server"></asp:TextBox>
                                </div>
                                <div class="mt-10" style="border: solid 1px #aaa;">
                                    <asp:TextBox ID="txtEmail" placeholder="Mail adresiniz" class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mail adresiniz'" runat="server"></asp:TextBox>
                                </div>

                                <div class="mt-10" style="border: solid 1px #aaa; margin-bottom: 20px;">

                                    <asp:TextBox ID="txtAciklama" runat="server" placeholder="Şikayetiniz" class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Şikayetiniz'" cols="20" Rows="7" TextMode="MultiLine"></asp:TextBox>
                                </div>
                                <asp:LinkButton ID="btnTespit" class="primary-btn text-uppercase" runat="server" Text="Tespit et" OnClick="btnTespit_Click"></asp:LinkButton>

                            </div>
                        </div>
                        <div class="col-md-6">
                            <h3 class="mb-30 title_color">Yazım Kuralları</h3>
                            <blockquote class="generic-blockquote">
                                <ul>
                                    <li>Lütfen cinsiyetinizi giriniz</li>
                                    </br>
                        <li>En az 200 karakter</li>
                                    </br>
                        <li>Şikayetlerinizi en açık şekilde yazınız.</li>
                                </ul>
                            </blockquote>
                        </div>


                    </div>
                </div>
            </div>
        </ContentTemplate>
        <Triggers>
            
        </Triggers>
    </asp:UpdatePanel>
</asp:Content>
