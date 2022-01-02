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
            colorSelection.Add(UIColor.FromRGB(229,229,234));
            colorSelection.Add(UIColor.FromRGB(100,210,255));
            colorSelection.Add(UIColor.FromRGB(10, 132, 255));
            colorSelection.Add(UIColor.FromRGB(191, 242, 242));
            colorSelection.Add(UIColor.FromRGB(102,212,207));

            var random = new Random().Next(colorSelection.Count);
            var color = colorSelection[random];

            this.BackgroundColor = color;
            noteSidePanelView.BackgroundColor = color.Darken(4);
        }
    }
}
