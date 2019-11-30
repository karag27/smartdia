<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Diagnosis.ascx.cs" Inherits="prjSmartDia.UserControls.Diagnosis" %>
<div class="section-top-border">
    <div class="container">
        <div class="row">
            <div class="col-md-6">
                <h3 class="mb-30 title_color">Hasta Şikayet Formu</h3>
                <form action="#">
                    <div class="mt-10">
                        <input type="text" name="first_name" placeholder="Adınız" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Adınız'"
                            required class="single-input">
                    </div>
                    <div class="mt-10">
                        <input type="text" name="last_name" placeholder="Soyadınız" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Soyadınız'"
                            required class="single-input">
                    </div>
                    <div class="mt-10">
                        <input type="email" name="EMAIL" placeholder="Mail adresiniz" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Mail adresiniz'"
                            required class="single-input">
                    </div>

                    <div class="mt-10">
                        <textarea class="single-textarea" placeholder="Şikayetiniz" onfocus="this.placeholder = ''" onblur="this.placeholder = 'Şikayetiniz'"
                            required></textarea>
                    </div>
                    <a href="#" class="primary-btn text-uppercase">Tespit et</a>
                </form>
            </div>
            <div class="col-md-6">
                <h3 class="mb-30 title_color">Yazım Kuralları</h3>
                <blockquote class="generic-blockquote">
                    <ul>

                        <li>Lütfen cinsiyetinizi giriniz</li></br>
                        <li>En az 200 karakter</li></br>
                        <li>Şikayetlerinizi en açık şekilde yazınız.</li>
                    </ul>
                </blockquote>
            </div>


        </div>
    </div>
</div>
