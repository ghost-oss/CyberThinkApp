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
	[Register ("Modules_ViewController")]
	partial class Modules_ViewController
	{
		[Outlet]
		UIKit.UITableView begginerModulesTableView { get; set; }

		[Outlet]
		UIKit.UIButton beginnerModulesButton { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint beginnerModulesTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIButton IntermediaryModulesButton { get; set; }

		[Outlet]
		UIKit.UITableView IntermediaryModulesTableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint intermediaryTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIView modulesBackgroundView { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (begginerModulesTableView != null) {
				begginerModulesTableView.Dispose ();
				begginerModulesTableView = null;
			}

			if (beginnerModulesButton != null) {
				beginnerModulesButton.Dispose ();
				beginnerModulesButton = null;
			}

			if (beginnerModulesTableViewHeightConstraint != null) {
				beginnerModulesTableViewHeightConstraint.Dispose ();
				beginnerModulesTableViewHeightConstraint = null;
			}

			if (IntermediaryModulesButton != null) {
				IntermediaryModulesButton.Dispose ();
				IntermediaryModulesButton = null;
			}

			if (IntermediaryModulesTableView != null) {
				IntermediaryModulesTableView.Dispose ();
				IntermediaryModulesTableView = null;
			}

			if (intermediaryTableViewHeightConstraint != null) {
				intermediaryTableViewHeightConstraint.Dispose ();
				intermediaryTableViewHeightConstraint = null;
			}

			if (modulesBackgroundView != null) {
				modulesBackgroundView.Dispose ();
				modulesBackgroundView = null;
			}

			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
		}
	}
}
