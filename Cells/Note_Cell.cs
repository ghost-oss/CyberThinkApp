using System;
using CyberThink.Helpers;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace CyberThink.Cells
{
    public partial class Note_Cell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("Note_Cell");
        public static readonly UINib Nib;

        public List<UIColor> colorSelection = new List<UIColor>();

        static Note_Cell()
        {
            Nib = UINib.FromName("Note_Cell", NSBundle.MainBundle);
        }

        protected Note_Cell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public Note_Cell()
        {
        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        }

        public void BindData(string title, string description)
        {
            noteTitleLabel.Text = title;
            noteTitleLabel.Font = UIFont.BoldSystemFontOfSize(18);

            noteShortDescriptionLabel.Text = description;
            noteShortDescriptionLabel.Font = UIFont.SystemFontOfSize(14);

            this.GenerateBackgroundColor();
        }

        public void GenerateBackgroundColor()
        {
            colorSelection.Add(UIColor.FromRGB(255, 211, 89));
            colorSelection.Add(UIColor.FromRGB(214, 247, 146));
            colorSelection.Add(UIColor.FromRGB(91, 187, 207));
            colorSelection.Add(UIColor.FromRGB(216, 179, 242));
            colorSelection.Add(UIColor.FromRGB(242, 179, 179));

            var random = new Random().Next(colorSelection.Count);
            var color = colorSelection[random];

            this.BackgroundColor = color;
            noteSidePanelView.BackgroundColor = color.Darken(4);
        }
    }
}
