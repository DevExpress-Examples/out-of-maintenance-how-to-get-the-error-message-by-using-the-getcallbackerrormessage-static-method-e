using System;
using System.Web.UI;

public partial class _Default : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
            Exception innerException = new Exception("NoReport");
            throw new Exception("This message has been generated for a <b>GetCallbackErrorMessage()</b> method demonstration.", innerException);
        }
    }
}
