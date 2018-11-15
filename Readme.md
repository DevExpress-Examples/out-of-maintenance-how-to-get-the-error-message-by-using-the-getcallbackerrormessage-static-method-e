<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
* [Error.aspx](./CS/WebSite/Error.aspx) (VB: [Error.aspx.vb](./VB/WebSite/Error.aspx.vb))
* [Error.aspx.cs](./CS/WebSite/Error.aspx.cs) (VB: [Error.aspx.vb](./VB/WebSite/Error.aspx.vb))
* [web.config](./CS/WebSite/web.config) (VB: [web.config](./VB/WebSite/web.config))
<!-- default file list end -->
# How to get the error message by using the GetCallbackErrorMessage static method


<p>In this example, the error message is displayed within the redirected page after the error occurs on callback. </p><p>The redirection page is specified within the devExpress/errors section of the web.config file by using the callbackErrorRedirectUrl key. The error message is obtained by using the ASPxWebControl.GetCallbackErrorMessage static method. To provide the message redirection between the pages, the ASPxHttpHandlerModule should be registered within the web.config file (for more information, see the <a href="https://www.devexpress.com/Support/Center/p/K18262">How to manually register a HttpHandler Module</a> article).</p>

<br/>


