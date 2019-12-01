<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Diagnosis.ascx.cs" Inherits="prjSmartDia.UserControls.Diagnosis" %>

<div class="section-top-border">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h3 class="mb-30 title_color">Hasta Şikayet Formu</h3>
                <div id="divForm">
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtAdi" placeholder="Adınız" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Adınız'" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtSoyadi" placeholder="Soyadınız" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Soyadınız'" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtEmail" placeholder="Mail adresiniz" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mail adresiniz'" runat="server"></asp:TextBox>
                    </div>

                    <div class="mt-10" style="border: solid 1px #aaa; margin-bottom: 20px;">

                        <asp:TextBox ID="txtAciklama" runat="server" placeholder="Şikayetiniz" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Şikayetiniz'" cols="20" rows="7" TextMode="MultiLine"></asp:TextBox>
                    </div>
                    <asp:LinkButton ID="btnTespit" class="primary-btn text-uppercase" runat="server" Text="Tespit et" OnClick="btnTespit_Click"></asp:LinkButton>

                </div>
            </div>
            <div class="col-md-6">
                <h3 class="mb-30 title_color">Şikayet Yazım Önerileri</h3>
                <blockquote class="generic-blockquote">
                    <ul>
                        <li>En doğru teşhisin yapılması için aşağıdaki konulara dikkat etmeniz önerilir:</li>
                        </br>
                        <li>Mümkün olan en detaylı şekilde şikayetinizi girdiğinizden emin olunuz.</li>
                        </br>
                        <li>En az 200 karakter kullanmanız tavsiye edilir.</li>
                        </br>
                        <li>Şikayetlerinizi yalın bir dil ile yazmalısınız.</li>
                    </ul>
                </blockquote>
            </div>


        </div>
    </div>
</div>
