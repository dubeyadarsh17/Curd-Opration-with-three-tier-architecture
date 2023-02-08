<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="ThreeArchitecherIntern.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous" />
    <style>
        .card {
            width: 29rem;
            margin-top: 20px;
            margin-left: 374px;
            border-radius: 55px;
            box-shadow: hotpink;
            box-shadow: white;
            box-shadow: 0px 0px 9px;
            overflow: hidden;
        }



        .card-body {
            padding: 30px 42px 72px;
            /* background-image: url('/image/bg.jpg');
            background-size: cover;*/
        }

        .login-form {
            margin-top: 61px;
        }

        body {
            /*  background-image: url('/image/bg.jpg');
            background-size: cover;*/
        }


        .img {
            vertical-align: middle;
            margin-left: 131px;
            margin-top: -22px;
        }
    </style>
    <script type="text/javascript">
        function userValid() {
            debugger;
            var name, mobile, gmail, password, gender, emailExp;
            name = document.getElementById("txtname").value;
            mobile = document.getElementById("txtmob").value;
            var length = document.getElementById("txtmob").value.length;
            gmail = document.getElementById("txtemail").value;
            password = document.getElementById("txtpass").value;
            gender = document.getElementById("RadioButtonList1").value;
            emailExp = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([com\co\.\in])+$/; // to validate email id 
            var passw = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,20}$/;// to validate password

            if (name == '' || mobile == '' || gmail == '' || password == '' || gender == '') {
                swal("Enter All Field")
                return false;
            }
            if (name == '') {
                swal("Enter Name Field")
                return false;
            }
            if (mobile == '') {
                alert("Enter mobile number")
                return false;
            }
            if ((length != 10)) {
                alert("The phone number is the wrong length. \nPlease enter 10 digit mobile no.");
                return false;
            }

            if (gmail == '') {
                alert("Enter gmail Field")
                return false;
            }
            if (!gmail.match(emailExp)) {
                alert("Invalid Email Id");
                return false;
            }

            if (password == '') {
                alert("Enter Password Field")
                return false;
            }
            if (!password.match(passw)) {
                alert("Invalid password")
                return false;
            }
            if (gender == '') {
                alert("Select Gender")
                return false;
            }


        }
    </script>
    <title></title>
</head>
<body>

    <div class="container justify-content-center mt-8">

        <div class="card">
            <div class="card-body">
                <form class="login-form" runat="server">
                    <div>
                        <h1 style="margin-top: -70px; margin-left: 75px;">Registration</h1>
                    </div>
                    <div>
                        <img src="image/usericon.png" class="img" />
                    </div>
                    <div class="mb-2">
                        <asp:TextBox ID="txtname" runat="server" class="form-control" placeholder="Name"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="name is empty" ForeColor="blue" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtname" ErrorMessage="please enter only name" ForeColor="blue" ValidationExpression="^[-a-zA-Z-()]+(\s[-a-zA-Z-()]+)*$" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>--%>
                    </div>
                    <div class="mb-2">
                        <asp:TextBox ID="txtemail" runat="server" class="form-control" placeholder="Email" TextMode="Email" AutoCompleteType="Email"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtemail" ErrorMessage="email is  empty" ForeColor="blue" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtemail" ErrorMessage="Invaild email" ForeColor="blue" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" Display="Dynamic"></asp:RegularExpressionValidator>--%>
                    </div>
                    <div class="mb-2">
                        <asp:TextBox ID="txtpass" runat="server" class="form-control" placeholder="Password" TextMode="Password" MaxLength="8"></asp:TextBox>
                        <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtpass" ErrorMessage="password is empty" ForeColor="blue" SetFocusOnError="True" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ValidationExpression="(?=^.{8,10}$)(?=.*\d)(?=.*[a-zA-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\s).*$" ControlToValidate="txtpass" ErrorMessage="Invaild Password" ForeColor="blue" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>
                        --%>
                    </div>
                    <div class="mb-2">
                        <asp:TextBox ID="txtmob" runat="server" class="form-control" placeholder="Number" MaxLength="10"></asp:TextBox>
                        <%-- <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtmob" ErrorMessage="mobile no. is empty" ForeColor="blue" Display="Dynamic" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtmob" ErrorMessage="Invaild  mobile  no." ForeColor="blue" ValidationExpression="^[7-9][0-9]{9}$" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>--%>
                    </div>
                    <div class="mb-2">
                        <asp:RadioButtonList ID="RadioButtonList1" class="form-control" runat="server" AppendDataBoundItems="True" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Others</asp:ListItem>
                        </asp:RadioButtonList>
                        <%--  <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="select gender" ForeColor="blue" SetFocusOnError="True"></asp:RequiredFieldValidator>
                        --%>
                    </div>

                    <div class="mb-2">
                        <asp:Button ID="Button2" class="form-control" runat="server" Text="Register" OnClick="Button2_Click" OnClientClick ="return userValid()" />

                    </div>
                </form>
            </div>
        </div>

    </div>
</body>
</html>
