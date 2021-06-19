// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CyberThink.Cells
{
	[Register ("Answer_Cell")]
	partial class Answer_Cell
	{
		[Outlet]
		UIKit.UILabel answerLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (answerLabel != null) {
				answerLabel.Dispose ();
				answerLabel = null;
			}
		}
	}
}
