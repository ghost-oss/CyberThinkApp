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
	[Register ("SpecificModule_ViewController")]
	partial class SpecificModule_ViewController
	{
		[Outlet]
		UIKit.UIView backgroundView { get; set; }

		[Outlet]
		UIKit.UILabel moduleInformation { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint moduleInformationHeightConstraint { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint moduleInformationTopConstraint { get; set; }

		[Outlet]
		UIKit.UILabel moduleTitle { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint specificImageHeight { get; set; }

		[Outlet]
		UIKit.UIImageView specificImageView { get; set; }

		[Outlet]
		UIKit.NSLayoutConstraint viewForScrollHeightConstraint { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (backgroundView != null) {
				backgroundView.Dispose ();
				backgroundView = null;
			}

			if (moduleInformation != null) {
				moduleInformation.Dispose ();
				moduleInformation = null;
			}

			if (moduleInformationHeightConstraint != null) {
				moduleInformationHeightConstraint.Dispose ();
				moduleInformationHeightConstraint = null;
			}

			if (moduleTitle != null) {
				moduleTitle.Dispose ();
				moduleTitle = null;
			}

			if (specificImageHeight != null) {
				specificImageHeight.Dispose ();
				specificImageHeight = null;
			}

			if (specificImageView != null) {
				specificImageView.Dispose ();
				specificImageView = null;
			}

			if (viewForScrollHeightConstraint != null) {
				viewForScrollHeightConstraint.Dispose ();
				viewForScrollHeightConstraint = null;
			}

			if (moduleInformationTopConstraint != null) {
				moduleInformationTopConstraint.Dispose ();
				moduleInformationTopConstraint = null;
			}
		}
	}
}
