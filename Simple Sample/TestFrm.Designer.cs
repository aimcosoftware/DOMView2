using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using DOMView2;

namespace DOMView2_Example
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	internal partial class TestFrm : Form
	{

		// Form overrides dispose to clean up the component list.
		[DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components is not null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Required by the Windows Form Designer
		private System.ComponentModel.IContainer components;

		// NOTE: The following procedure is required by the Windows Form Designer
		// It can be modified using the Windows Form Designer.  
		// Do not modify it using the code editor.
		// <System.Diagnostics.DebuggerStepThrough()>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			var resources = new System.ComponentModel.ComponentResourceManager(typeof(TestFrm));
			DomView = new DOMView();
			DomView.AnimationFrame += new DOMView.AnimationFrameEventHandler(DomView_AnimationFrame);
			DomView.FaviconChanged += new DOMView.FaviconChangedEventHandler(DomView_FaviconChanged);
			DomView.FrameNavigationStarting += new DOMView.FrameNavigationStartingEventHandler(DomView_FrameNavigationStarting);
			DomView.NavigationCompleted += new DOMView.NavigationCompletedEventHandler(DomView_NavigationCompleted);
			DomView.TitleChanged += new DOMView.TitleChangedEventHandler(DomView_TitleChanged);
			AddBar = new DVAddressBar();
			ButtonExamples = new ToolStripDropDownButton();
			MenuCountDivs = new ToolStripMenuItem();
			MenuCountDivs.Click += new EventHandler(MenuCountDivs_Click);
			MenuClearCount = new ToolStripMenuItem();
			MenuClearCount.Click += new EventHandler(MenuClearCount_Click);
			ToolStripSeparator1 = new ToolStripSeparator();
			MenuOutlineWithout = new ToolStripMenuItem();
			MenuOutlineWithout.Click += new EventHandler(MenuOutlineWithout_Click);
			MenuOutlineWith = new ToolStripMenuItem();
			MenuOutlineWith.Click += new EventHandler(MenuShowOutline_Click);
			MenuClearOutline = new ToolStripMenuItem();
			MenuClearOutline.Click += new EventHandler(MenuClearOutline_Click);
			ToolStripSeparator3 = new ToolStripSeparator();
			MenuInsertDialog = new ToolStripMenuItem();
			MenuInsertDialog.Click += new EventHandler(MenuInsertDialog_Click);
			ToolStripSeparator4 = new ToolStripSeparator();
			MenuShowInputValues = new ToolStripMenuItem();
			MenuShowInputValues.Click += new EventHandler(MenuShowInputValues_Click);
			MenuShowFrameRate = new ToolStripMenuItem();
			MenuShowFrameRate.Click += new EventHandler(MenuShowFrameRate_Click);
			ToolStripSeparator2 = new ToolStripSeparator();
			AddBar.SuspendLayout();
			SuspendLayout();
			// 
			// DomView
			// 
			DomView.AllowFetch = true;
			DomView.AllowFonts = true;
			DomView.AllowImages = true;
			DomView.AllowMedia = true;
			DomView.AllowScript = true;
			DomView.AllowStyles = true;
			DomView.AreDevToolsEnabled = true;
			DomView.AutoFillEditText = "";
			DomView.AutoFillEnabled = true;
			DomView.Dock = DockStyle.Fill;
			DomView.IsGeneralAutofillEnabled = false;
			DomView.IsMuted = false;
			DomView.IsPasswordAutosaveEnabled = false;
			DomView.IsStatusBarEnabled = false;
			DomView.Location = new Point(0, 40);
			DomView.Name = "DomView";
			DomView.ScriptDialogsEnabled = true;
			DomView.SearchUrl = "https://google.co.uk/search?q={0}";
			DomView.Size = new Size(844, 521);
			DomView.TabIndex = 0;
			DomView.Text = "DomView1";
			DomView.UserAgent = "";
			DomView.ZoomFactor = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// AddBar
			// 
			AddBar.AddressEnabled = true;
			AddBar.AllowMerge = false;
			AddBar.AutoSize = false;
			AddBar.BackColor = Color.WhiteSmoke;
			AddBar.Browser = null;
			AddBar.CanOverflow = false;
			AddBar.GripMargin = new Padding(0);
			AddBar.GripStyle = ToolStripGripStyle.Hidden;
			AddBar.ImageScalingSize = new Size(24, 24);
			AddBar.Items.AddRange(new ToolStripItem[] { ButtonExamples, ToolStripSeparator2 });
			AddBar.Location = new Point(0, 0);
			AddBar.Name = "AddBar";
			AddBar.Padding = new Padding(4);
			AddBar.ShowSearchSuggestions = true;
			AddBar.ShowVisitedSuggestions = true;
			AddBar.Size = new Size(844, 40);
			AddBar.TabIndex = 1;
			// 
			// ButtonExamples
			// 
			ButtonExamples.DisplayStyle = ToolStripItemDisplayStyle.Image;
			ButtonExamples.DropDownItems.AddRange(new ToolStripItem[] { MenuCountDivs, MenuClearCount, ToolStripSeparator1, MenuOutlineWithout, MenuOutlineWith, MenuClearOutline, ToolStripSeparator3, MenuInsertDialog, ToolStripSeparator4, MenuShowInputValues, MenuShowFrameRate });
			ButtonExamples.Image = (Image)resources.GetObject("ButtonExamples.Image");
			ButtonExamples.ImageTransparentColor = Color.Magenta;
			ButtonExamples.Margin = new Padding(0, 0, 5, 0);
			ButtonExamples.Name = "ButtonExamples";
			ButtonExamples.Size = new Size(37, 32);
			ButtonExamples.Text = "Sample actions";
			// 
			// MenuCountDivs
			// 
			MenuCountDivs.BackColor = Color.White;
			MenuCountDivs.Name = "MenuCountDivs";
			MenuCountDivs.Padding = new Padding(0, 5, 0, 5);
			MenuCountDivs.Size = new Size(187, 30);
			MenuCountDivs.Text = "Count elements";
			// 
			// MenuClearCount
			// 
			MenuClearCount.BackColor = Color.White;
			MenuClearCount.Name = "MenuClearCount";
			MenuClearCount.Padding = new Padding(0, 5, 0, 5);
			MenuClearCount.Size = new Size(187, 30);
			MenuClearCount.Text = "Clear count";
			// 
			// ToolStripSeparator1
			// 
			ToolStripSeparator1.Name = "ToolStripSeparator1";
			ToolStripSeparator1.Size = new Size(184, 6);
			// 
			// MenuOutlineWithout
			// 
			MenuOutlineWithout.BackColor = Color.White;
			MenuOutlineWithout.Name = "MenuOutlineWithout";
			MenuOutlineWithout.Padding = new Padding(0, 5, 0, 5);
			MenuOutlineWithout.Size = new Size(187, 30);
			MenuOutlineWithout.Text = "Outline without defer";
			// 
			// MenuOutlineWith
			// 
			MenuOutlineWith.BackColor = Color.White;
			MenuOutlineWith.Name = "MenuOutlineWith";
			MenuOutlineWith.Padding = new Padding(0, 5, 0, 5);
			MenuOutlineWith.Size = new Size(187, 30);
			MenuOutlineWith.Text = "Outline with defer";
			// 
			// MenuClearOutline
			// 
			MenuClearOutline.BackColor = Color.White;
			MenuClearOutline.Name = "MenuClearOutline";
			MenuClearOutline.Padding = new Padding(0, 5, 0, 5);
			MenuClearOutline.Size = new Size(187, 30);
			MenuClearOutline.Text = "Clear outline";
			// 
			// ToolStripSeparator3
			// 
			ToolStripSeparator3.Name = "ToolStripSeparator3";
			ToolStripSeparator3.Size = new Size(184, 6);
			// 
			// MenuInsertDialog
			// 
			MenuInsertDialog.BackColor = Color.White;
			MenuInsertDialog.Name = "MenuInsertDialog";
			MenuInsertDialog.Padding = new Padding(0, 5, 0, 5);
			MenuInsertDialog.Size = new Size(187, 30);
			MenuInsertDialog.Text = "Insert dialog";
			// 
			// ToolStripSeparator4
			// 
			ToolStripSeparator4.Name = "ToolStripSeparator4";
			ToolStripSeparator4.Size = new Size(184, 6);
			// 
			// MenuShowInputValues
			// 
			MenuShowInputValues.BackColor = Color.White;
			MenuShowInputValues.Name = "MenuShowInputValues";
			MenuShowInputValues.Padding = new Padding(0, 5, 0, 5);
			MenuShowInputValues.Size = new Size(187, 30);
			MenuShowInputValues.Text = "Show input values";
			// 
			// MenuShowFrameRate
			// 
			MenuShowFrameRate.BackColor = Color.White;
			MenuShowFrameRate.Name = "MenuShowFrameRate";
			MenuShowFrameRate.Padding = new Padding(0, 5, 0, 5);
			MenuShowFrameRate.Size = new Size(187, 30);
			MenuShowFrameRate.Text = "Show frame rate";
			// 
			// ToolStripSeparator2
			// 
			ToolStripSeparator2.Name = "ToolStripSeparator2";
			ToolStripSeparator2.Size = new Size(6, 32);
			// 
			// TestFrm
			// 
			AutoScaleDimensions = new SizeF(6.0f, 13.0f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(844, 561);
			Controls.Add(DomView);
			Controls.Add(AddBar);
			Name = "TestFrm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Simple Test Form";
			AddBar.ResumeLayout(false);
			AddBar.PerformLayout();
			Load += new EventHandler(TestFrm_Load);
			ResumeLayout(false);

		}

		internal DOMView DomView;
		internal DVAddressBar AddBar;
		internal ToolStripDropDownButton ButtonExamples;
		internal ToolStripMenuItem MenuCountDivs;
		internal ToolStripMenuItem MenuOutlineWith;
		internal ToolStripMenuItem MenuOutlineWithout;
		internal ToolStripMenuItem MenuClearOutline;
		internal ToolStripMenuItem MenuClearCount;
		internal ToolStripSeparator ToolStripSeparator1;
		internal ToolStripSeparator ToolStripSeparator2;
		internal ToolStripSeparator ToolStripSeparator3;
		internal ToolStripMenuItem MenuShowInputValues;
		internal ToolStripMenuItem MenuShowFrameRate;
		internal ToolStripMenuItem MenuInsertDialog;
		internal ToolStripSeparator ToolStripSeparator4;
	}
}