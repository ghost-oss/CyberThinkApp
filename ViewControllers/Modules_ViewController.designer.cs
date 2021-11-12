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
		UIKit.UIView modulesBackgroundView { get; set; }

		[Outlet]
		UIKit.UIButton passwordModulesButton { get; set; }

		[Outlet]
		UIKit.UITableView passwordModulesTableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint passwordModulesTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIButton phishingModulesButton { get; set; }

		[Outlet]
		UIKit.UITableView phishingModulesTableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint phishingModulesTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIButton physicalModulesButton { get; set; }

		[Outlet]
		UIKit.UITableView physicalModulesTableView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint physicalModulesTableViewHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIScrollView scrollView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (modulesBackgroundView != null) {
				modulesBackgroundView.Dispose ();
				modulesBackgroundView = null;
			}

			if (passwordModulesButton != null) {
				passwordModulesButton.Dispose ();
				passwordModulesButton = null;
			}

			if (passwordModulesTableView != null) {
				passwordModulesTableView.Dispose ();
				passwordModulesTableView = null;
			}

			if (passwordModulesTableViewHeightConstraint != null) {
				passwordModulesTableViewHeightConstraint.Dispose ();
				passwordModulesTableViewHeightConstraint = null;
			}

			if (phishingModulesButton != null) {
				phishingModulesButton.Dispose ();
				phishingModulesButton = null;
			}

			if (phishingModulesTableView != null) {
				phishingModulesTableView.Dispose ();
				phishingModulesTableView = null;
			}

			if (phishingModulesTableViewHeightConstraint != null) {
				phishingModulesTableViewHeightConstraint.Dispose ();
				phishingModulesTableViewHeightConstraint = null;
			}

			if (physicalModulesButton != null) {
				physicalModulesButton.Dispose ();
				physicalModulesButton = null;
			}

			if (physicalModulesTableView != null) {
				physicalModulesTableView.Dispose ();
				physicalModulesTableView = null;
			}

			if (physicalModulesTableViewHeightConstraint != null) {
				physicalModulesTableViewHeightConstraint.Dispose ();
				physicalModulesTableViewHeightConstraint = null;
			}

			if (scrollView != null) {
				scrollView.Dispose ();
				scrollView = null;
			}
		}
	}
}
