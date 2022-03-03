// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CyberThink
{
	[Register ("SpecificNote_ViewController")]
	partial class SpecificNote_ViewController
	{
		[Outlet]
		UIKit.UIView innerScrollView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint innerScrollViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint specifcNoteInformationLeftConstraint { get; set; }

		[Outlet]
		UIKit.UILabel specifcNoteTitle { get; set; }

		[Outlet]
		UIKit.UILabel specificNoteInformation { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (innerScrollView != null) {
				innerScrollView.Dispose ();
				innerScrollView = null;
			}

			if (innerScrollViewHeightConstraint != null) {
				innerScrollViewHeightConstraint.Dispose ();
				innerScrollViewHeightConstraint = null;
			}

			if (specifcNoteTitle != null) {
				specifcNoteTitle.Dispose ();
				specifcNoteTitle = null;
			}

			if (specificNoteInformation != null) {
				specificNoteInformation.Dispose ();
				specificNoteInformation = null;
			}

			if (specifcNoteInformationLeftConstraint != null) {
				specifcNoteInformationLeftConstraint.Dispose ();
				specifcNoteInformationLeftConstraint = null;
			}
		}
	}
}
