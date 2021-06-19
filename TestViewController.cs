/*
 * PLEASE NOTE: This VC utilises the module repository WITHOUT the use of a ViewModel. 
 * This example retrieves data straight from the repository and DOES NOT respect the MVVM pattern. 
 *
 */
using System;
using CyberThink.Repository;
using CyberThink.Model;
using CyberThink.Cells;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace CyberThink
{
    public partial class TestViewController : UIViewController, IUITableViewDataSource, IUITableViewDelegate
    {

        private ModuleRepository moduleRepository;

        public TestViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.SetUpEventHandlers();
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            tableView.DataSource = this;
            tableView.Delegate = this;
            tableViewHeightConstraint.Constant = 0;


            secondTableView.DataSource = this;
            secondTableView.Delegate = this;
            secondTableViewHeightConstraint.Constant = 0;


            dropDownButton.AccessibilityIdentifier = "Button1";
            secondDropDownButton.AccessibilityIdentifier = "Button2";

            tableView.AccessibilityIdentifier = "tableView1";
            secondTableView.AccessibilityIdentifier = "tableView2";

        }


        public void SetUpEventHandlers()
        {
            dropDownButton.TouchUpInside += ToggleTableView;
            secondDropDownButton.TouchUpInside += ToggleTableView;
        }

        public void ToggleTableView(object sender, EventArgs e)
        {

            UIButton button = (UIButton)sender;

            if ((tableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "Button1") || (secondTableViewHeightConstraint.Constant == 0 && button.AccessibilityIdentifier == "Button2"))
            {
                UIView.Animate(duration: 0.7,
               animation: () =>
               {
                   if (button.AccessibilityIdentifier == "Button1")
                   {
                       tableViewHeightConstraint.Constant = 250;
                   }
                   else
                   {
                       secondTableViewHeightConstraint.Constant = 250;
                   }

                   this.View.LayoutIfNeeded();
               }, completion: null);
            }
            else
            {
                UIView.Animate(duration: 0.7,
              animation: () =>
              {
                  if (button.AccessibilityIdentifier == "Button1")
                  {
                      tableViewHeightConstraint.Constant = 0;
                  }
                  else
                  {
                      secondTableViewHeightConstraint.Constant = 0;
                  };
                  this.View.LayoutIfNeeded();
              }, completion: null);
            }

        }

        public UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            HomeMenuOption_Cell cell = tableView.DequeueReusableCell(HomeMenuOption_Cell.Key) as HomeMenuOption_Cell;

            moduleRepository = new ModuleRepository();
            moduleRepository.GenerateModules();

            if (tableView.AccessibilityIdentifier == "tableView1")
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    //Module module = moduleRepository.begginerModulesList[indexPath.Row];
                    //cell.BindDataToCell(module.moduleName);

                }
                return cell;
            }
            else
            {
                if (cell == null)
                {
                    cell = new HomeMenuOption_Cell();
                    var views = NSBundle.MainBundle.LoadNib(HomeMenuOption_Cell.Key, cell, null);
                    cell = Runtime.GetNSObject(views.ValueAt(0)) as HomeMenuOption_Cell;

                    //Module module = moduleRepository.intermidiateModulesList[indexPath.Row];
                    //cell.BindDataToCell(module.moduleName);

                }
                return cell;
            }

        }

        public nint RowsInSection(UITableView tableView, nint section)
        {
            return 4;
        }

    }
}





//CODE WORTH KEEPING INCASE OF COMPLICATION

//THIS PIECE OF CODE ANIMATES THE TABLE VIEW TO DROP IT AND PULL IT BACK UP
//if (tableViewHeightConstraint.Constant == 0)
//{
//    UIView.Animate(duration: 0.7,
//   animation: () =>
//   {
//       tableViewHeightConstraint.Constant = 250;
//       this.View.LayoutIfNeeded();

//   }, completion: null);
//}
//else
//{
//    UIView.Animate(duration: 0.7,
//  animation: () =>
//  {

//      tableViewHeightConstraint.Constant = 0;
//      this.View.LayoutIfNeeded();

//  }, completion: null);
//}
