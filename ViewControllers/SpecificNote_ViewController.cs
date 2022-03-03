using System;
using CoreGraphics;
using CyberThink.Model;
using Foundation;
using UIKit;

namespace CyberThink
{
	public partial class SpecificNote_ViewController : UIViewController
	{
		public SpecificNote_ViewController (IntPtr handle) : base (handle)
		{
		}

        private Note usernote;
        private bool isLandscape => UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeLeft || UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeRight;

        public SpecificNote_ViewController()
        {

        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.AdjustConstraintsForLandscape();

            this.View.BackgroundColor = UIColor.FromRGB(204, 229, 255);
            innerScrollView.BackgroundColor = UIColor.FromRGB(204, 229, 255);

            specifcNoteTitle.Text = usernote.noteTitle;
            specifcNoteTitle.TextAlignment = UITextAlignment.Center;
            specifcNoteTitle.Font = UIFont.BoldSystemFontOfSize(22);
            var attrString = new NSMutableAttributedString(specifcNoteTitle.Text);
            attrString.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), new NSRange(0, attrString.Length));
            specifcNoteTitle.AttributedText = attrString;

            specificNoteInformation.Lines = 0;
            specificNoteInformation.SizeToFit();
            specificNoteInformation.LineBreakMode = UILineBreakMode.WordWrap;
            specificNoteInformation.Text = usernote.note;
            specificNoteInformation.Font = UIFont.SystemFontOfSize(20, UIFontWeight.Regular);

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            this.AdjustScrollViewHeight();
        }

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            base.DidRotate(fromInterfaceOrientation);
            AdjustScrollViewHeight();
        }

        public void BindData(Note note)
        {
            usernote = note;
        }

        public override void ViewWillTransitionToSize(CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        {
            this.AdjustConstraintsForLandscape();
        }

        public void AdjustConstraintsForLandscape()
        {
            if (isLandscape)
            {
                specifcNoteInformationLeftConstraint.Constant = 40;
            }
            else
            {
                specifcNoteInformationLeftConstraint.Constant = 31;
            }
        }

        public void AdjustScrollViewHeight()
        {
            var specificNoteHeight = specificNoteInformation.Frame.Height;
            innerScrollViewHeightConstraint.Constant = specificNoteHeight + 120;
        }


    }
}
