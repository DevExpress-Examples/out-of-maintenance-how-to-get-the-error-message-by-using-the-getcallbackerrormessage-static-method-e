# How to get the error message by using the GetCallbackErrorMessage static method


<p>In this example, the error message is displayed within the redirected page after the error occurs on callback. </p><p>The redirection page is specified within the devExpress/errors section of the web.config file by using the callbackErrorRedirectUrl key. The error message is obtained by using the ASPxWebControl.GetCallbackErrorMessage static method. To provide the message redirection between the pages, the ASPxHttpHandlerModule should be registered within the web.config file (for more information, see the <a href="https://www.devexpress.com/Support/Center/p/K18262">How to manually register a HttpHandler Module</a> article).</p>

<br/>


