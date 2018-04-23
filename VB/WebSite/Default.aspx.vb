Imports Microsoft.VisualBasic
Imports System
Imports System.Web.UI

Public Partial Class _Default
	Inherits Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If IsCallback Then
                                            Dim innerException As Exception = New Exception("NoReport")
                                            Throw New Exception("This message has been generated for a <b>GetCallbackErrorMessage()</b> method demonstration.", innerException)
		End If
	End Sub
End Class
