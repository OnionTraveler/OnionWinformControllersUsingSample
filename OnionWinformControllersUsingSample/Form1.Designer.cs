
namespace OnionWinformControllersUsingSample
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.icnbtnDropDownMenuTest = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ccbTest = new OnionCheckedComboBoxControl.CheckedComboBox();
            this.ddmTest = new OnionDropDownMenuControl.DropDownMenu(this.components);
            this.選項一ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.選項二ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dcbtnTest = new OnionDoubleClickButtonControl.DoubleClickButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ddmTest.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 337);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(624, 308);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(306, 300);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.icnbtnDropDownMenuTest);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 43);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(296, 44);
            this.panel3.TabIndex = 2;
            // 
            // icnbtnDropDownMenuTest
            // 
            this.icnbtnDropDownMenuTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(34)))));
            this.icnbtnDropDownMenuTest.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnbtnDropDownMenuTest.FlatAppearance.BorderSize = 0;
            this.icnbtnDropDownMenuTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnbtnDropDownMenuTest.ForeColor = System.Drawing.Color.White;
            this.icnbtnDropDownMenuTest.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icnbtnDropDownMenuTest.IconColor = System.Drawing.Color.White;
            this.icnbtnDropDownMenuTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icnbtnDropDownMenuTest.IconSize = 25;
            this.icnbtnDropDownMenuTest.Location = new System.Drawing.Point(5, 5);
            this.icnbtnDropDownMenuTest.Name = "icnbtnDropDownMenuTest";
            this.icnbtnDropDownMenuTest.Size = new System.Drawing.Size(286, 33);
            this.icnbtnDropDownMenuTest.TabIndex = 0;
            this.icnbtnDropDownMenuTest.Text = "DropDownMenuBtn";
            this.icnbtnDropDownMenuTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnbtnDropDownMenuTest.UseVisualStyleBackColor = false;
            this.icnbtnDropDownMenuTest.Click += new System.EventHandler(this.icnbtnDropDownMenuTest_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ccbTest);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(296, 38);
            this.panel2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(624, 308);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ccbTest
            // 
            this.ccbTest.CheckOnClick = true;
            this.ccbTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ccbTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ccbTest.DropDownHeight = 1;
            this.ccbTest.FormattingEnabled = true;
            this.ccbTest.IntegralHeight = false;
            this.ccbTest.Location = new System.Drawing.Point(5, 5);
            this.ccbTest.Name = "ccbTest";
            this.ccbTest.Size = new System.Drawing.Size(286, 24);
            this.ccbTest.TabIndex = 0;
            this.ccbTest.ValueSeparator = ", ";
            this.ccbTest.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ccbTest_ItemCheck);
            this.ccbTest.DropDownClosed += new System.EventHandler(this.ccbTest_DropDownClosed);
            // 
            // ddmTest
            // 
            this.ddmTest.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.ddmTest.IsMainMenu = false;
            this.ddmTest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.選項一ToolStripMenuItem,
            this.選項二ToolStripMenuItem});
            this.ddmTest.MenuItemHeight = 25;
            this.ddmTest.MenuItemTextColor = System.Drawing.Color.Empty;
            this.ddmTest.Name = "ddmTest";
            this.ddmTest.PrimaryColor = System.Drawing.Color.Empty;
            this.ddmTest.Size = new System.Drawing.Size(125, 48);
            // 
            // 選項一ToolStripMenuItem
            // 
            this.選項一ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.選項一ToolStripMenuItem.Name = "選項一ToolStripMenuItem";
            this.選項一ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.選項一ToolStripMenuItem.Text = "選項一";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem2.Text = "1-1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(99, 22);
            this.toolStripMenuItem3.Text = "1-2";
            // 
            // 選項二ToolStripMenuItem
            // 
            this.選項二ToolStripMenuItem.Name = "選項二ToolStripMenuItem";
            this.選項二ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.選項二ToolStripMenuItem.Text = "選項二";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.panel4.Controls.Add(this.dcbtnTest);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 87);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(296, 44);
            this.panel4.TabIndex = 3;
            // 
            // dcbtnTest
            // 
            this.dcbtnTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dcbtnTest.FlatAppearance.BorderSize = 0;
            this.dcbtnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.dcbtnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(151)))));
            this.dcbtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dcbtnTest.Location = new System.Drawing.Point(4, 4);
            this.dcbtnTest.Name = "dcbtnTest";
            this.dcbtnTest.Size = new System.Drawing.Size(288, 36);
            this.dcbtnTest.TabIndex = 0;
            this.dcbtnTest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 337);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ddmTest.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private OnionCheckedComboBoxControl.CheckedComboBox ccbTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton icnbtnDropDownMenuTest;
        private OnionDropDownMenuControl.DropDownMenu ddmTest;
        private System.Windows.Forms.ToolStripMenuItem 選項一ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 選項二ToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private OnionDoubleClickButtonControl.DoubleClickButton dcbtnTest;
    }
}

