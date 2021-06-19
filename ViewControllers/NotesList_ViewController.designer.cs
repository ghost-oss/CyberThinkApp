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
	[Register ("NotesList_ViewController")]
	partial class NotesList_ViewController
	{
		[Outlet]
		UIKit.UIImageView emptyNotesImageView { get; set; }

		[Outlet]
		UIKit.UILabel emptyNotesLabel { get; set; }

		[Outlet]
		UIKit.UIView emptyNotesView { get; set; }

		[Outlet]
		UIKit.UITableView notesTableView { get; set; }

		[Outlet]
		UIKit.UITableView testTableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (emptyNotesImageView != null) {
				emptyNotesImageView.Dispose ();
				emptyNotesImageView = null;
			}

			if (emptyNotesLabel != null) {
				emptyNotesLabel.Dispose ();
				emptyNotesLabel = null;
			}

			if (emptyNotesView != null) {
				emptyNotesView.Dispose ();
				emptyNotesView = null;
			}

			if (testTableView != null) {
				testTableView.Dispose ();
				testTableView = null;
			}

			if (notesTableView != null) {
				notesTableView.Dispose ();
				notesTableView = null;
			}
		}
	}
}
