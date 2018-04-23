using System;
using System.Web.UI;
using DevExpress.Web.ASPxClasses;

public partial class Error : Page {
    protected void Page_Load(object sender, EventArgs e) {
        string errorMessage = ASPxWebControl.GetCallbackErrorMessage();
        Response.Output.Write(errorMessage);
    }
}
