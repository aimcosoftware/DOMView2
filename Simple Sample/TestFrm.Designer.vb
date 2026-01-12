<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TestFrm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	'<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestFrm))
		Me.DomView = New DOMView2.DOMView()
		Me.AddBar = New DOMView2.DVAddressBar()
		Me.ButtonExamples = New System.Windows.Forms.ToolStripDropDownButton()
		Me.MenuCountDivs = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuClearCount = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
		Me.MenuOutlineWithout = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuOutlineWith = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuClearOutline = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.MenuInsertDialog = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
		Me.MenuShowInputValues = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuShowFrameRate = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
		Me.AddBar.SuspendLayout()
		Me.SuspendLayout()
		'
		'DomView
		'
		Me.DomView.AllowFetch = True
		Me.DomView.AllowFonts = True
		Me.DomView.AllowImages = True
		Me.DomView.AllowMedia = True
		Me.DomView.AllowScript = True
		Me.DomView.AllowStyles = True
		Me.DomView.AreDevToolsEnabled = True
		Me.DomView.AutoFillEditText = ""
		Me.DomView.AutoFillEnabled = True
		Me.DomView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DomView.IsGeneralAutofillEnabled = False
		Me.DomView.IsMuted = False
		Me.DomView.IsPasswordAutosaveEnabled = False
		Me.DomView.IsStatusBarEnabled = False
		Me.DomView.Location = New System.Drawing.Point(0, 40)
		Me.DomView.Name = "DomView"
		Me.DomView.ScriptDialogsEnabled = True
		Me.DomView.SearchUrl = "https://google.co.uk/search?q={0}"
		Me.DomView.Size = New System.Drawing.Size(844, 521)
		Me.DomView.TabIndex = 0
		Me.DomView.Text = "DomView1"
		Me.DomView.UserAgent = ""
		Me.DomView.ZoomFactor = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'AddBar
		'
		Me.AddBar.AddressEnabled = True
		Me.AddBar.AllowMerge = False
		Me.AddBar.AutoSize = False
		Me.AddBar.BackColor = System.Drawing.Color.WhiteSmoke
		Me.AddBar.Browser = Nothing
		Me.AddBar.CanOverflow = False
		Me.AddBar.GripMargin = New System.Windows.Forms.Padding(0)
		Me.AddBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
		Me.AddBar.ImageScalingSize = New System.Drawing.Size(24, 24)
		Me.AddBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButtonExamples, Me.ToolStripSeparator2})
		Me.AddBar.Location = New System.Drawing.Point(0, 0)
		Me.AddBar.Name = "AddBar"
		Me.AddBar.Padding = New System.Windows.Forms.Padding(4)
		Me.AddBar.ShowSearchSuggestions = True
		Me.AddBar.ShowVisitedSuggestions = True
		Me.AddBar.Size = New System.Drawing.Size(844, 40)
		Me.AddBar.TabIndex = 1
		'
		'ButtonExamples
		'
		Me.ButtonExamples.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
		Me.ButtonExamples.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCountDivs, Me.MenuClearCount, Me.ToolStripSeparator1, Me.MenuOutlineWithout, Me.MenuOutlineWith, Me.MenuClearOutline, Me.ToolStripSeparator3, Me.MenuInsertDialog, Me.ToolStripSeparator4, Me.MenuShowInputValues, Me.MenuShowFrameRate})
		Me.ButtonExamples.Image = CType(resources.GetObject("ButtonExamples.Image"), System.Drawing.Image)
		Me.ButtonExamples.ImageTransparentColor = System.Drawing.Color.Magenta
		Me.ButtonExamples.Margin = New System.Windows.Forms.Padding(0, 0, 5, 0)
		Me.ButtonExamples.Name = "ButtonExamples"
		Me.ButtonExamples.Size = New System.Drawing.Size(37, 32)
		Me.ButtonExamples.Text = "Sample actions"
		'
		'MenuCountDivs
		'
		Me.MenuCountDivs.BackColor = System.Drawing.Color.White
		Me.MenuCountDivs.Name = "MenuCountDivs"
		Me.MenuCountDivs.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuCountDivs.Size = New System.Drawing.Size(187, 30)
		Me.MenuCountDivs.Text = "Count elements"
		'
		'MenuClearCount
		'
		Me.MenuClearCount.BackColor = System.Drawing.Color.White
		Me.MenuClearCount.Name = "MenuClearCount"
		Me.MenuClearCount.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuClearCount.Size = New System.Drawing.Size(187, 30)
		Me.MenuClearCount.Text = "Clear count"
		'
		'ToolStripSeparator1
		'
		Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
		Me.ToolStripSeparator1.Size = New System.Drawing.Size(184, 6)
		'
		'MenuOutlineWithout
		'
		Me.MenuOutlineWithout.BackColor = System.Drawing.Color.White
		Me.MenuOutlineWithout.Name = "MenuOutlineWithout"
		Me.MenuOutlineWithout.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuOutlineWithout.Size = New System.Drawing.Size(187, 30)
		Me.MenuOutlineWithout.Text = "Outline without defer"
		'
		'MenuOutlineWith
		'
		Me.MenuOutlineWith.BackColor = System.Drawing.Color.White
		Me.MenuOutlineWith.Name = "MenuOutlineWith"
		Me.MenuOutlineWith.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuOutlineWith.Size = New System.Drawing.Size(187, 30)
		Me.MenuOutlineWith.Text = "Outline with defer"
		'
		'MenuClearOutline
		'
		Me.MenuClearOutline.BackColor = System.Drawing.Color.White
		Me.MenuClearOutline.Name = "MenuClearOutline"
		Me.MenuClearOutline.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuClearOutline.Size = New System.Drawing.Size(187, 30)
		Me.MenuClearOutline.Text = "Clear outline"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(184, 6)
		'
		'MenuInsertDialog
		'
		Me.MenuInsertDialog.BackColor = System.Drawing.Color.White
		Me.MenuInsertDialog.Name = "MenuInsertDialog"
		Me.MenuInsertDialog.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuInsertDialog.Size = New System.Drawing.Size(187, 30)
		Me.MenuInsertDialog.Text = "Insert dialog"
		'
		'ToolStripSeparator4
		'
		Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
		Me.ToolStripSeparator4.Size = New System.Drawing.Size(184, 6)
		'
		'MenuShowInputValues
		'
		Me.MenuShowInputValues.BackColor = System.Drawing.Color.White
		Me.MenuShowInputValues.Name = "MenuShowInputValues"
		Me.MenuShowInputValues.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuShowInputValues.Size = New System.Drawing.Size(187, 30)
		Me.MenuShowInputValues.Text = "Show input values"
		'
		'MenuShowFrameRate
		'
		Me.MenuShowFrameRate.BackColor = System.Drawing.Color.White
		Me.MenuShowFrameRate.Name = "MenuShowFrameRate"
		Me.MenuShowFrameRate.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
		Me.MenuShowFrameRate.Size = New System.Drawing.Size(187, 30)
		Me.MenuShowFrameRate.Text = "Show frame rate"
		'
		'ToolStripSeparator2
		'
		Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
		Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 32)
		'
		'TestFrm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(844, 561)
		Me.Controls.Add(Me.DomView)
		Me.Controls.Add(Me.AddBar)
		Me.Name = "TestFrm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Simple Test Form"
		Me.AddBar.ResumeLayout(False)
		Me.AddBar.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DomView As DOMView2.DOMView
	Friend WithEvents AddBar As DOMView2.DVAddressBar
	Friend WithEvents ButtonExamples As ToolStripDropDownButton
	Friend WithEvents MenuCountDivs As ToolStripMenuItem
	Friend WithEvents MenuOutlineWith As ToolStripMenuItem
	Friend WithEvents MenuOutlineWithout As ToolStripMenuItem
	Friend WithEvents MenuClearOutline As ToolStripMenuItem
	Friend WithEvents MenuClearCount As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
	Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
	Friend WithEvents MenuShowInputValues As ToolStripMenuItem
	Friend WithEvents MenuShowFrameRate As ToolStripMenuItem
	Friend WithEvents MenuInsertDialog As ToolStripMenuItem
	Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
End Class
