using System;
using CyberThink.Helpers;
using Foundation;
using UIKit;

namespace CyberThink.Cells
{
    public partial class HomeMenuOption_Cell : UITableViewCell
    {
        public static readonly NSString Key = new NSString("HomeMenuOption_Cell");
        public static readonly UINib Nib;

        static HomeMenuOption_Cell()
        {
            Nib = UINib.FromName("HomeMenuOption_Cell", NSBundle.MainBundle);
        }

        protected HomeMenuOption_Cell(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public HomeMenuOption_Cell()
        {

        }

        public override void AwakeFromNib()
        {
            base.AwakeFromNib();
            this.SetUpModuleCompletionView();
            this.SetUpCellUI();
            
        }

        public void SetUpCellUI()
        {
            this.BackgroundColor = UIColor.FromRGB(199, 199, 204);
     
            this.Layer.BorderColor = UIColor.FromRGB(0, 76, 153).CGColor;
            this.Layer.BorderWidth = 5;

            this.ContentView.Layer.CornerRadius = 15;
            this.SelectionStyle = UITableViewCellSelectionStyle.None;



            //this.SeparatorInset = new UIEdgeInsets(0, 15, 0, 15);
        }

        public void SetUpModuleCompletionView()
        {
            ModuleCompletionView.Layer.BackgroundColor = UIColor.Red.CGColor;
            ModuleCompletionView.Layer.CornerRadius = 100;
            ModuleCompletionView.ClipsToBounds = false;

        }

        public void BindDataToCell(string title)
        {
            OptionTitle.Text = title;
            UserInterface.LabelDesigner(OptionTitle,18);
            OptionTitle.TextColor = UIColor.Black;
        }

        public void MarkModuleAsComplete()
        {
            UIView.Animate(duration: 0.5,
               animation: () =>
               {
                   ModuleCompletionView.Layer.BackgroundColor = ViewAnimations.ToUIColor("00FF00").CGColor;
                   this.LayoutIfNeeded();
               }, completion: null);
        }

        public void MarkModuleAsIncomplete()
        {
            UIView.Animate(duration: 0.5,
               animation: () =>
               {
                   ModuleCompletionView.Layer.BackgroundColor = ViewAnimations.ToUIColor("FF0000").CGColor;
                   this.LayoutIfNeeded();
               }, completion: null);
        }
    }
}
