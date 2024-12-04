<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SingInUser.aspx.cs" Inherits="SingInUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <style>
     body{
         display:flex;
         justify-content:center;
         align-items:center;
         height:100vh;
         overflow:hidden;
         background-color:navy;
     }
     #container{
         display:block;
         border:1px solid #808080;
         width:400px;
         height:300px;
         background-color:black;
         box-shadow:12px 5px 5px #000000;
         border-radius:8px ;

     }
     #user_container,#pwd_container,#btn_container,#err_container{
         height:100px;
         width:400px;
         display:flex;
         justify-content:center;
         align-items:center;
         column-gap:20px;

     }
     #lblName,#lblPwd, #Button1{
         color:aliceblue;
         font-family:'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
         font-size:large;

     }
     #Button1{
         padding:8px 25px;
         border:1px solid #ff0000;
         background-color:transparent;
         cursor:pointer;
         border-radius:5px;
                     


     }
     #err_container{
         color:red;
     }

 </style>
</head>
<body>
    
       
    <form id="form1" runat="server">
        <div>
            <div id="container">

                 <div id="user_container">
                    <asp:Label ID="lblName" runat="server" Text="Kullanıcı Adı : "></asp:Label><asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </div>

                <div id="pwd_container">
                    <asp:Label ID="lblPwd" runat="server" Text="Kullanıcı Şifre :"></asp:Label><asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </div>

                <div id="btn_container">
                    <asp:Button ID="Button1" runat="server" Text="Giriş Yap" OnClick="Button1_Click" />
                </div>
                <div id="err_container">
     <asp:Label ID="lblErr" runat="server" Text=""></asp:Label>
</div>

             </div>

        </div>
    </form>
</body>

</html>
