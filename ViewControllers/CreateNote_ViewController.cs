using System;
using CyberThink.Helpers;
using CyberThink.ViewModel;
using Foundation;
using UIKit;

namespace CyberThink
{
	public partial class CreateNote_ViewController : UIViewController
	{
		public CreateNote_ViewController (IntPtr handle) : base (handle)
		{
		}

        private CreateNote_ViewModel createNotesViewModel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpBackgrounds();
            this.SetUpCreateNoteLabels();
            this.SetUpSaveNoteButton();
            this.SetUpNavigationBar();
            createNotesViewModel = new CreateNote_ViewModel();
            this.View.BackgroundColor = UIColor.FromRGB(0, 76, 153);       
        }

        public void SetUpNavigationBar()
        {
            NavigationController.NavigationBar.TopItem.BackBarButtonItem = new UIBarButtonItem("My Notes", UIBarButtonItemStyle.Done, null);
            NavigationController.NavigationBar.TopItem.BackBarButtonItem.TintColor = UIColor.White;
            NavigationController.NavigationBar.TopItem.BackBarButtonItem.SetTitleTextAttributes(new UITextAttributes { Font = UIFont.BoldSystemFontOfSize(20) }, UIControlState.Normal);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public void SetUpBackgrounds()
        {
            UserInterface.BackgroundDesigner(createNoteBackgroundView);
            this.View.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            innerScrollView.BackgroundColor = UIColor.FromRGB(0, 76, 153);
        }

        public void SetUpCreateNoteLabels()
        {
            noteTitleLabel.Text = "Add Title";
            UserInterface.LabelDesigner(noteTitleLabel,17);
            noteLabel.Text = "Add Note";
            UserInterface.LabelDesigner(noteLabel,17);
        }

        public void SetUpSaveNoteButton()
        {
            UserInterface.ButtonDesigner(saveNoteButton,true);
            UserInterface.ButtonFontDesigner(saveNoteButton);
            saveNoteButton.SetTitle("Save Note", UIControlState.Normal);
            saveNoteButton.SetTitleColor(UIColor.Black, UIControlState.Normal);
            saveNoteButton.TouchUpInside += SaveNoteBtnClicked;

        }

        public void SaveNoteBtnClicked(object sender, EventArgs e)
        {
            string noteTitle = noteTitleTextField.Text;
            var note = noteTextView.Text;
            createNotesViewModel.CreateNote(noteTitle,note);

            //Goes back to notes list 
            this.NavigationController.PopToRootViewController(true);

        }
    
        
    }
}
