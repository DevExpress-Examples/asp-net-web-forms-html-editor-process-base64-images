<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Base64 Handling</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxHtmlEditor ID="ASPxHtmlEditor1" runat="server" OnHtmlCorrecting="ASPxHtmlEditor1_HtmlCorrecting">
        </dx:ASPxHtmlEditor>
    </form>
</body>
</html>