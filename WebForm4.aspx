<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication35.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="StyleSheet4.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="SAVE" OnClick="Button1_Click" style="height: 26px" />
        <asp:Label ID="Label1" runat="server" Text="PLS ENTER YOUR ORDER"></asp:Label>
         <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        
      
        <asp:Label ID="Label3" runat="server" Text="To Delete and update input ID Number"></asp:Label>
       

          <p>

       
        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" Text="Update" OnClick="Button5_Click" />
        </p>

        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      
    </div>
       <div class="topnav">
  
  <div class="search-container">
    <form action="/action_page.php">
      <input type="text" placeholder="Search.." name="search">
      <button type="submit"><i class="fa fa-search"></i></button>
        <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
    </form>
  </div>
</div>
    </form>
</body>
</html>
