<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebformApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
   <!-- <meta http-equiv="refresh" content="10"/>-->

    <title> UserDetails</title>
    
   
</head>
<body>
    <h2>UserDetails </h2>



    <form id="form1" runat="server">

        <p>
            &nbsp;</p>

 <table  align ="center">
            <tr>
                <td class="auto-style3">
                    Name</td>
                <td><asp:TextBox ID="txtName" runat="server" Font-Size="Large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="textName" runat="server" ControlToValidate="txtName" ErrorMessage="Required Name" ForeColor="Maroon"></asp:RequiredFieldValidator>
                </td>
            </tr>

            <tr>
                <td class="auto-style3">
                    Address</td>
                <td>
                    <asp:TextBox ID="txtAddress" runat="server" Font-Size="Large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="textAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="RequiredField Address" ForeColor="Maroon"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"> Email 
                    </td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" Font-Size="Large"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="textEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="RequiredField Email" ForeColor="Maroon"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is invalid" ForeColor="#3333CC" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style3">
                    Gender</td>
                <td>
         <asp:RadioButtonList ID="rblGender" runat="server" align ="left">
             <asp:ListItem Text="Male" Value="Male" />
             <asp:ListItem Text="Female" Value="Female" />
        </asp:RadioButtonList>
                    
                   
                    
                    </td>
            </tr>


      <tr>
    <td class="auto-style4">
        CountryName</td>
    <td class="auto-style1">

        <asp:DropDownList ID="ddlCountryName" runat="server" Font-Size="Large"  Width="200px">
            <asp:ListItem>Select</asp:ListItem>
            <asp:ListItem>USA</asp:ListItem>
            <asp:ListItem>Japan</asp:ListItem>
            <asp:ListItem>Germany</asp:ListItem>
            <asp:ListItem>Canada</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="textCountryName" runat="server" ControlToValidate="ddlCountryName" ErrorMessage="RequiredField Country Name" ForeColor="Maroon"></asp:RequiredFieldValidator>
        </td>
      </tr>



     <tr>

    <td class="auto-style3">
        EnterID</td>
    <td class="auto-style2"><asp:TextBox ID="TextEnterID" runat="server" Font-Size="Large" Height="23px" style="margin-top: 13px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
         </td>
</tr>


        </table>



        <asp:Button ID="Button1" runat="server" Height="27px" OnClick="AddMyData" style="margin-left: 351px; margin-top: 39px" Text="insert" Width="81px" />

        

        <asp:Button ID="Button2" runat="server" Height="27px" OnClick="Button2_Click" style="margin-left: 44px" Text="Update" Width="80px" />

        


        <asp:Button ID="Button3" runat="server" Height="27px" OnClick="Button3_Click" style="margin-left: 39px" Text="Delete" Width="69px" />

        


        <asp:GridView ID="GridView1" runat="server" Height="159px" style="margin-left: 257px; margin-top: 39px" Width="536px" ></asp:GridView>
            <AlternatingRowStyle BackColor="#CCCCCC" />

            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />

        
    </form>
</body>
</html>
