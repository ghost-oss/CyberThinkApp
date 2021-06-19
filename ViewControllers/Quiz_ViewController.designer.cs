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
	[Register ("Quiz_ViewController")]
	partial class Quiz_ViewController
	{
		[Outlet]
		UIKit.UITableView answerTable { get; set; }

		[Outlet]
		UIKit.UILabel question { get; set; }

		[Outlet]
		UIKit.UIProgressView questionProgressBar { get; set; }

		[Outlet]
		UIKit.UILabel questionProgressTitle { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (questionProgressTitle != null) {
				questionProgressTitle.Dispose ();
				questionProgressTitle = null;
			}

			if (questionProgressBar != null) {
				questionProgressBar.Dispose ();
				questionProgressBar = null;
			}

			if (question != null) {
				question.Dispose ();
				question = null;
			}

			if (answerTable != null) {
				answerTable.Dispose ();
				answerTable = null;
			}
		}
	}
}
