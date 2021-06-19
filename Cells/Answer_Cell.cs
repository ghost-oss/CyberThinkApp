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
        }

        public void BindDataToCell(string answer)
        {
            answerLabel.Text = answer;
        }

    }
}
