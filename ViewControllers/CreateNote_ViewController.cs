using System;
using CyberThink.Helpers;
using CyberThink.ViewModel;
using System.Text.RegularExpressions;
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
            string note = noteTextView.Text;

            //Invalid Char input
            note = RegExValidation(note);
            noteTitle = RegExValidation(noteTitle);

            //Text input 
            if (!ValidateTextInput(noteTitle,note))
            {
                var alert = UIAlertController.Create("Error", "Both fields must be filled", UIAlertControllerStyle.Alert);
                var action = UIAlertAction.Create("Ok", UIAlertActionStyle.Destructive, (obj) => { });
                alert.AddAction(action);
                this.PresentViewController(alert, true, null);
            }
            else
            { 
                createNotesViewModel.CreateNote(noteTitle, note);
            }

            //Goes back to notes list 
            this.NavigationController.PopToRootViewController(true);

        }


        public bool ValidateTextInput(string noteTitle, string note)
        {

            if ((string.IsNullOrEmpty(noteTitle) || string.IsNullOrEmpty(note)))
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }

        public string RegExValidation(string input)
        {
            //var regex = new Regex("[^a-zA-Z0-9 _.,!()]");
            //regex.Replace(input, string.Empty);

            var sanitizedStr = Regex.Replace(input, @"[^\w\d\.@!%*&$+='{}\()\[\].?: -]", "");

            if (string.IsNullOrEmpty(sanitizedStr) && !string.Equals(sanitizedStr, input))
            {
                var alert = UIAlertController.Create("Error", "Invalid characters detected", UIAlertControllerStyle.Alert);
                var action = UIAlertAction.Create("Ok", UIAlertActionStyle.Destructive, (obj) => { });
                alert.AddAction(action);
                this.PresentViewController(alert, true, null);
            }

            return sanitizedStr;
        }


        
    }
}
