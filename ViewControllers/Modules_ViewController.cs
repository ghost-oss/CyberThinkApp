using System;
using CyberThink.ViewModel;
using CyberThink.Repository;
using CyberThink.Model;
using CyberThink.Helpers;
using CyberThink.Cells;
using Foundation;
using ObjCRuntime;
using UIKit;
using CoreAnimation;
using CoreGraphics;

namespace CyberThink
{
	public partial class Modules_ViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
	{
        public static readonly NSString Key = new NSString("Modules_ViewController");
        public Modules_ViewController(IntPtr handle) : base(handle)
        {
        }

        public Module_ViewModel moduleViewModel;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpEventHadlers();
            this.SetUpTableViewsAndButtons();
            this.SetUpButtons();
            this.GenerateViewModels();
            //this.View.BackgroundColor = UIColor.FromRGB(01, 08, 36);
            //modulesBackgroundView.Layer.BackgroundColor = UIColor.FromRGB(01, 08, 36).CGColor;


            this.View.BackgroundColor = UIColor.FromRGB(36, 46, 71);
            modulesBackgroundView.Layer.BackgroundColor = UIColor.FromRGB(36, 46, 71).CGColor;
        }

        public void GenerateViewModels()
        {
            moduleViewModel = new Module_ViewModel();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            beginnerModulesTableViewHeightConstraint.Constant = 0;
            intermediaryTableViewHeightConstraint.Constant = 0;
            scrollView.ContentOffset = new CGPoint(0,0);
        }

        public void SetUpTableViewsAndButtons()
        {
            begginerModulesTableView.DataSource = this;
            begginerModulesTableView.Delegate = this;
            begginerModulesTableView.AccessibilityIdentifier = "beginnerTableView";
            begginerModulesTableView.BackgroundColor = UIColor.Clear;

            IntermediaryModulesTableView.DataSource = this;
            IntermediaryModulesTableView.Delegate = this;
            IntermediaryModulesTableView.AccessibilityIdentifier = "IntermediaryTableView";
            IntermediaryModulesTableView.BackgroundColor = UIColor.Clear;
        }

        public void SetUpButtons()
        {
            UserInterface.ButtonDesigner(beginnerModulesButton, false);
            UserInterface.ButtonFontDesigner(beginnerModulesButton);
            beginnerModulesButton.AccessibilityIdentifier = "beginnerButton";
            beginnerModulesButton.SetTitle("Beginner Modules", UIControlState.Normal);
           
            UserInterface.ButtonDesigner(IntermediaryModulesButton, false);
            UserInterface.ButtonFontDesigner(IntermediaryModulesButton);
            IntermediaryModulesButton.AccessibilityIdentifier = "intermediaryButton";
            IntermediaryModulesButton.SetTitle("Intermediary Modules", UIControlState.Normal); 
        }


        public void SetUpEventHadlers()
        {
            beginnerModulesButton.TouchUpInside += ToggleTableView;
            IntermediaryModulesButton.TouchUpInside += ToggleTableView;
        }

        public void ToggleTableView(object sender, EventArgs e)
        {
            UIButton button = (UIButton)sender;

            if ((beginnerModulesTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "beginnerButton")
                || (intermediaryTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "intermediaryButton"))
            {
                UIView.Animate(duration: 0.7,
               animation: () =>
               {
                   if (button.AccessibilityIdentifier == "beginnerButton")
                   {
                       beginnerModulesTableViewHeightConstraint.Constant = 250;
                   }
                   else
                   {
                       intermediaryTableViewHeightConstraint.Constant = 250;
                   }
                   this.View.LayoutIfNeeded();
               }, completion: null);
            }
            else
            {
                UIView.Animate(duration: 0.7,
              animation: () =>
              {
                  if (button.AccessibilityIdentifier == "beginnerButton")
                  {
                      beginnerModulesTableViewHeightConstraint.Constant = 0;
                  }
                  else
                  {
                      intermediaryTableViewHeightConstraint.Constant = 0;
                  };
                  this.View.LayoutIfNeeded();
              }, completion: null);
            }

        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 4;
        }


        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HomeMenuOption_Cell cell = tableView.DequeueReusableCell(HomeMenuOption_Cell.Key) as HomeMenuOption_Cell;

            if (tableView.AccessibilityIdentifier == "beginnerTableView")
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    Module module = moduleViewModel.beginnerModulesList[indexPath.Row];
                    cell.BindDataToCell(module.moduleName);
                }
            }
            else
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    Module module = moduleViewModel.intermidiateModulesList[indexPath.Row];
                    cell.BindDataToCell(module.moduleName);
                }
            }

            cell.Layer.CornerRadius = 15;
            return cell;
        }


        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (tableView.AccessibilityIdentifier == "beginnerTableView")
            {
                Module module = moduleViewModel.beginnerModulesList[indexPath.Row];
                this.ModuleSelected(module);
            }
            else
            {
                Module module = moduleViewModel.beginnerModulesList[indexPath.Row];
                this.ModuleSelected(module);
            }
        }


        public void ModuleSelected(Module moduleObj)
        {
            var vc = Storyboard?.InstantiateViewController("SpecificModule_ViewController") as SpecificModule_ViewController; //FYI 'as' is type casting so we can access the VC's methods
            vc.BindData(moduleObj.moduleName, moduleObj.moduleInformation);
            this.NavigationController.PresentModalViewController(vc,true);
        }

        [Export("tableView:editActionsForRowAtIndexPath:")]
        public UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {

            var completeModule = UITableViewRowAction.Create(UITableViewRowActionStyle.Normal, "Complete",
                (args1, index) =>
                {
                    HomeMenuOption_Cell cell = tableView.CellAt(index) as HomeMenuOption_Cell;
                    cell.MarkModuleAsComplete();
                    moduleViewModel.MarkModuleAsComplete(tableView.AccessibilityIdentifier,index.Row);
                    cell.Layer.CornerRadius = 15; //Defined this again as once action has been invoked, a new instance of a cell is created hence we have to reset the corner radius else it reform back to square corners
                    
                });

            return new UITableViewRowAction[] { completeModule };
        }

    }
}
