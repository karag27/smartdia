<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Diagnosis.ascx.cs" Inherits="prjSmartDia.UserControls.Diagnosis" %>
<div class="section-top-border">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h3 class="mb-30 title_color">Hasta Şikayet Formu</h3>
                <div id="divForm">
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtAdi" name="first_name" placeholder="Adınız" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Adınız'" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtSoyadi" name="last_name" placeholder="Soyadınız" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Soyadınız'" runat="server"></asp:TextBox>
                    </div>
                    <div class="mt-10" style="border: solid 1px #aaa;">
                        <asp:TextBox ID="txtEmail" name="EMAIL" placeholder="Mail adresiniz" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mail adresiniz'" runat="server"></asp:TextBox>
                    </div>

                    <div class="mt-10" style="border: solid 1px #aaa;margin-bottom: 20px;">

                        <textarea id="txtSikayet" placeholder="Şikayetiniz" required class="single-input" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Şikayetiniz'" cols="20" rows="7"></textarea>
                    </div>
                    <asp:Button ID="btnTespit" class="primary-btn text-uppercase" runat="server" Text="Tespit et" OnClick="btnTespit_Click" />

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
