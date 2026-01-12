# DOMView2 Overview

DOMView2 is a wrapper around [Microsoft's WebView2 browser](https://github.com/MicrosoftEdge/WebView2Browser) that gives full synchronous access to the DOM and other objects in the browser.

### Versioning
DOMView2 uses the same major version number as the version of Edge that it supports. Minor is used when an important fix or update is required to the major release. Build is the month and day of release, and private is incremented on each release.

### Debugging
As debugging pauses all threads, you can't make calls to WebView2 when stopped on a breakpoint, nor examine properties from Visual Studio. To debug calls to WebView2, assign calls to a variable before the breakpoint. e.g.

```vb
Dim iText = WebView.document.getElementById("element-id").innerText
' Break on this line to examine innerText
```

### Distribution
For the evergreen distribution, all the files in the `DOMView2` folder need to be in your application folder and distributed with your application. For a fixed version distribution, you can specify the executuable folder in the `DOMView2.ExecutableFolder` property. [See here](https://learn.microsoft.com/en-us/microsoft-edge/webview2/concepts/distribution) for details of WebView2 distribution models.

### Environment
DOMView2 is built as an AnyCPU Winforms control. To use in a 32bit environment, rename `WebView2Loader 32.dll` to  `WebView2Loader.dll` and distribute that with your application.

### Licence
DOMView2 will display an unlicensed banner below the browser. To unlock DOMView2, **shift click** the banner, enter your app key and click **Create Licence**. This will create `DOMView2.licence` in the current app folder.

The default method to distribute your licence is include `DOMView2.licence` with your application. If you have more than one .exe using DOMView2 in your application folder, you can enter the licence token for each application into the `DOMView2.LicenceToken` property.

The licence will need to be recreated if you update DOMView2 or make any changes to the assembly details of your application.

**Your user key should be kept secure and not distributed with your application**.