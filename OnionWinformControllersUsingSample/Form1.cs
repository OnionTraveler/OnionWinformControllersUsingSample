using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using OnionWinformControllers.CheckedComboBox;  // 使用「CheckedComboBox」所需引用的命名空間
using OnionWinformControllers.DropDownMenu;  // 使用「DropDownMenu」所需引用的命名空間
using OnionWinformControllers.DoubleClickButton;


namespace OnionWinformControllersUsingSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vInitialCheckedComboBoxEvent();
            vInitialDropDownMenu();
            vInitialDoubleClickButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vCCBLoad();
        }


        #region 所有「CheckedComboBox」的使用範例
        private void vCCBLoad()
        {
            string[] coloursArr = { "Red", "Green", "Black", "White", "Orange", "Yellow", "Blue", "Maroon", "Pink", "Purple" };
            for (int i = 0; i < coloursArr.Length; i++)
            {
                CCBoxItem item = new CCBoxItem(coloursArr[i], i);
                ccbTest.Items.Add(item);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            ccbTest.MaxDropDownItems = 5;
            // Make the "Name" property the one to display, rather than the ToString() representation.
            ccbTest.DisplayMember = "Name";
            ccbTest.ValueSeparator = ", ";
            // Check the first 2 items.
            ccbTest.SetItemChecked(0, true);
            ccbTest.SetItemChecked(1, true);
            //ccb.SetItemCheckState(1, CheckState.Indeterminate);
        }


        #region 使用「CheckedComboBox」必須使用的Event
        private void vInitialCheckedComboBoxEvent()
        {
            // Manually add handler for when an item check state has been modified.
            ccbTest.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccbTest_ItemCheck);
        }

        private void ccbTest_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            vCCBItemCheck(ccbTest, sender, e);
        }

        private void ccbTest_DropDownClosed(object sender, EventArgs e)
        {
            vCCBDropDownClosed(ccbTest, sender, e);
        }
        #endregion

        #region CeheckedComboBox Event Setting Module
        private void vCCBItemCheck(CheckedComboBox ccb, object sender, ItemCheckEventArgs e)
        {
            CCBoxItem item = ccb.Items[e.Index] as CCBoxItem;

        }

        private void vCCBDropDownClosed(CheckedComboBox ccb, object sender, EventArgs e)
        {

            // Display all checked items.
            StringBuilder sb = new StringBuilder("Items checked: ");
            foreach (CCBoxItem item in ccb.CheckedItems)
            {
                sb.Append(item.Name).Append(ccb.ValueSeparator);
            }
            sb.Remove(sb.Length - ccb.ValueSeparator.Length, ccb.ValueSeparator.Length);
        }


        #endregion

        #endregion

        #region 所有「DropDownMenu」的使用範例
        private void vInitialDropDownMenu()
        {
            // Manually add handler for when an item check state has been modified.
            this.ddmTest.IsMainMenu = true;
            this.ddmTest.PrimaryColor = Color.FromArgb(191, 192, 234);

            //this.ddmReport.IsMainMenu = true;
            //this.ddmReport.PrimaryColor = Color.FromArgb(191, 192, 234);

            //this.ddmSetup.IsMainMenu = true;
            //this.ddmSetup.PrimaryColor = Color.FromArgb(191, 192, 234);
        }


        private void icnbtnDropDownMenuTest_Click(object sender, EventArgs e)
        {
            Open_DropdownMenu(this.ddmTest, sender);
        }

        private void Open_DropdownMenu(DropDownMenu DropdownMenu, object sender)
        {
            Control control = (Control)sender;
            DropdownMenu.VisibleChanged += new EventHandler((sender2, ev)
                => DropdownMenu_VisibleChanged(sender2, ev, control)
                );
            DropdownMenu.Show(control, control.Width, 0);
        }

        private void DropdownMenu_VisibleChanged(object sender, EventArgs ev, Control ctrl)
        {
            DropDownMenu DropdownMenu = (DropDownMenu)sender;
            if (!DesignMode)
            {
                if (DropdownMenu.Visible)
                    //ctrl.BackColor = Color.FromArgb(159, 161, 224);
                    ctrl.BackColor = Color.FromArgb(191, 192, 234);
                else
                    //ctrl.BackColor = Color.FromArgb(98, 102, 244);
                    ctrl.BackColor = Color.FromArgb(21, 21, 34);
            }
        }
        #endregion

        #region 所有「DoubleClickButton」的使用範例
        private void vInitialDoubleClickButton()
        {
            dcbtnTest.DoubleClick += new EventHandler(dcbtnTest_DoubleClick);
        }


        void dcbtnTest_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        #endregion
    }
}
