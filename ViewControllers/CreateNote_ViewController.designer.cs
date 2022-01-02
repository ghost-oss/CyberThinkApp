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
	[Register ("CreateNote_ViewController")]
	partial class CreateNote_ViewController
	{
		[Outlet]
		UIKit.UIView createNoteBackgroundView { get; set; }

		[Outlet]
		UIKit.UIView innerScrollView { get; set; }

		[Outlet]
		UIKit.UILabel noteLabel { get; set; }

		[Outlet]
		UIKit.UITextView noteTextView { get; set; }

		[Outlet]
		UIKit.UILabel noteTitleLabel { get; set; }

		[Outlet]
		UIKit.UITextField noteTitleTextField { get; set; }

		[Outlet]
		UIKit.UIButton saveNoteButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (createNoteBackgroundView != null) {
				createNoteBackgroundView.Dispose ();
				createNoteBackgroundView = null;
			}

			if (noteLabel != null) {
				noteLabel.Dispose ();
				noteLabel = null;
			}

			if (noteTextView != null) {
				noteTextView.Dispose ();
				noteTextView = null;
			}

			if (noteTitleLabel != null) {
				noteTitleLabel.Dispose ();
				noteTitleLabel = null;
			}

			if (noteTitleTextField != null) {
				noteTitleTextField.Dispose ();
				noteTitleTextField = null;
			}

			if (saveNoteButton != null) {
				saveNoteButton.Dispose ();
				saveNoteButton = null;
			}

			if (innerScrollView != null) {
				innerScrollView.Dispose ();
				innerScrollView = null;
			}
		}
	}
}
