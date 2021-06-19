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

namespace CyberThink
{
	public partial class Home_ViewController : UIViewController , IUITableViewDataSource, IUITableViewDelegate, IUITabBarDelegate
	{
		public Home_ViewController (IntPtr handle) : base (handle)
		{
		}

        private Home_ViewModel home_ViewModel;

       
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpButtonUI();
            this.SetUpTitlesUI();
            this.SetBackgrounds();
            this.SetUpEventHandlers();
            this.SetNavBarTransparency();
            //this.View.BackgroundColor = UIColor.FromRGB(01, 08, 36); //VC Background color

            this.View.BackgroundColor = UIColor.FromRGB(36, 46, 71);
            this.innerViewForScroll.BackgroundColor = UIColor.FromRGB(36, 46, 71);

            home_ViewModel = new Home_ViewModel();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            this.SetUpButtonUI();
            this.InitiateProgressBars();
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
            revisionButton.SetTitleColor(UIColor.White, UIControlState.Normal);
            revisionButton.TranslatesAutoresizingMaskIntoConstraints = false;
            revisionButton.Transform = CGAffineTransform.MakeIdentity(); //Sets the button back to normal size when moving to and from VC's


            UserInterface.ButtonDesigner(quizButton,true);
            UserInterface.ButtonFontDesigner(quizButton);
            quizButton.SetTitle("Quiz", UIControlState.Normal);
            quizButton.SetTitleColor(UIColor.White, UIControlState.Normal);
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
            beginnerProgressTitle.Text = "Beginner Modules Progess";
            UserInterface.LabelDesigner(beginnerProgressTitle,18);
        }

        public void InitiateProgressBars()
        {
            float beginnerProgressValue = home_ViewModel.ReturnModuleTotalCompletionValue(home_ViewModel.beginnerModules) / 100; //We divide by 100 again as progress bar has a range of [0-1]
            beginnerProgressView.Layer.CornerRadius = 3;
            beginnerProgressView.ProgressTintColor = UIColor.Yellow;
            beginnerProgressView.BackgroundColor = UIColor.White;
            beginnerProgressView.SetProgress(beginnerProgressValue, true);

        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HomeMenuOption_Cell cell = tableView.DequeueReusableCell(HomeMenuOption_Cell.Key) as HomeMenuOption_Cell;

            if (cell == null)
            {
                cell = new HomeMenuOption_Cell();
                var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;
                cell.Layer.CornerRadius = 10;
                cell.Frame = new CGRect(0,0,50,50);

            }
            return cell;
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 10;
        }

    
        //Bounce animation for revision button
        public void RevisionBtnTouchDown(object sender, EventArgs e)
        {
            UserInterface.ButtonDesigner(revisionButton,false);
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


        //public async void test()
        //{
            
        //    await BlobCache.UserAccount.InsertObject("modules", home_ViewModel.beginnerModules);
        //    // Or without async/await:
        //    //myRevisionNotes = await BlobCache.UserAccount.GetObject<revisionNotes>("revisionNotes").Catch(Observable.Return(new revisionNotes()));


        //    var lst = await BlobCache.UserAccount.GetObject<List<Module>>("beginnerModules");


        
        //}

    }


}



//var storyBoard = UIStoryboard.FromName("Main",null);
//var vc = storyBoard?.InstantiateViewController("Modules_ViewController");
//vc.HidesBottomBarWhenPushed = false;
//this.NavigationController?.PushViewController(vc,true);





//Set this back up once you insert the table view with the outlet 'tableView'
//tableView.Delegate = this;
//tableView.DataSource = this;
