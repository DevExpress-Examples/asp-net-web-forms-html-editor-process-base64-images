<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxHtmlEditor.v14.2, Version=14.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxHtmlEditor" TagPrefix="dx" %>
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