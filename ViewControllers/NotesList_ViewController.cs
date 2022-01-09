//YOU WERE JUST TESTING HOW TO HIDE AND UNHIDE THE TABLEVIEW.
//WHEN THERE IS NO REVISION NOTES, WE HIDE THE TABLE VIEW AND UNHIDE THE 'NO NOTES' IMAGE AND DO THE OPPOSITE IF THERE IS

using System;
using CyberThink.Cells;
using CyberThink.ViewModel;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CyberThink
{
	public partial class NotesList_ViewController : UIViewController, IUITableViewDelegate, IUITableViewDataSource
	{
		public NotesList_ViewController (IntPtr handle) : base (handle)
		{
		}

        private NotesList_ViewModel noteListViewModel;

        public override void ViewDidLoad()
        {
           
            base.ViewDidLoad();
            noteListViewModel = new NotesList_ViewModel();
            this.SetUpToolBar();
            notesTableView.Delegate = this;
            notesTableView.DataSource = this;
            this.SetUpUI();
        }

        public void SetUpUI()
        {
            this.View.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            notesTableView.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            innerScrollView.BackgroundColor = UIColor.FromRGB(0, 76, 153);
            emptyNotesView.BackgroundColor = UIColor.FromRGB(0, 76, 153);
        }

        public override void ViewWillAppear(bool animated)
        {
            this.ToggleEmptyNotesView();
            notesTableView.ReloadData();
            this.notesTableView.TableFooterView = new UIView();
           
        }

        public void ToggleEmptyNotesView()
        {
            emptyNotesLabel.Text = "You Have Empty Notes";
            emptyNotesLabel.TextAlignment = UITextAlignment.Center;
            emptyNotesLabel.Font = UIFont.BoldSystemFontOfSize(22);
            emptyNotesLabel.TextColor = UIColor.White;
            var attrString = new NSMutableAttributedString(emptyNotesLabel.Text);
            attrString.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), new NSRange(0, attrString.Length));
            emptyNotesLabel.AttributedText = attrString;


            if (noteListViewModel.noteList.Count == 0)
            {
                emptyNotesView.Hidden = false;
                notesTableView.Hidden = true;
            }
            else
            {
                emptyNotesView.Hidden = true;
                notesTableView.Hidden = false;
            }

            if (emptyNotesImageView.Image == null)
            {
                var sourceImage = UIImage.FromBundle("emptynotes");
                emptyNotesImageView.ContentMode = UIViewContentMode.ScaleAspectFit;
                emptyNotesImageView.Image = sourceImage;
            }

        }

        public void SetUpToolBar()
        {
            var addNotesItem = new UIBarButtonItem();
            addNotesItem.Title = "Add Note";
            addNotesItem.Clicked += NewNotesClicked;
            addNotesItem.TintColor = UIColor.White;
            addNotesItem.SetTitleTextAttributes(new UITextAttributes { Font = UIFont.BoldSystemFontOfSize(20) }, UIControlState.Normal);

            NavigationController.NavigationBar.TopItem.RightBarButtonItem = addNotesItem;
            NavigationController.NavigationBar.TopItem.Title = "My Notes";
            this.NavigationController.NavigationBar.BarStyle = UIBarStyle.BlackOpaque;
            this.NavigationController.NavigationBar.TitleTextAttributes = new UIStringAttributes { ForegroundColor = UIColor.White, Font = UIFont.BoldSystemFontOfSize(20) };

        }

        public void NewNotesClicked(object sender, EventArgs e)
        {
            var storyBoard = UIStoryboard.FromName("Main",NSBundle.MainBundle);
            var vc = this.Storyboard.InstantiateViewController("CreateNote_ViewController");
            this.NavigationController.PushViewController(vc,true);
        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return noteListViewModel.noteList.Count;
        }

        [Export("tableView:heightForRowAtIndexPath:")]
        public nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 80;
        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            Note_Cell cell = tableView.DequeueReusableCell(Note_Cell.Key) as Note_Cell;

            if (cell == null) {

                cell = new Note_Cell();
                var views = NSBundle.MainBundle.LoadNib(Note_Cell.Key, cell, null);
                cell = Runtime.GetNSObject(views.ValueAt(0)) as Note_Cell;      
            }

            //Kept this outside as solves the issue of deleting a note then adding a new note
            var note = noteListViewModel.noteList[indexPath.Row];
            cell.BindData(note.noteTitle, note.note);

            return cell;
        }

        [Export("tableView:editActionsForRowAtIndexPath:")]
        public UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var deleteModule = UITableViewRowAction.Create(UITableViewRowActionStyle.Destructive, "DeleteRow",
                (args1, index) =>
                {
                    noteListViewModel.noteList.RemoveAt(index.Row);              
                    noteListViewModel.InsertUpdatedNotesListForCache(); //Updates cache of the new changes

                    NSIndexPath[] path = { indexPath }; //Nice animation to delete the row
                    tableView.DeleteRows(path, UITableViewRowAnimation.Fade);
                    this.ToggleEmptyNotesView();

                });

            return new UITableViewRowAction[] { deleteModule };

        }

        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            var note = noteListViewModel.noteList[indexPath.Row];
            var vc = Storyboard.InstantiateViewController("SpecificNote_ViewController") as SpecificNote_ViewController;
            vc.BindData(note);
            this.NavigationController.PresentModalViewController(vc, true);

        }
    }
}
