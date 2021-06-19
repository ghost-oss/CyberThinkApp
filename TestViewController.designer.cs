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
	[Register ("TestViewController")]
	partial class TestViewController
	{
		[Outlet]
		UIKit.UIButton dropDownButton { get; set; }

		[Outlet]
		UIKit.UIButton secondDropDownButton { get; set; }

		[Outlet]
		UIKit.UITableView secondTableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint secondTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint tableViewHeightConstraint { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (dropDownButton != null) {
				dropDownButton.Dispose ();
				dropDownButton = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (tableViewHeightConstraint != null) {
				tableViewHeightConstraint.Dispose ();
				tableViewHeightConstraint = null;
			}

			if (secondDropDownButton != null) {
				secondDropDownButton.Dispose ();
				secondDropDownButton = null;
			}

			if (secondTableView != null) {
				secondTableView.Dispose ();
				secondTableView = null;
			}

			if (secondTableViewHeightConstraint != null) {
				secondTableViewHeightConstraint.Dispose ();
				secondTableViewHeightConstraint = null;
			}
		}
	}
}
