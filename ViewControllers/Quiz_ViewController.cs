using System;
using CyberThink.Helpers;
using CyberThink.Model;
using CyberThink.ViewModel;
using CyberThink.Cells;
using Foundation;
using UIKit;
using ObjCRuntime;
using CoreGraphics;

namespace CyberThink
{
	public partial class Quiz_ViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
	{
		public Quiz_ViewController (IntPtr handle) : base (handle)
		{
		}

        private Quiz_ViewModel quizViewModel;
        private int questionIndex;
        private int scoreTracker;
        private Answer_Cell cell;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            quizViewModel = new Quiz_ViewModel();
            this.BeginQuiz(); // Called once to set index to 0 and we don't want to keep resetting this on viewwillappear as the question - answers go out of sync
            this.SetUpUI();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.SetUpTableView();
            this.UpdateProgess(questionIndex);
        }

        public void UpdateProgess(float currentQuestionIndex)
        {
            //(+1 as index begins from 0)
             currentQuestionIndex += 1;

            //Title                                 
            questionProgressTitle.Text = $"Question {currentQuestionIndex} out of {quizViewModel.questions.Count}:";

            //ProgressBar
            float progress = currentQuestionIndex / quizViewModel.questions.Count;
            questionProgressBar.SetProgress(progress, true);         
        }

        public void SetUpTableView()
        {
            answerTable.TableFooterView = new UIView();
            answerTable.BackgroundColor = UIColor.Clear;
            answerTable.Delegate = this;
            answerTable.DataSource = this;
            answerTable.RowHeight = UITableView.AutomaticDimension;
            answerTable.EstimatedRowHeight = 100f;
        }

        public void SetUpUI()
        {
            this.View.BackgroundColor = UIColor.FromRGB(0, 76, 153);

            questionProgressBar.Transform = CGAffineTransform.MakeScale(1, 5);
            questionProgressBar.ProgressTintColor = UIColor.Yellow;
            questionProgressBar.TrackTintColor = UIColor.White;
            questionProgressBar.Layer.CornerRadius = 3;

            questionProgressTitle.TextColor = UIColor.White;
            UserInterface.LabelDesigner(questionProgressTitle, 20);

            NavigationController.NavigationBar.TopItem.BackBarButtonItem = new UIBarButtonItem("Home", UIBarButtonItemStyle.Done, null);
            NavigationController.NavigationBar.TopItem.BackBarButtonItem.TintColor = UIColor.White;
            NavigationController.NavigationBar.TopItem.BackBarButtonItem.SetTitleTextAttributes(new UITextAttributes { Font = UIFont.BoldSystemFontOfSize(20) }, UIControlState.Normal);
        }

        public void BeginQuiz()
        {
            questionIndex = 0;
            this.ConfigureQuestion(quizViewModel?.questions[questionIndex]);
        }

        public void ConfigureQuestion(Question currentQuestion)
        {
            //Lines + SizeToFit() allow us to align text left-top and resize acording to text length
            question.Lines = 0;
            question.SizeToFit();
            question.LineBreakMode = UILineBreakMode.WordWrap;
            question.Text = currentQuestion.question;
            question.Font = UIFont.BoldSystemFontOfSize(20);
            question.TextColor = UIColor.White;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            cell = tableView.DequeueReusableCell(Answer_Cell.Key) as Answer_Cell;
            var view = NSBundle.MainBundle.LoadNib(Answer_Cell.Key, cell, null);
            cell = Runtime.GetNSObject(view.ValueAt(0)) as Answer_Cell;

            Answer answerOption = quizViewModel?.questions[questionIndex]?.answers[indexPath.Row];
            cell.BindDataToCell(answerOption.answer);
            return cell;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return quizViewModel.questions[questionIndex].answers.Count;
        }

        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            //Checking if the answer is correct if so then we add 1 to the scoreTracker
            scoreTracker = quizViewModel.CheckAnswer(quizViewModel.questions[questionIndex].answers[indexPath.Row]) ? scoreTracker + 1 : scoreTracker;
            questionIndex += 1;

            if (questionIndex < quizViewModel.questions.Count)
            {
                this.ConfigureQuestion(quizViewModel.questions[questionIndex]);
                this.UpdateProgess(questionIndex);

                answerTable.ReloadData();
                this.View.ReloadInputViews();
                scrollView.ContentOffset = new CGPoint(0,0);
            }
            else
            {
                this.EndQuiz();
            }
            
        }

        public void EndQuiz()
        {
            var vc = Storyboard.InstantiateViewController("QuizResult_ViewController") as QuizResult_ViewController;
            vc.BindData(scoreTracker, quizViewModel.questions.Count);
            NavigationController.PushViewController(vc,true);             
        }

    }
    
}
