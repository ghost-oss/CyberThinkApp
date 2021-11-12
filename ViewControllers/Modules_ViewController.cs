using System;
using CyberThink.ViewModel;
using CyberThink.Repository;
using CyberThink.Model;
using CyberThink.Helpers;
using CyberThink.Cells;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Diagnostics;
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
            //this.GenerateViewModels();

            //this.View.BackgroundColor = UIColor.FromRGB(01, 08, 36);
            //modulesBackgroundView.Layer.BackgroundColor = UIColor.FromRGB(01, 08, 36).CGColor;


            this.View.BackgroundColor = UIColor.FromRGB(36, 46, 71);
            modulesBackgroundView.Layer.BackgroundColor = UIColor.FromRGB(36, 46, 71).CGColor;
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            this.GenerateViewModels();
        }

        public void GenerateViewModels()
        {
            moduleViewModel = new Module_ViewModel();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
            phishingModulesTableViewHeightConstraint.Constant = 0;
            passwordModulesTableViewHeightConstraint.Constant = 0;
            physicalModulesTableViewHeightConstraint.Constant = 0;
            scrollView.ContentOffset = new CGPoint(0,0);
        }

        public void SetUpTableViewsAndButtons()
        {
            phishingModulesTableView.DataSource = this;
            phishingModulesTableView.Delegate = this;
            phishingModulesTableView.AccessibilityIdentifier = "phishingModulesTableView";
            phishingModulesTableView.BackgroundColor = UIColor.Clear;

            passwordModulesTableView.DataSource = this;
            passwordModulesTableView.Delegate = this;
            passwordModulesTableView.AccessibilityIdentifier = "passwordModulesTableView";
            passwordModulesTableView.BackgroundColor = UIColor.Clear;

            physicalModulesTableView.DataSource = this;
            physicalModulesTableView.Delegate = this;
            physicalModulesTableView.AccessibilityIdentifier = "physicalModulesTableView";
            physicalModulesTableView.BackgroundColor = UIColor.Clear;

        }

        public void SetUpButtons()
        {
            UserInterface.ButtonDesigner(phishingModulesButton, false);
            UserInterface.ButtonFontDesigner(phishingModulesButton);
            phishingModulesButton.AccessibilityIdentifier = "phishingModulesButton";
            phishingModulesButton.SetTitle("Phishing Modules", UIControlState.Normal);
           
            UserInterface.ButtonDesigner(passwordModulesButton, false);
            UserInterface.ButtonFontDesigner(passwordModulesButton);
            passwordModulesButton.AccessibilityIdentifier = "passwordModulesButton";
            passwordModulesButton.SetTitle("Secure Password Modules", UIControlState.Normal);

            UserInterface.ButtonDesigner(physicalModulesButton, false);
            UserInterface.ButtonFontDesigner(physicalModulesButton);
            physicalModulesButton.AccessibilityIdentifier = "physicalModulesButton";
            physicalModulesButton.SetTitle("Physical Security Modules", UIControlState.Normal);
        }


        public void SetUpEventHadlers()
        {
            phishingModulesButton.TouchUpInside += ToggleTableView;
            passwordModulesButton.TouchUpInside += ToggleTableView;
            physicalModulesButton.TouchUpInside += ToggleTableView;
        }

        public void ToggleTableView(object sender, EventArgs e)
        {
            UIButton button = (UIButton)sender;

            if ((phishingModulesTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "phishingModulesButton")
                || (passwordModulesTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "passwordModulesButton")
                    || (physicalModulesTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "physicalModulesButton"))
            {
                UIView.Animate(duration: 0.7,
               animation: () =>
               {
                   if (button.AccessibilityIdentifier == "phishingModulesButton")
                   {
                       phishingModulesTableViewHeightConstraint.Constant = 215;
                   }
                   else if (button.AccessibilityIdentifier == "passwordModulesButton")
                   {
                       passwordModulesTableViewHeightConstraint.Constant = 215;
                   }
                   else
                   {
                       physicalModulesTableViewHeightConstraint.Constant = 215;
                   }
                   this.View.LayoutIfNeeded();
               }, completion: null);
            }
            else
            {
                UIView.Animate(duration: 0.7,
              animation: () =>
              {
                  if (button.AccessibilityIdentifier == "phishingModulesButton")
                  {
                      phishingModulesTableViewHeightConstraint.Constant = 0;
                  }
                  else if (button.AccessibilityIdentifier == "passwordModulesButton")
                  {
                      passwordModulesTableViewHeightConstraint.Constant = 0;
                  }
                  else
                  {
                      physicalModulesTableViewHeightConstraint.Constant = 0;
                  }
                  this.View.LayoutIfNeeded();
              }, completion: null);
            }

        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 3;
        }


        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HomeMenuOption_Cell cell = tableView.DequeueReusableCell(HomeMenuOption_Cell.Key) as HomeMenuOption_Cell;

            if (tableView.AccessibilityIdentifier == "phishingModulesTableView")
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    Module module = moduleViewModel.phishingModulesList[indexPath.Row];
                    cell.BindDataToCell(module.moduleName);

                    if (module.isComplete == true)
                    {
                        cell.MarkModuleAsComplete();
                    }
                }
            }
            else if (tableView.AccessibilityIdentifier == "passwordModulesTableView")
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    Module module = moduleViewModel.passwordModulesList[indexPath.Row];
                    cell.BindDataToCell(module.moduleName);

                    if (module.isComplete == true)
                    {
                        cell.MarkModuleAsComplete();
                    }
                }
            }
            else
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    Module module = moduleViewModel.physicalModulesList[indexPath.Row];
                    cell.BindDataToCell(module.moduleName);

                    if (module.isComplete == true)
                    {
                        cell.MarkModuleAsComplete();
                    }
                }
            }

            cell.Layer.CornerRadius = 15;
            return cell;
        }


        [Export("tableView:didSelectRowAtIndexPath:")]
        public void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (tableView.AccessibilityIdentifier == "phishingModulesTableView")
            {
                Module module = moduleViewModel.phishingModulesList[indexPath.Row];
                this.ModuleSelected(module);
            }
            else if (tableView.AccessibilityIdentifier == "passwordModulesTableView")
            {
                Module module = moduleViewModel.passwordModulesList[indexPath.Row];
                this.ModuleSelected(module);
            }
            else
            {
                Module module = moduleViewModel.physicalModulesList[indexPath.Row];
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
