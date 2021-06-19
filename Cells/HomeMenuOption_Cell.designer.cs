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
	[Register ("HomeMenuOption_Cell")]
	partial class HomeMenuOption_Cell
	{
		[Outlet]
		UIKit.UIView ModuleCompletionView { get; set; }

		[Outlet]
		UIKit.UILabel OptionTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (ModuleCompletionView != null) {
				ModuleCompletionView.Dispose ();
				ModuleCompletionView = null;
			}

			if (OptionTitle != null) {
				OptionTitle.Dispose ();
				OptionTitle = null;
			}
		}
	}
}
