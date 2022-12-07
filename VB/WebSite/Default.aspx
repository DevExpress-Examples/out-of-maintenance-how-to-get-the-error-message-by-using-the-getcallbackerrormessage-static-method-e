<%@ Page Language="vb" AutoEventWireup="true"  CodeFile="Default.aspx.vb" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v15.1" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxButton id="ASPxButton1" runat="server" AutoPostBack="False" text="Perform Callback">
            <ClientSideEvents Click="function(s, e) { callback1.PerformCallback(); }"></ClientSideEvents>
        </dx:ASPxButton>
        <dx:ASPxCallback ID="ASPxCallback1" runat="server" ClientInstanceName="callback1"></dx:ASPxCallback>
    </form>
</body>
</html>