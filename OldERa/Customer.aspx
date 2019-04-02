<%@ Page Language="C#" MasterPageFile="~/Site.Master"  AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="OldERa.Customer" %>



    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    

   <head>
  <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
        <div>
  <div class="form-group">
    <label for="exampleInputEmail1">First Name</label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox> 

      <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Name is Required" ControlToValidate="txtName"></asp:RequiredFieldValidator>

  </div>
  <div class="form-group">
    <label for="exampleInputPassword1">Last Name</label>
   <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
      <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Last Name is Required" ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
  </div>
  
  <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </div>
       <asp:Label ID="lblResultMessage" runat="server" Text=""></asp:Label>  

</asp:Content>

