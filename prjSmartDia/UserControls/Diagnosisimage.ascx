﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Diagnosisimage.ascx.cs" Inherits="prjSmartDia.UserControls.Diagnosisimage" %>
<div class="section-top-border">
    <div class="container" style="margin-top: 20px;">
        <h3 class="mb-30 title_color">TESPİT SONUCU</h3>
    </div>
    <asp:Repeater runat="server" ID="rptrTeshisler" OnItemDataBound="rptrTeshisler_ItemDataBound">
        <ItemTemplate>
            <div class="container" style="margin-top: 70px;">
                <div class="row">
                    <div class="col-lg-3 text-center col-sm-3">
                        <h3 class="mb-30 title_color">
                            <asp:Literal runat="server" ID="ltrlHastalikAdi">

                            </asp:Literal>
                        </h3>
                        <div class="single_department">
                            <div class="dpmt-thumb">
                                <asp:Literal runat="server" ID="ltrlImage">

                                </asp:Literal>
                            </div>
                            <h4></h4>
                        </div>
                        Teşhis Oranı
                        <div class="percentage">
                            <div class="progress">
                                <asp:Literal runat="server" ID="ltrlYuzde">

                                </asp:Literal>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-9 mt-sm-20 left-align-p">
                        <h3 class="mb-30 title_color">DETAYLAR</h3>
                        <p style="text-align: justify;">
                            <asp:Literal runat="server" ID="ltrlHastalikAciklama">

                            </asp:Literal>
                        </p>
                        <h3 class="mb-30 title_color">GENEL BELİRTİLER</h3>
                        <p style="text-align: justify;">
                            <asp:Literal runat="server" ID="ltrlHastalikBelirtiAciklamasi">

                            </asp:Literal>
                        </p>
                        <h3 class="mb-30 title_color">SİSTEM YORUMU</h3>
                        <p style="text-align: justify;">
                            <asp:Literal runat="server" ID="ltrlHastalikSistemAciklamasi">

                            </asp:Literal>
                        </p>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>
</div>
