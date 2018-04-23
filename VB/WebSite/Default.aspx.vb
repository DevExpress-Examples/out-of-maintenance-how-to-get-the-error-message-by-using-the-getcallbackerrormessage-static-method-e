Imports System
Imports System.Web.UI

Partial Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        If IsCallback Then
            Dim innerException As New NotImplementedException("NoReport")
            Throw New NotImplementedException("This message has been generated for a GetCallbackErrorMessage() method demonstration.", innerException)
        End If
    End Sub
End Class
