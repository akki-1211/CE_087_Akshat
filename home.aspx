<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication2.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Full name:
            <asp:TextBox ID="fname" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator  ControlToValidate="fname" id="requirefieldvalidator" runat="server"
                Errormessage="Name is required" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Age:
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            <asp:RangeValidator ControlToValidate="age" ID="rangevalidator1" runat="server" ErrorMessage="Age mujst be between 18 to 50"
                Forecolor="Red" Type="Integer" Display="Dynamic" SetFocusonError="true" MaximumValue="50" MinimumValue="18"></asp:RangeValidator>
            <asp:RequiredFieldValidator  ControlToValidate="age" id="RequiredFieldValidatorage" runat="server"
                Errormessage="Age is required" Forecolor="Red" Display="static" BorderColor="Yellow" BorderWidth="1" SetFocusOnError="true">Enter Age in 18 to 50</asp:RequiredFieldValidator>
             <br />
            <br />
            Password:
            <asp:TextBox ID="pswd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator  ControlToValidate="pswd" id="RequiredFieldValidator2" runat="server"
                Errormessage="password is required" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm password:
            <asp:TextBox ID="rpswd" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator  ControlToValidate="rpswd" id="RequiredFieldValidator3" runat="server"
                Errormessage="please retype password!" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:CompareValidator runat="server" ControlToValidate="rpswd" ControlToCompare="pswd" Operator="Equal"  Type="String" Display="Dynamic" ID="comparevalidatorpassword"
                SetFocusOnError="true" Errormessage="Password and confrim password are not same" ForeColor="Red" BorderColor="YellowGreen" BorderWidth="2"></asp:CompareValidator><br>
            Gender:
            <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator  ControlToValidate="RadioButtonList2" id="RequiredFieldValidator4" runat="server"
                Errormessage="Gender is required" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            State :
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" Height="16px" Width="152px" OnSelectedIndexChanged="OnSelectedIndexChanged">
                <asp:ListItem Selected="True">--Select--</asp:ListItem>
                <asp:ListItem>Gujarat</asp:ListItem>
                <asp:ListItem>Maharastra</asp:ListItem>
            </asp:DropDownList>
            <asp:RequiredFieldValidator  ControlToValidate="DropDownList1" id="RequiredFieldValidator5" runat="server"
                Errormessage="State is required" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            City:
            <asp:DropDownList ID="city" runat="server" AutoPostBack="True" Height="16px" Width="183px">
            </asp:DropDownList>
            <asp:RequiredFieldValidator  ControlToValidate="city" id="RequiredFieldValidator6" runat="server"
                Errormessage="City is required" Forecolor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Mobile no. <asp:TextBox ID="mobilenum" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator runat="server" ControlToValidate="mobilenum" ValidationExpression="\d{10}" Errormessage="number must be 10 digits"
                Forecolor="Red" display="Dynamic" SetFocusOnError="true"></asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator  ControlToValidate="mobilenum" id="RequiredFieldValidator7" runat="server"
                Errormessage="Number is required" Forecolor="Red"></asp:RequiredFieldValidator>
             <br />
            <br />
            PAN No.:
            <asp:TextBox ID="pan" runat="server"></asp:TextBox>
            <asp:CustomValidator ControlToValidate="pan" ErrorMessage="value must be start with 'A' or 'B' and length must be 10."
               runat="server" OnServerValidate="custom_PAN" Display="Dynamic" ForeColor="Red" BorderColor="Yellow" BorderStyle="Dotted"> </asp:CustomValidator>
            <asp:RequiredFieldValidator  ControlToValidate="pan" id="RequiredFieldValidator8" runat="server"
                Errormessage="PAN number is required" Forecolor="Red"></asp:RequiredFieldValidator>
                <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Submit" OnClick="Button2_Click" />
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server"></asp:Label>
            <br />

        </div>
    </form>
</body>
</html>
