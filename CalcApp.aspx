<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalcApp.aspx.cs" Inherits="MyCalculator.CalcApp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
        <style>
    @import url('/Content/Site.css');
      </style>
    <div class="centre">
        <asp:Label ID="labelCurrentOperation" runat="server" Text="" ForeColor="ControlDark" ></asp:Label>
    </div>
    <div class="centre">
        
        <asp:TextBox ID="TextBox1" runat="server" CssClass="text" Type="text" Text="0"  OnTextChanged="TextBox1_TextChanged" ></asp:TextBox><br/>
        <div>
            <asp:Button ID="Button1" runat="server" Text="1" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button2" runat="server" Text="2" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button3" runat="server" Text="3" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Division" runat="server" Text="/" CssClass="button" 
                onclick="Operator_click"/><br />
            <asp:Button ID="Button5" runat="server" Text="4" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button6" runat="server" Text="5" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button7" runat="server" Text="6" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Multiply" runat="server" Text="*" CssClass="button" 
                onclick="Operator_click"/><br />
            <asp:Button ID="Button9" runat="server" Text="7" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button10" runat="server" Text="8" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button11" runat="server" Text="9" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Sum" runat="server" Text="+" CssClass="button" 
                onclick="Operator_click"/><br />
            <asp:Button ID="Button13" runat="server" Text="C.E." CssClass="button" 
                onclick="Button13_Click"/>
            <asp:Button ID="Button14" runat="server" Text="0" CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Button15" runat="server" Text="." CssClass="button" 
                onclick="Button_click"/>
            <asp:Button ID="Substraction" runat="server" Text="-" CssClass="button" 
                onclick="Operator_click"/> 
            
                
        </div>
        <asp:Button ID="Button17" runat="server" Text="Equal To" CssClass="button" 
                onclick="Button17_Click" Width="217px"/>
      </div>

    
</asp:Content>
