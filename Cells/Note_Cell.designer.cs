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
	[Register ("Note_Cell")]
	partial class Note_Cell
	{
		[Outlet]
		UIKit.UIImageView noteFavoriteImage { get; set; }

		[Outlet]
		UIKit.UILabel noteShortDescriptionLabel { get; set; }

		[Outlet]
		UIKit.UIView noteSidePanelView { get; set; }

		[Outlet]
		UIKit.UILabel noteTitleLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (noteTitleLabel != null) {
				noteTitleLabel.Dispose ();
				noteTitleLabel = null;
			}

			if (noteShortDescriptionLabel != null) {
				noteShortDescriptionLabel.Dispose ();
				noteShortDescriptionLabel = null;
			}

			if (noteFavoriteImage != null) {
				noteFavoriteImage.Dispose ();
				noteFavoriteImage = null;
			}

			if (noteSidePanelView != null) {
				noteSidePanelView.Dispose ();
				noteSidePanelView = null;
			}
		}
	}
}
