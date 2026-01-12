using System;
using System.ComponentModel;
using System.Diagnostics;

namespace DOMView2_Example.My
{
	internal static partial class MyProject
	{
		internal partial class MyForms
		{

			[EditorBrowsable(EditorBrowsableState.Never)]
			public TestFrm m_TestFrm;

			public TestFrm TestFrm
			{
				[DebuggerHidden]
				get
				{
					m_TestFrm = Create__Instance__(m_TestFrm);
					return m_TestFrm;
				}
				[DebuggerHidden]
				set
				{
					if (ReferenceEquals(value, m_TestFrm))
						return;
					if (value is not null)
						throw new ArgumentException("Property can only be set to Nothing");
					Dispose__Instance__(ref m_TestFrm);
				}
			}

		}


	}
}