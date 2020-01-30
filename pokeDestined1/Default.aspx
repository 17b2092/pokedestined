<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="pokeDestined1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    
    <asp:TextBox ID="e1" runat="server" Placeholder="user@gmail.com"></asp:TextBox> <br>
    <asp:TextBox ID="p1" runat="server" Type="password" Placeholder="password"></asp:TextBox> <br>
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Login1"/>

</asp:Content>
