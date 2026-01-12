Friend Class TestFrm

	Private Div As DVDiv
	Private Dlg As DVDialog
	Private WithEvents Btn As DVButton

	Private Sub Btn_AfterEvent(Sender As DVWindow, e As DVAfterEventArgs) Handles Btn.AfterEvent
		If e.type = "click" Then
			Dlg.close()
		End If
	End Sub

	Private Sub ClearCount()
		Dim body = DomView.document.body
		body.DeferElementLayout()
		For Each Elm In body.querySelectorAll("idx")
			Elm.remove()
		Next
		body.ApplyElementLayout()
	End Sub

	Private Sub DomView_AnimationFrame(sender As DOMView, Timestamp As Date) Handles DomView.AnimationFrame
		Static LastTime As Date, Count As Integer, MSec As Double
		MSec += (Timestamp - LastTime).TotalMilliseconds
		Count += 1
		If Count = 30 Then
			Div.innerText = $"{1000 / (MSec / 30):00.00}"
			Count = 0
			MSec = 0
		End If
		LastTime = Timestamp
		If Dlg.clientWidth Then
			DomView.requestAnimationFrame()
		End If
	End Sub

	Private Sub DomView_FaviconChanged(Sender As DOMView, FavImage As Image) Handles DomView.FaviconChanged
		Icon = ImageToIcon(DomView.FavIcon)
	End Sub

	Private Sub DomView_FrameNavigationStarting(Sender As DVWindow) Handles DomView.FrameNavigationStarting
		Dlg = Nothing
	End Sub

	Private Sub DomView_NavigationCompleted(Sender As DOMView) Handles DomView.NavigationCompleted
	End Sub

	Private Sub DomView_TitleChanged(Sender As DOMView, Title As String) Handles DomView.TitleChanged
		Text = Title
	End Sub

	Private Sub MenuClearCount_Click(sender As Object, e As EventArgs) Handles MenuClearCount.Click
		ClearCount()
	End Sub

	Private Sub MenuClearOutline_Click(sender As Object, e As EventArgs) Handles MenuClearOutline.Click
		OutlineAll(True, True)
	End Sub

	Private Sub MenuCountDivs_Click(sender As Object, e As EventArgs) Handles MenuCountDivs.Click
		ClearCount()
		Dim Tag = DomView.window.prompt("What elements do you want to count?", "div")
		Dim Idx = 0
		For Each Elm In DomView.document.querySelectorAll(Tag)
			Idx += 1
			Elm.insertAdjacentHTML("beforeBegin", $"<idx style='position:absolute;padding:5px;background:yellow'>{Idx}</idx>")
		Next
		DomView.window.alert($"There are {Idx} {Tag} elements on the page")
	End Sub

	Private Sub MenuInsertDialog_Click(sender As Object, e As EventArgs) Handles MenuInsertDialog.Click
		Dlg = DomView.document.createElement("dialog").DVDialog
		Dlg.style.cssText = "box-shadow:5px 5px 10px grey;width:400px;border:1px solid silver;border-radius:10px;padding:10px"

		Div = DomView.document.createElement("div").DVDiv
		Div.style.cssText = "text-align:center;padding:20px"
		Div.innerText = "Dialog inserted from .Net"
		Dlg.insertAdjacentElement("afterBegin", Div)

		Btn = DomView.document.createElement("button").DVButton
		Btn.style.cssText = "border:1px solid silver;border-radius:5px;padding:10px 20px;float:right"
		Btn.innerText = "Close"
		Dlg.insertAdjacentElement("beforeEnd", Btn)

		DomView.document.body.insertAdjacentElement("beforeEnd", Dlg)
		Dlg.showModal()
	End Sub

	Private Sub MenuOutlineWithout_Click(sender As Object, e As EventArgs) Handles MenuOutlineWithout.Click
		Dim TimeStart = Now()
		DomView.window.alert($"Outlining {OutlineAll(False, False)} elements took {CInt((Now - TimeStart).TotalMilliseconds)}ms")
	End Sub

	Private Sub MenuShowFrameRate_Click(sender As Object, e As EventArgs) Handles MenuShowFrameRate.Click
		Dlg = DomView.document.createElement("dialog")
		Dlg.style.cssText = "box-shadow:5px 5px 10px grey;width:400px;border:1px solid silver;border-radius:10px;padding:10px"

		Div = DomView.document.createElement("div")
		Div.style.cssText = "text-align:center;padding:20px"
		Div.innerText = "00.00"
		Dlg.insertAdjacentElement("afterBegin", Div)

		Btn = DomView.document.createElement("button")
		Btn.style.cssText = "border:1px solid silver;border-radius:5px;padding:10px 20px;float:right"
		Btn.innerText = "Close"
		Dlg.insertAdjacentElement("beforeEnd", Btn)

		DomView.document.body.insertAdjacentElement("beforeEnd", Dlg)
		Dlg.showModal()
		DomView.requestAnimationFrame()
	End Sub

	Private Sub MenuShowInputValues_Click(sender As Object, e As EventArgs) Handles MenuShowInputValues.Click
		ClearCount()
		Dim Idx = 0
		Dim Lst = ""
		For Each Elm As DVInput In DomView.document.querySelectorAll("input")
			Idx += 1
			Elm.insertAdjacentHTML("beforeBegin", $"<idx style='position:absolute;padding:5px;background:yellow'>{Idx}</idx>")
			Lst &= $"{Idx}: {Elm.value}{vbNewLine}"
		Next
		DomView.window.alert(Lst)
	End Sub

	Private Sub MenuShowOutline_Click(sender As Object, e As EventArgs) Handles MenuOutlineWith.Click
		Dim TimeStart = Now()
		DomView.window.alert($"Outlining {OutlineAll(True, False)} elements took {CInt((Now - TimeStart).TotalMilliseconds)}ms")
	End Sub

	Private Function OutlineAll(Defer As Boolean, Clear As Boolean) As Integer
		Dim Css = If(Clear, "", "1px dotted darkorange")
		If Defer Then
			DomView.document.DeferLayout()
		End If
		Dim All = DomView.document.querySelectorAll("*")
		For Each Item In All
			Item.style.outline = Css
		Next
		If Defer Then
			DomView.document.ApplyLayout()
		End If
		Return All.length
	End Function

	Private Sub TestFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		AddBar.Browser = DomView
		DomView.Navigate("google.com")
	End Sub

End Class

