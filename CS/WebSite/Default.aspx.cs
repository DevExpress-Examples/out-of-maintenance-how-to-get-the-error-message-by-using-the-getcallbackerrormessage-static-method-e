using System;
using System.Web.UI;

public partial class _Default : Page {
    protected void Page_Load(object sender, EventArgs e) {
        if(IsCallback) {
			NotImplementedException innerException = new NotImplementedException("NoReport");
			throw new NotImplementedException("This message has been generated for a GetCallbackErrorMessage() method demonstration.", innerException);
        }
    }
}
