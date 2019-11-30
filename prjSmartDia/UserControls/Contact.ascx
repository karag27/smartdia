<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Contact.ascx.cs" Inherits="prjSmartDia.UserControls.Contact" %>
<!--================Contact Area =================-->
    <section class="contact_area section_gap">
        <div class="container">
<iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3020.617114983389!2d29.508856515367572!3d40.792430979323335!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14cb219fb27ddacf%3A0x5e5dbea1b92cca7f!2sBili%C5%9Fim%20Vadisi!5e0!3m2!1sen!2str!4v1575117623990!5m2!1sen!2str" width="100%" height="420" frameborder="0" style="border:0;" allowfullscreen=""></iframe>            
            <div class="row">
                <div class="col-lg-3">
                    <div class="contact_info">
                        <div class="info_item">
                            <i class="lnr lnr-home"></i>
                            <h6>California, United States</h6>
                            <p>Santa monica bullevard</p>
                        </div>
                        <div class="info_item">
                            <i class="lnr lnr-phone-handset"></i>
                            <h6><a href="#">00 (440) 9865 562</a></h6>
                            <p>Mon to Fri 9am to 6 pm</p>
                        </div>
                        <div class="info_item">
                            <i class="lnr lnr-envelope"></i>
                            <h6><a href="#">support@colorlib.com</a></h6>
                            <p>Send us your query anytime!</p>
                        </div>
                    </div>
                </div>
                <div class="col-lg-9">
                    <form class="row contact_form" action="contact_process.php" method="post" id="contactForm"
                        novalidate="novalidate">
                        <div class="col-md-6">
                            <div class="form-group">
                                <input type="text" class="form-control" id="name" name="name" placeholder="Enter your name">
                            </div>
                            <div class="form-group">
                                <input type="email" class="form-control" id="email" name="email" placeholder="Enter email address">
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
    <!--================Contact Area =================-->