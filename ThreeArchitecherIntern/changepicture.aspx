<%@ Page Title="" Language="C#" MasterPageFile="~/DashBoard.Master" AutoEventWireup="true" CodeBehind="changepicture.aspx.cs" Inherits="ThreeArchitecherIntern.changepicture" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous" />

    <script src="//code.jquery.com/jquery-1.11.2.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function ShowImagePreview(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();
                reader.onload = function (e) {
                    $('#<%=Image1.ClientID%>').prop('src', e.target.result)
                        .width(240)
                        .height(150);
                };
                reader.readAsDataURL(input.files[0]);
            }
        }
    </script>
    <style>
        .card {
            width: 29rem;
            margin-top: 58px;
            margin-left: 354px;
            border-radius: 55px;
            box-shadow: hotpink;
            box-shadow: white;
            box-shadow: 0px 0px 9px;
            overflow: hidden;
        }

        .card-body {
            padding: 30px 42px 72px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <form id="form1">
            <div class="container justify-content-center mt-8">

                <div class="card">
                    <div class="card-body">

                        <div class="mb-4">
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("image") %>' Height="150px" Width="240px" />
                        </div>
                        <div class="mb-4">
                            <asp:FileUpload ID="FileUpload1" runat="server" onchange="ShowImagePreview(this);" />
                        </div>
                        <div class="mb-4">
                            <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click1" />
                        </div>
                        <div class="mb-4">
                            <asp:Label ID="Label1" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </form>
    </div>
</asp:Content>
