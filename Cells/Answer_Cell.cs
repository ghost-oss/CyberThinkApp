using System;

using Foundation;
using UIKit;

namespace CyberThink.Cells
{
    public partial class Answer_Cell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("Answer_Cell");
        public static readonly UINib Nib;
        
        static Answer_Cell()
        {
            Nib = UINib.FromName("Answer_Cell", NSBundle.MainBundle);
        }

        protected Answer_Cell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public Answer_Cell()
        {

        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
        
            this.BackgroundColor = UIColor.White;

            this.Layer.BorderColor = UIColor.FromRGB(0, 76, 153).CGColor;
            this.Layer.BorderWidth = 5;

            this.ContentView.Layer.CornerRadius = 15;
            this.Layer.CornerRadius = 15;

        }

        public void BindDataToCell(string answer)
        {
            answerLabel.Lines = 0;
            answerLabel.SizeToFit();
            answerLabel.LineBreakMode = UILineBreakMode.WordWrap;
            answerLabel.Text = answer;
            answerLabel.Font = answerLabel.Font.WithSize(18);
        }


    }
}
