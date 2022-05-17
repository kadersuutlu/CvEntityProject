<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="MesajDetay.aspx.cs" Inherits="CvEntityProject.MesajDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Mesaj Detayları</h4>
    <asp:TextBox ID="TextBoxAdSoyad" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br/>
    <asp:TextBox ID="TextBoxMail" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br/>
    <asp:TextBox ID="TextBoxKonu" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBoxMesaj" TextMode="MultiLine" Height="100px" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
</asp:Content>
