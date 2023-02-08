<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/DashBoard.Master" CodeBehind="admin.aspx.cs" Inherits="ThreeArchitecherIntern.admin" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.2.0/css/all.min.css" integrity="sha512-xh6O/CkQoPOWDdYTDqeRdPCVd1SpvCA9XXcUnZS2FmJNp1coAFzvtCN9BmamE+4aHK8yyUHUSCcJHgXloTyT2A==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js" integrity="sha512-aVKKRRi/Q/YV+4mjoKBsE4x3H+BkegoM/em46NNlCqNTmUYADjBbeNefNxYV7giUp0VxICtqdrbqU7iVaeZNXA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <link rel="stylesheet" href="//cdn.datatables.net/1.12.1/css/jquery.dataTables.min.css" />
    <%--<link href="BootStrap/css/dataTables.bootstrap5.min.css" rel="stylesheet" />
  <script src="BootStrap/css/dataTables.bootstrap5.min.js"></script>--%>
    <script src="//cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js"></script>
    <script>
        $(document).ready(function () {
            $('#mytable').DataTable();

        });
  </script>
    <%-- <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>--%>
    <title></title>
</head>
<body>
    <form id="form1">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">
                <HeaderTemplate>
                    <table class="tblcolor" id="mytable">
                        <thead>
                            <tr>
                                <th>Id</th>
                                <th>Name </th>
                                <th>Email </th>
                                <th>Mobile </th>
                                <th>Gender</th>
                                <th>UserType </th>
                                <th>Image</th>
                                <th>Modify</th>
                            </tr>
                        </thead>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr class="tblrowcolor">
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("id") %>'></asp:Label>
                            <asp:Label ID="Label7" runat="server" Text='<%# Bind("id") %>' Visible="false"></asp:Label>

                        </td>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("name") %>'></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("name") %>' Visible="false"></asp:TextBox>

                        </td>
                        <td>
                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("email") %>'></asp:Label>
                            <asp:Label ID="Label8" runat="server" Text='<%# Bind("email") %>' Visible="false"></asp:Label>

                        </td>
                        <td>
                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("mob") %>'></asp:Label>
                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("mob") %>' Visible="false"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="Label6" runat="server" Text='<%# Bind("gender") %>'></asp:Label>
                            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Text='<%# Bind("gender") %>' Visible="false">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                                <asp:ListItem>Others</asp:ListItem>
                            </asp:RadioButtonList>
                        </td>
                        <td>
                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("usertype") %>'></asp:Label>
                            <asp:DropDownList ID="DropDownList1" runat="server" Text='<%# Bind("usertype") %>' Visible="false">
                                <asp:ListItem>User</asp:ListItem>
                                <asp:ListItem>Admin</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Image ID="Image1" runat="server" ImageUrl='<%# Bind("image") %>' Height="30px" Width="40px" onchange="ShowImagePreview(this);" />
                            <asp:Image ID="Image2" runat="server" ImageUrl='<%# Bind("image") %>' Visible="false" Height="80px" Width="100px" />
                            <asp:FileUpload ID="FileUpload1" runat="server" Visible="false" />
                        </td>
                        <td>
                            <asp:LinkButton ID="lnkEdit" Text="Edit" runat="server" OnClick="OnEdting" CommandName="Edit" />
                            <asp:LinkButton ID="lnkUpdate" Text="Update" runat="server" Visible="false" CommandName="Update" />
                            <asp:LinkButton ID="lnkCancel" Text="Cancel" runat="server" OnClick="OnCancel" Visible="false" CommandName="Cancle" />
                            <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" CommandName="Delete" />
                        </td>
                    </tr>
                </ItemTemplate>

                <FooterTemplate>
                    </table>  
                </FooterTemplate>

            </asp:Repeater>
            <%--<script>
                $(document).ready(() => {
                    $("#FileUpload1").change(function () {
                        const file = this.files[0];
                        if (file) {
                            let reader = new FileReader();
                            reader.onload = function (event) {
                                $("#Image2")
                                    .attr("src", event.target.result);
                            };
                            reader.readAsDataURL(file);
                        }
                    });
                });
            </script>
            --%>
        </div>
    </form>
</body>
</html>
</asp:Content>
