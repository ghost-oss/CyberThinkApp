using System;
using CoreGraphics;
using Foundation;
using CyberThink.Cells;
using CyberThink.Model;
using CyberThink.ViewModel;
using UIKit;
using ObjCRuntime;
using System.Collections.Generic;
using CyberThink.Helpers;
using Akavache;
using System.Reactive.Linq;
using CyberThink.DatabaseConnection;

namespace CyberThink
{
	public partial class Home_ViewController : UIViewController ,IUITabBarDelegate
	{
		public Home_ViewController (IntPtr handle) : base (handle)
		{
		}

        private Home_ViewModel home_ViewModel;
        private bool isLandscape => UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeLeft || UIApplication.SharedApplication.StatusBarOrientation == UIInterfaceOrientation.LandscapeRight;


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpButtonUI();
            this.SetUpTitlesUI();
            this.SetBackgrounds();
            this.SetUpEventHandlers();
            this.SetNavBarTransparency();

            this.View.BackgroundColor = UIColor.FromRGB(0,76,153);
            this.innerViewForScroll.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            home_ViewModel = new Home_ViewModel();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            home_ViewModel.RetrieveUpdatedModules();
            this.InitiateProgressBars();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.SetUpButtonUI();
            this.AdjustConstraintsForLandscape();
            passwordProgressView.Transform = CGAffineTransform.MakeScale(1, 5);
            phishingProgressView.Transform = CGAffineTransform.MakeScale(1, 5);
            physicalProgressView.Transform = CGAffineTransform.MakeScale(1, 5);

        }

        public void SetNavBarTransparency()
        {
            var value = new UIImage();
            NavigationController.NavigationBar.SetBackgroundImage(value, UIBarMetrics.Default);
            NavigationController.NavigationBar.ShadowImage = value;
            NavigationController.NavigationBar.Translucent = true;

        }

        public void SetBackgrounds()
        {
            UserInterface.BackgroundDesigner(ButtonsBackground);
            UserInterface.BackgroundDesigner(progressContainerView);
        }

        private void SetUpButtonUI()
        {
            UserInterface.ButtonDesigner(revisionButton, true);
            UserInterface.ButtonFontDesigner(revisionButton);
            revisionButton.SetTitle("Modules", UIControlState.Normal);
            revisionButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            revisionButton.TranslatesAutoresizingMaskIntoConstraints = false;
            revisionButton.Transform = CGAffineTransform.MakeIdentity(); //Sets the button back to normal size when moving to and from VC's


            UserInterface.ButtonDesigner(quizButton,true);
            UserInterface.ButtonFontDesigner(quizButton);
            quizButton.SetTitle("Assessment", UIControlState.Normal);
            quizButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            quizButton.TranslatesAutoresizingMaskIntoConstraints = false;
            quizButton.Transform = CGAffineTransform.MakeIdentity();
        }

        public void SetUpEventHandlers()
        {
            revisionButton.TouchUpInside += RevisionBtnClicked;
            revisionButton.TouchDown += RevisionBtnTouchDown;
            revisionButton.TouchDragOutside += RevisionBtnTouchCancel;

            quizButton.TouchUpInside += QuizBtnClicked;
            quizButton.TouchDown += QuizBtnTouchDown;
            quizButton.TouchDragOutside += QuizBtnTouchCancel;
        }

        private void SetUpTitlesUI()
        {
            phishingProgressTitle.Text = "Phishing Modules Progess";
            UserInterface.LabelDesigner(phishingProgressTitle, 18);

            passwordProgressTitle.Text = "Password Modules Progess";
            UserInterface.LabelDesigner(passwordProgressTitle, 18);

            physicalProgressTitle.Text = "Physical Modules Progess";
            UserInterface.LabelDesigner(physicalProgressTitle, 18);
        }

        public void InitiateProgressBars()
        {

            float phishingProgressValue = home_ViewModel.ReturnModuleTotalCompletionValue(home_ViewModel.phishingModules) / 100; //We divide by 100 again as progress bar has a range of [0-1]
            phishingProgressView.Layer.CornerRadius = 3;
            phishingProgressView.ProgressTintColor = UIColor.Yellow;
            phishingProgressView.BackgroundColor = UIColor.White;
            phishingProgressView.SetProgress(phishingProgressValue, true);

            float passwordProgressValue = home_ViewModel.ReturnModuleTotalCompletionValue(home_ViewModel.passwordModules) / 100; //We divide by 100 again as progress bar has a range of [0-1]
            passwordProgressView.Layer.CornerRadius = 3;
            passwordProgressView.ProgressTintColor = UIColor.Yellow;
            passwordProgressView.BackgroundColor = UIColor.White;
            passwordProgressView.SetProgress(passwordProgressValue, true);

            float physicalProgressValue = home_ViewModel.ReturnModuleTotalCompletionValue(home_ViewModel.physicalModules) / 100; //We divide by 100 again as progress bar has a range of [0-1]
            physicalProgressView.Layer.CornerRadius = 3;
            physicalProgressView.ProgressTintColor = UIColor.Yellow;
            physicalProgressView.BackgroundColor = UIColor.White;
            physicalProgressView.SetProgress(physicalProgressValue, true);

        }

        //Bounce animation for revision button
        public void RevisionBtnTouchDown(object sender, EventArgs e)
        {
            UserInterface.ButtonDesigner(revisionButton,false);
            revisionButton.BackgroundColor = UIColor.White;
            ViewAnimations.Pop(revisionButton,0.8,1,1);   
        }

        public void RevisionBtnTouchCancel(object sender, EventArgs e)
        {
            UserInterface.ButtonDesigner(revisionButton, true);
        }

        public void RevisionBtnClicked(object sender, EventArgs e)
        {
            this.TabBarController.SelectedIndex = 1;
        }


        //Bounce animation for Quiz Button
        public void QuizBtnTouchDown(object sender, EventArgs e)
        {
            UserInterface.ButtonDesigner(quizButton, false);
            quizButton.BackgroundColor = UIColor.White;
            ViewAnimations.Pop(quizButton,0.8,1,1);
        }

        public void QuizBtnTouchCancel(object sender, EventArgs e)
        {
            UserInterface.ButtonDesigner(quizButton,true);

        }

        public void QuizBtnClicked(object sender, EventArgs e)
        {
            var storyBoard = UIStoryboard.FromName("Main", null);
            var vc = storyBoard?.InstantiateViewController("Quiz_ViewController");
            this.NavigationController.PushViewController(vc, true);
        }

        public override void ViewWillTransitionToSize(CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        {
            this.AdjustConstraintsForLandscape();
        }


        public void AdjustConstraintsForLandscape()
        {
            if (isLandscape)
            {
                progressViewLeftConstraint.Constant = 30;
                progressViewRightConstraint.Constant = 30;

                buttonsViewLeftConstraint.Constant = 35;
                buttonsViewRightConstraint.Constant = 35;
            }
            else
            {
                progressViewLeftConstraint.Constant = 20;
                progressViewRightConstraint.Constant = 20;

                buttonsViewLeftConstraint.Constant = 25;
                buttonsViewRightConstraint.Constant = 25;
            }
        }

    }


}
