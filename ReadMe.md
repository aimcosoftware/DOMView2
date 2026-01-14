# DOMView2 Overview

DOMView2 is a wrapper around [Microsoft's WebView2 browser](https://github.com/MicrosoftEdge/WebView2Browser) that gives full synchronous access to the DOM and other objects in the browser.
#### Access DOM and other APIs synchronously from .Net.

```vb
'Strongly typed classes
Private WithEvents Btn As DVButton

'Insert dialog into the current page
Private Sub InsertDialog()
	Dim Dlg As DVDialog = DomView.document.createElement("dialog")
	Dlg.style.cssText = "box-shadow:5px 5px 10px grey;width:400px;border:1px solid silver;border-radius:10px;padding:10px"

	Dim Div As DVDiv = DomView.document.createElement("div")
	Div.style.cssText = "text-align:center;padding:20px"
	Div.innerText = "Dialog inserted from .Net"
	Dlg.insertAdjacentElement("afterBegin", Div)

	Btn = DomView.document.createElement("button")
	Btn.style.cssText = "border:1px solid silver;border-radius:5px;padding:10px 20px;float:right"
	Btn.innerText = "Close"
	Dlg.insertAdjacentElement("beforeEnd", Btn)

	DomView.document.body.insertAdjacentElement("beforeEnd", Dlg)
	Dlg.showModal()
End Sub

'Button click event
Private Sub Btn_AfterEvent(Sender As DVWindow, e As DVAfterEventArgs) Handles Btn.AfterEvent
	If e.type = "click" Then
		Dlg.close()
	End If
End Sub
```

### Debugging
As debugging pauses all threads, you can't make calls to WebView2 when stopped on a breakpoint, nor examine properties from Visual Studio. To debug calls to WebView2, assign calls to a variable before the breakpoint. e.g.

```vb
Dim iText = WebView.document.getElementById("element-id").innerText
' Break on this line to examine innerText
```

### Versioning
DOMView2 uses the same major version number as the version of Edge that it supports. Minor is used when an important fix or update is required to the major release. Build is the month and day of release, and private is incremented on each release.

### Distribution
For the evergreen distribution, all the files in the `DOMView2` folder need to be in your application folder and distributed with your application. For a fixed version distribution, you can specify the executuable folder in the `DOMView2.ExecutableFolder` property. [See here](https://learn.microsoft.com/en-us/microsoft-edge/webview2/concepts/distribution) for details of WebView2 distribution models.

### Environment
DOMView2 is built as an AnyCPU Winforms control. To use in a 32bit environment, rename `WebView2Loader 32.dll` to  `WebView2Loader.dll` and distribute that with your application.

### Licence
DOMView2 will display an unlicensed banner below the browser. To unlock DOMView2, **shift click** the banner, enter your app key and click **Create Licence**. This will create `DOMView2.licence` in the current app folder.

The default method to distribute your licence is include `DOMView2.licence` with your application. If you have more than one .exe using DOMView2 in your application folder, you can enter the licence token for each application into the `DOMView2.LicenceToken` property.

The licence will need to be recreated if you update DOMView2 or make any changes to the assembly details of your application.

**Your user key should be kept secure and not distributed with your application**.

### Other information
[Purchasing](https://domview2.aimcosoftware.co.uk/info#pricing), [Documentation](https://domview2.aimcosoftware.co.uk/docs)