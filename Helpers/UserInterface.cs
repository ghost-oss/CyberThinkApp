using System;
using CoreGraphics;
using Foundation;
using CyberThink.Cells;
using CyberThink.Model;
using UIKit;
using ObjCRuntime;
using Akavache;
using System.Reactive.Linq;
using CoreAnimation;

namespace CyberThink.Helpers
{
    public class UserInterface
    {

        public static void ButtonDesigner(UIButton button, bool toggleShadows)
        {
            //Set up button UI
            button.Layer.CornerRadius = 15;
            button.Layer.ShadowColor = UIColor.Black.CGColor;
            button.Layer.ShadowRadius = 3;
            button.Layer.ShadowOffset = new CGSize(4.0f, 4.0f);
            button.Layer.ShadowOpacity = toggleShadows ? 3 : 0;
            //button.Layer.BackgroundColor = UIColor.FromRGB(9, 35, 97).CGColor;
            button.Layer.BackgroundColor = UIColor.Orange.CGColor;
            button.Layer.BorderColor = UIColor.Black.CGColor;
            button.Layer.BorderWidth = 2;
        }

        public static void BackgroundDesigner(UIView view)
        {
            view.Layer.CornerRadius = 15;
            view.BackgroundColor = UIColor.FromRGB(4, 48, 99);

        }

        public static void LabelDesigner(UILabel label, int size)
        {
            label.TextColor = UIColor.White;
            label.Font = UIFont.BoldSystemFontOfSize(size);
        }

        public static void ButtonFontDesigner(UIButton button)
        {
            button.Font = UIFont.BoldSystemFontOfSize(22);
        }

    }

    
}




//caLayer.CornerRadius = 15;
//caLayer.Frame = new CGRect(0, 0, uiButton.Frame.Width, uiButton.Frame.Height);
//caLayer.ShadowColor = UIColor.White.CGColor;
//caLayer.BackgroundColor = UIColor.Black.CGColor;
//caLayer.ShadowRadius = 3;
//caLayer.ShadowOffset = new CGSize(-1.0f, -1.0f);
//caLayer.ShadowOpacity = 3;


//if (caLayer != null)
//{
//    uiButton.Layer.InsertSublayer(caLayer,0);

//}



////Set up gradient layer
//var gradientLayer = new CAGradientLayer();
//gradientLayer.Colors = new[] { UIColor.Black.CGColor, UIColor.FromRGB(6, 143, 254).CGColor};
//gradientLayer.Locations = new NSNumber[] { 0, 1 };
//gradientLayer.Frame = new CGRect(0, 0, uiButton.Frame.Width, uiButton.Frame.Height);
//gradientLayer.CornerRadius = 15;
//UIView gradientView = new UIView();
//gradientView.Layer.AddSublayer(gradientLayer);

//////Add gradient layer as background
////uiButton.AddSubview(gradientView);
////uiButton.SendSubviewToBack(gradientView);