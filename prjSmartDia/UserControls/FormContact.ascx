<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="FormContact.ascx.cs" Inherits="prjSmartDia.UserControls.FormContact" %>
 <section class="contact_area section_gap">
        <div class="container">
<div class="row">
                <div class="col-lg-3">
                    <div class="contact_info">
                        <div class="info_item">
                            <i class="lnr lnr-home"></i>
                            <h6>İstanbul / Türkiye</h6>
                            <p>Bilişim Vadisi</p>
                        </div>
                        <div class="info_item">
                            <i class="lnr lnr-phone-handset"></i>
                            <h6><a href="#">00 (440) 9865 562</a></h6>
                            <p>Haftaiçi hergün</p>
                        </div>
                        <div class="info_item">
                            <i class="lnr lnr-envelope"></i>
                            <h6><a href="#">cengizsertkaya@iesu.edu.tr</a></h6>
                        </div>
                    </div>
                </div>
                <div class="col-lg-9">
                    <form class="row contact_form" action="contact_process.php" method="post" id="contactForm"
                        novalidate="novalidate">
                        <div class="col-md-6">
                            <div class="form-group">
                                <input type="text" class="form-control" id="name" name="name" placeholder="Adınız">
                            </div>
                            <div class="form-group">
                                <input type="email" class="form-control" id="email" name="email" placeholder="E-mail">
                            </div>
                            <div class="form-group">
                                <input type="text" class="form-control" id="subject" name="subject" placeholder="Enter Subject">
                            </div>
                        </div>
                        <div class="col-md-6">
                            <div class="form-group">
                                <textarea class="form-control" name="message" id="message" rows="1" placeholder="Enter Message"></textarea>
                            </div>
                        </div>
                        <div class="col-md-12 text-right">
                            <button type="submit" value="submit" class="primary-btn text-uppercase">Send Message</button>
                        </div>
                    </form>
                </div>
            </div>
            </div>
    </section>