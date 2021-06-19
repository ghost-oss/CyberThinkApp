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
	[Register ("Home_ViewController")]
	partial class Home_ViewController
	{
		[Outlet]
		UIKit.UILabel beginnerProgressTitle { get; set; }

		[Outlet]
		UIKit.UIProgressView beginnerProgressView { get; set; }

		[Outlet]
		UIKit.UIView ButtonsBackground { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint buttonsBackgroundHeightConstraint { get; set; }

		[Outlet]
		UIKit.UIImageView cyberThinksLogo { get; set; }

		[Outlet]
		UIKit.UIImageView homePageBackground { get; set; }

		[Outlet]
		UIKit.UIView innerViewForScroll { get; set; }

		[Outlet]
		UIKit.UIView ModuleCompletionBackground { get; set; }

		[Outlet]
		UIKit.UIView progressContainerView { get; set; }

		[Outlet]
		UIKit.UIButton quizButton { get; set; }

		[Outlet]
		UIKit.UIButton revisionButton { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint revisionButtonHeightConstraint { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint revisionButtonWidthConstraint { get; set; }

		[Outlet]
		UIKit.UITableView tableView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (beginnerProgressTitle != null) {
				beginnerProgressTitle.Dispose ();
				beginnerProgressTitle = null;
			}

			if (beginnerProgressView != null) {
				beginnerProgressView.Dispose ();
				beginnerProgressView = null;
			}

			if (ButtonsBackground != null) {
				ButtonsBackground.Dispose ();
				ButtonsBackground = null;
			}

			if (buttonsBackgroundHeightConstraint != null) {
				buttonsBackgroundHeightConstraint.Dispose ();
				buttonsBackgroundHeightConstraint = null;
			}

			if (cyberThinksLogo != null) {
				cyberThinksLogo.Dispose ();
				cyberThinksLogo = null;
			}

			if (homePageBackground != null) {
				homePageBackground.Dispose ();
				homePageBackground = null;
			}

			if (ModuleCompletionBackground != null) {
				ModuleCompletionBackground.Dispose ();
				ModuleCompletionBackground = null;
			}

			if (progressContainerView != null) {
				progressContainerView.Dispose ();
				progressContainerView = null;
			}

			if (quizButton != null) {
				quizButton.Dispose ();
				quizButton = null;
			}

			if (revisionButton != null) {
				revisionButton.Dispose ();
				revisionButton = null;
			}

			if (revisionButtonHeightConstraint != null) {
				revisionButtonHeightConstraint.Dispose ();
				revisionButtonHeightConstraint = null;
			}

			if (revisionButtonWidthConstraint != null) {
				revisionButtonWidthConstraint.Dispose ();
				revisionButtonWidthConstraint = null;
			}

			if (tableView != null) {
				tableView.Dispose ();
				tableView = null;
			}

			if (innerViewForScroll != null) {
				innerViewForScroll.Dispose ();
				innerViewForScroll = null;
			}
		}
	}
}
