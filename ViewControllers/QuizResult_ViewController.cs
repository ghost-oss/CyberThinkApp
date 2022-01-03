using System;
using Foundation;
using CyberThink.Helpers;
using UIKit;

namespace CyberThink
{
	public partial class QuizResult_ViewController : UIViewController
	{
		public QuizResult_ViewController (IntPtr handle) : base (handle)
		{
		}

        private int finalResult;
        private int totalQuetions;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpUI();
            this.SetUpBackToHomeButton();
            this.NavigationItem.HidesBackButton = true;

        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.DisplayFinalResult();
            this.SetUpResultImage();
        }

        public void SetUpUI()
        {
            UserInterface.BackgroundDesigner(quizResultBackgroundView);
            this.View.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            innerScrollView.BackgroundColor = UIColor.FromRGB(0, 76, 153);

        }

        public void SetUpBackToHomeButton()
        {
            UserInterface.ButtonDesigner(quizResultReturnToHomeButton, true);
            UserInterface.ButtonFontDesigner(quizResultReturnToHomeButton);
            quizResultReturnToHomeButton.SetTitle("Back to home", UIControlState.Normal);
            quizResultReturnToHomeButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            quizResultReturnToHomeButton.Layer.ShadowColor = UIColor.White.CGColor;
            quizResultReturnToHomeButton.Layer.BorderColor = UIColor.White.CGColor;

            quizResultReturnToHomeButton.TouchUpInside += quizReturnToHomeTouchDown;

           
        }


        public void BindData(int score, int numberOfQuestions)
        {
            this.finalResult = score;
            this.totalQuetions = numberOfQuestions;
        }

        public void DisplayFinalResult()
        {
            quizResultLabel.Text = "Your final score is:";
            quizResultLabel.TextAlignment = UITextAlignment.Center;
            UserInterface.LabelDesigner(quizResultLabel,30);

            quizResultPercentageLabel.Text = $"{finalResult} out of {totalQuetions}";
            quizResultPercentageLabel.TextAlignment = UITextAlignment.Center;
            UserInterface.LabelDesigner(quizResultPercentageLabel, 25);
            ViewAnimations.Pop(quizResultPercentageLabel, 2, 1, 2);
        }
         
      
        public void SetUpResultImage()
        {

            var sourceImage = UIImage.FromBundle("orangesmile");
            quizResultImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
            quizResultImageView.Image = sourceImage;
            
        }

        public void quizReturnToHomeTouchDown(object sender, EventArgs e)
        {
            this.NavigationController.PopToRootViewController(false);
        }
    }
}
