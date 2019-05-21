<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="AuctionSystem.product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">











    <asp:Literal ID="Literal1" runat="server"></asp:Literal>

    <table style="width: 100%;">
        <tr>
            <td align="right" style="width: 141px">
                Offer Price :&nbsp;&nbsp;&nbsp; 
            </td>
            <td style="width: 314px">
                 <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 14px" 
                     Width="194px"></asp:TextBox>
            </td>
            <td>
               <asp:Button ID="Button1"
                    runat="server" Text="Button" Width="74px" />
            </td>
        </tr>
       
    </table>









</asp:Content>
