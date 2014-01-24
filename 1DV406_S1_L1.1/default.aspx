<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_1DV406_S1_L1._1._default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hur många versaler?</title>
    <link href="~/Content/style.css" rel="stylesheet" />
</head>
<body>
    <div id="container">
        <h1>Hur många versaler?</h1>
        <p id="creator">Nils-Jakob Olsson, no222bd, WP2012(2013) Distans</p>
        <form id="form" runat="server">
            <div>
                <p>
                    <asp:TextBox ID="TextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="Button" runat="server" Text="Bestäm antalet versaler" OnClick="Button_Click" />
                </p>
                <p>
                    <asp:Label ID="ResultLabel" runat="server" Visible="false" ViewStateMode="Enabled"></asp:Label>
                </p>
            </div>
        </form>
    </div><!-- container -->
</body>
</html>
