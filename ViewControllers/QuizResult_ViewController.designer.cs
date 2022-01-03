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
	[Register ("QuizResult_ViewController")]
	partial class QuizResult_ViewController
	{
		[Outlet]
		UIKit.UIView innerScrollView { get; set; }

		[Outlet]
		UIKit.UIView quizResultBackgroundView { get; set; }

		[Outlet]
		UIKit.UIImageView quizResultImageView { get; set; }

		[Outlet]
		UIKit.UILabel quizResultLabel { get; set; }

		[Outlet]
		UIKit.UILabel quizResultPercentageLabel { get; set; }

		[Outlet]
		UIKit.UIButton quizResultReturnToHomeButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (innerScrollView != null) {
				innerScrollView.Dispose ();
				innerScrollView = null;
			}

			if (quizResultBackgroundView != null) {
				quizResultBackgroundView.Dispose ();
				quizResultBackgroundView = null;
			}

			if (quizResultImageView != null) {
				quizResultImageView.Dispose ();
				quizResultImageView = null;
			}

			if (quizResultLabel != null) {
				quizResultLabel.Dispose ();
				quizResultLabel = null;
			}

			if (quizResultPercentageLabel != null) {
				quizResultPercentageLabel.Dispose ();
				quizResultPercentageLabel = null;
			}

			if (quizResultReturnToHomeButton != null) {
				quizResultReturnToHomeButton.Dispose ();
				quizResultReturnToHomeButton = null;
			}
		}
	}
}
