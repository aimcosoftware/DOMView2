using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using DOMView2;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DOMView2_Example
{
	internal partial class TestFrm
	{

		private DVDiv Div;
		private DVDialog Dlg;
		private DVButton _Btn;

		private DVButton Btn
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			get
			{
				return _Btn;
			}

			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				if (_Btn != null)
				{
					_Btn.AfterEvent -= Btn_AfterEvent;
				}

				_Btn = value;
				if (_Btn != null)
				{
					_Btn.AfterEvent += Btn_AfterEvent;
				}
			}
		}

		public TestFrm()
		{
			InitializeComponent();
		}

		private void Btn_AfterEvent(DVWindow Sender, DVAfterEventArgs e)
		{
			if (e.type == "click")
			{
				Dlg.close();
			}
		}

		private void ClearCount()
		{
			var body = DomView.document.body;
			body.DeferElementLayout();
			foreach (var Elm in body.get_querySelectorAll("idx"))
				Elm.@remove();
			body.ApplyElementLayout();
		}

		private DateTime _DomView_AnimationFrame_LastTime = default;
		private int _DomView_AnimationFrame_Count = default;
		private double _DomView_AnimationFrame_MSec = default;

		private void DomView_AnimationFrame(DOMView sender, DateTime Timestamp)
		{
			_DomView_AnimationFrame_MSec += (Timestamp - _DomView_AnimationFrame_LastTime).TotalMilliseconds;
			_DomView_AnimationFrame_Count += 1;
			if (_DomView_AnimationFrame_Count == 30)
			{
				Div.innerText = $"{1000d / (_DomView_AnimationFrame_MSec / 30d):00.00}";
				_DomView_AnimationFrame_Count = 0;
				_DomView_AnimationFrame_MSec = 0d;
			}
			_DomView_AnimationFrame_LastTime = Timestamp;
			if (Conversions.ToBoolean(Dlg.clientWidth))
			{
				DomView.requestAnimationFrame();
			}
		}

		private void DomView_FaviconChanged(DOMView Sender, Image FavImage)
		{
			Icon = Helpers.ImageToIcon(DomView.FavIcon);
		}

		private void DomView_FrameNavigationStarting(DVWindow Sender)
		{
			Dlg = null;
		}

		private void DomView_NavigationCompleted(DOMView Sender)
		{
		}

		private void DomView_TitleChanged(DOMView Sender, string Title)
		{
			Text = Title;
		}

		private void MenuClearCount_Click(object sender, EventArgs e)
		{
			ClearCount();
		}

		private void MenuClearOutline_Click(object sender, EventArgs e)
		{
			OutlineAll(true, true);
		}

		private void MenuCountDivs_Click(object sender, EventArgs e)
		{
			ClearCount();
			string Tag = DomView.window.prompt("What elements do you want to count?", "div");
			int Idx = 0;
			foreach (var Elm in DomView.document.get_querySelectorAll(Tag))
			{
				Idx += 1;
				Elm.insertAdjacentHTML("beforeBegin", $"<idx style='position:absolute;padding:5px;background:yellow'>{Idx}</idx>");
			}
			DomView.window.alert($"There are {Idx} {Tag} elements on the page");
		}

		private void MenuInsertDialog_Click(object sender, EventArgs e)
		{
			Dlg = DomView.document.get_createElement("dialog").DVDialog();
			Dlg.style.cssText = "box-shadow:5px 5px 10px grey;width:400px;border:1px solid silver;border-radius:10px;padding:10px";

			Div = DomView.document.get_createElement("div").DVDiv();
			Div.style.cssText = "text-align:center;padding:20px";
			Div.innerText = "Dialog inserted from .Net";
			Dlg.insertAdjacentElement("afterBegin", Div);

			Btn = DomView.document.get_createElement("button").DVButton();
			Btn.style.cssText = "border:1px solid silver;border-radius:5px;padding:10px 20px;float:right";
			Btn.innerText = "Close";
			Dlg.insertAdjacentElement("beforeEnd", Btn);

			DomView.document.body.insertAdjacentElement("beforeEnd", Dlg);
			Dlg.showModal();
		}

		private void MenuOutlineWithout_Click(object sender, EventArgs e)
		{
			var TimeStart = DateTime.Now;
			DomView.window.alert($"Outlining {OutlineAll(false, false)} elements took {(int)Math.Round((DateTime.Now - TimeStart).TotalMilliseconds)}ms");
		}

		private void MenuShowFrameRate_Click(object sender, EventArgs e)
		{
			Dlg = (DVDialog)DomView.document.get_createElement("dialog");
			Dlg.style.cssText = "box-shadow:5px 5px 10px grey;width:400px;border:1px solid silver;border-radius:10px;padding:10px";

			Div = (DVDiv)DomView.document.get_createElement("div");
			Div.style.cssText = "text-align:center;padding:20px";
			Div.innerText = "00.00";
			Dlg.insertAdjacentElement("afterBegin", Div);

			Btn = (DVButton)DomView.document.get_createElement("button");
			Btn.style.cssText = "border:1px solid silver;border-radius:5px;padding:10px 20px;float:right";
			Btn.innerText = "Close";
			Dlg.insertAdjacentElement("beforeEnd", Btn);

			DomView.document.body.insertAdjacentElement("beforeEnd", Dlg);
			Dlg.showModal();
			DomView.requestAnimationFrame();
		}

		private void MenuShowInputValues_Click(object sender, EventArgs e)
		{
			ClearCount();
			int Idx = 0;
			string Lst = "";
			foreach (DVInput Elm in DomView.document.get_querySelectorAll("input"))
			{
				Idx += 1;
				Elm.insertAdjacentHTML("beforeBegin", $"<idx style='position:absolute;padding:5px;background:yellow'>{Idx}</idx>");
				Lst += $"{Idx}: {Elm.value}{Constants.vbNewLine}";
			}
			DomView.window.alert(Lst);
		}

		private void MenuShowOutline_Click(object sender, EventArgs e)
		{
			var TimeStart = DateTime.Now;
			DomView.window.alert($"Outlining {OutlineAll(true, false)} elements took {(int)Math.Round((DateTime.Now - TimeStart).TotalMilliseconds)}ms");
		}

		private int OutlineAll(bool Defer, bool Clear)
		{
			string Css = Clear ? "" : "1px dotted darkorange";
			if (Defer)
			{
				DomView.document.DeferLayout();
			}
			var All = DomView.document.get_querySelectorAll("*");
			foreach (var Item in All)
				Item.style.outline = Css;
			if (Defer)
			{
				DomView.document.ApplyLayout();
			}
			return All.length;
		}

		private void TestFrm_Load(object sender, EventArgs e)
		{
			AddBar.Browser = DomView;
			DomView.Navigate("google.com");
		}

	}
}