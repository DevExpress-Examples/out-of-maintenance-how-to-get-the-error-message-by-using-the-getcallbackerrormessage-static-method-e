Imports System
Imports System.Web.UI
Imports DevExpress.Web.ASPxClasses

Partial Public Class [Error]
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim errorMessage As String = ASPxWebControl.GetCallbackErrorMessage()
        Response.Output.Write(errorMessage)
    End Sub
End Class
