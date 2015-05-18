<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Haser.SmIntegration.Sample.Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1> StokMount Integration Web Service</h1>  
            </hgroup>
            <p>
               This service is used by other platforms to integrate with StockMount.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Click one of the below buttons </h3> <br/>

    <asp:Button ID="setOrder" runat="server" Text="Set New Order" OnClick="setOrder_Click"/> <br/>
    <asp:Button ID="updateOrder" runat="server" Text="Update Order" OnClick="updateOrder_Click" /> <br/> 
    <asp:Button ID="setOrderListingStatus" runat="server" Text="Set Order Listing Status" OnClick="setOrderListingStatus_Click" /><br/><br/>
    <asp:Label ID="lblMessage" runat="server"></asp:Label>
</asp:Content>
