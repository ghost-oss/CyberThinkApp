/**
 * Why did i wrap a UINavigationController for every viewcontroller i wanted to be displayed within the tab?
 * 
 *  UINavigationController allows us to keep track of new VC's being placed on the stack within the base VC (Example being Module VC)
 *  Suppose we clicked a button to create a new instance of a VC, we would then want to be able to keep track and go back between the VC's if needed. 
 *  Without UINavigationController, we cannot track what VC's which are being invoked and we cannot go back and forth between them.
 *  As a safety margine, i provided every Tab VC with it's own navigationController to keep track of it's VC stack within their own domain.
 *  
 *  NOTE:
 *  Also certain funcationalites cannot be done without UINavigationController i.e modal VC pop-ups require this 
 */

using System;
using UIKit;
namespace CyberThink
{
	public partial class TabBarController : UITabBarController
	{
		public TabBarController (IntPtr handle) : base (handle)
		{
		}

		public TabBarController()
        {
            var homeTab = UIStoryboard.FromName("Main", null).InstantiateViewController("Home_ViewController");
            var modulesTab = UIStoryboard.FromName("Main", null).InstantiateViewController("Modules_ViewController");
            var notesTab = UIStoryboard.FromName("Main", null).InstantiateViewController("NotesList_ViewController");

            this.ViewControllers = new UIViewController[] { new UINavigationController(homeTab), new UINavigationController(modulesTab), new UINavigationController(notesTab) };
        }
    }
}
