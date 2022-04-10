namespace CategorizeData
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.rdbNotInterested = new System.Windows.Forms.RadioButton();
            this.rdbNotContacted = new System.Windows.Forms.RadioButton();
            this.rdbContacted = new System.Windows.Forms.RadioButton();
            this.rdbInterested = new System.Windows.Forms.RadioButton();
            this.btnName = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstSort = new System.Windows.Forms.ListBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPotentialCustomer = new System.Windows.Forms.RadioButton();
            this.rdbLead = new System.Windows.Forms.RadioButton();
            this.rdbExistingCustomer = new System.Windows.Forms.RadioButton();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnContactStatus = new System.Windows.Forms.Button();
            this.btnCustomerInterest = new System.Windows.Forms.Button();
            this.btnCustomerType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(12, 64);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(649, 121);
            this.lstCustomers.TabIndex = 14;
            // 
            // rdbNotInterested
            // 
            this.rdbNotInterested.AutoSize = true;
            this.rdbNotInterested.Location = new System.Drawing.Point(90, 19);
            this.rdbNotInterested.Name = "rdbNotInterested";
            this.rdbNotInterested.Size = new System.Drawing.Size(92, 17);
            this.rdbNotInterested.TabIndex = 28;
            this.rdbNotInterested.TabStop = true;
            this.rdbNotInterested.Text = "Not Interested";
            this.rdbNotInterested.UseVisualStyleBackColor = true;
            // 
            // rdbNotContacted
            // 
            this.rdbNotContacted.AutoSize = true;
            this.rdbNotContacted.Location = new System.Drawing.Point(90, 26);
            this.rdbNotContacted.Name = "rdbNotContacted";
            this.rdbNotContacted.Size = new System.Drawing.Size(94, 17);
            this.rdbNotContacted.TabIndex = 27;
            this.rdbNotContacted.TabStop = true;
            this.rdbNotContacted.Text = "Not Contacted";
            this.rdbNotContacted.UseVisualStyleBackColor = true;
            // 
            // rdbContacted
            // 
            this.rdbContacted.AutoSize = true;
            this.rdbContacted.Location = new System.Drawing.Point(12, 26);
            this.rdbContacted.Name = "rdbContacted";
            this.rdbContacted.Size = new System.Drawing.Size(74, 17);
            this.rdbContacted.TabIndex = 26;
            this.rdbContacted.TabStop = true;
            this.rdbContacted.Text = "Contacted";
            this.rdbContacted.UseVisualStyleBackColor = true;
            // 
            // rdbInterested
            // 
            this.rdbInterested.AutoSize = true;
            this.rdbInterested.Location = new System.Drawing.Point(12, 19);
            this.rdbInterested.Name = "rdbInterested";
            this.rdbInterested.Size = new System.Drawing.Size(72, 17);
            this.rdbInterested.TabIndex = 25;
            this.rdbInterested.TabStop = true;
            this.rdbInterested.Text = "Interested";
            this.rdbInterested.UseVisualStyleBackColor = true;
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(12, 418);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(110, 31);
            this.btnName.TabIndex = 32;
            this.btnName.Text = "Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnAscending_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(411, 259);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(250, 61);
            this.btnSort.TabIndex = 34;
            this.btnSort.Text = "Categorize";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstSort
            // 
            this.lstSort.FormattingEnabled = true;
            this.lstSort.Location = new System.Drawing.Point(12, 455);
            this.lstSort.Name = "lstSort";
            this.lstSort.Size = new System.Drawing.Size(649, 173);
            this.lstSort.TabIndex = 35;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rdbContacted);
            this.gb1.Controls.Add(this.rdbNotContacted);
            this.gb1.Location = new System.Drawing.Point(12, 293);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(195, 61);
            this.gb1.TabIndex = 36;
            this.gb1.TabStop = false;
            this.gb1.Text = "Categorize by Contact Status";
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rdbNotInterested);
            this.gb2.Controls.Add(this.rdbInterested);
            this.gb2.Location = new System.Drawing.Point(12, 226);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(195, 61);
            this.gb2.TabIndex = 37;
            this.gb2.TabStop = false;
            this.gb2.Text = "Categorize by Customer Interest";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbPotentialCustomer);
            this.groupBox1.Controls.Add(this.rdbLead);
            this.groupBox1.Controls.Add(this.rdbExistingCustomer);
            this.groupBox1.Location = new System.Drawing.Point(213, 226);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 128);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categorize by Customer Type";
            // 
            // rdbPotentialCustomer
            // 
            this.rdbPotentialCustomer.AutoSize = true;
            this.rdbPotentialCustomer.Location = new System.Drawing.Point(6, 20);
            this.rdbPotentialCustomer.Name = "rdbPotentialCustomer";
            this.rdbPotentialCustomer.Size = new System.Drawing.Size(113, 17);
            this.rdbPotentialCustomer.TabIndex = 29;
            this.rdbPotentialCustomer.TabStop = true;
            this.rdbPotentialCustomer.Text = "Potential Customer";
            this.rdbPotentialCustomer.UseVisualStyleBackColor = true;
            // 
            // rdbLead
            // 
            this.rdbLead.AutoSize = true;
            this.rdbLead.Location = new System.Drawing.Point(6, 92);
            this.rdbLead.Name = "rdbLead";
            this.rdbLead.Size = new System.Drawing.Size(49, 17);
            this.rdbLead.TabIndex = 28;
            this.rdbLead.TabStop = true;
            this.rdbLead.Text = "Lead";
            this.rdbLead.UseVisualStyleBackColor = true;
            // 
            // rdbExistingCustomer
            // 
            this.rdbExistingCustomer.AutoSize = true;
            this.rdbExistingCustomer.Location = new System.Drawing.Point(6, 58);
            this.rdbExistingCustomer.Name = "rdbExistingCustomer";
            this.rdbExistingCustomer.Size = new System.Drawing.Size(108, 17);
            this.rdbExistingCustomer.TabIndex = 25;
            this.rdbExistingCustomer.TabStop = true;
            this.rdbExistingCustomer.Text = "Existing Customer";
            this.rdbExistingCustomer.UseVisualStyleBackColor = true;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 646);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(720, 22);
            this.statusBar1.TabIndex = 39;
            this.statusBar1.Text = "statusBar1";
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "statusBarPanel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.actionToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(720, 24);
            this.menuStrip2.TabIndex = 41;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveToolStripMenuItem1,
            this.saveAsToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionToolStripMenuItem.Text = "Actions";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "New";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadToolStripMenuItem.Text = "New Window";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Open...";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            // 
            // saveAsToolStripMenuItem1
            // 
            this.saveAsToolStripMenuItem1.Name = "saveAsToolStripMenuItem1";
            this.saveAsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem1.Text = "Save as...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(596, 418);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(65, 31);
            this.btnRemove.TabIndex = 42;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnContactStatus
            // 
            this.btnContactStatus.Location = new System.Drawing.Point(138, 418);
            this.btnContactStatus.Name = "btnContactStatus";
            this.btnContactStatus.Size = new System.Drawing.Size(110, 31);
            this.btnContactStatus.TabIndex = 43;
            this.btnContactStatus.Text = "Contact Status";
            this.btnContactStatus.UseVisualStyleBackColor = true;
            // 
            // btnCustomerInterest
            // 
            this.btnCustomerInterest.Location = new System.Drawing.Point(266, 418);
            this.btnCustomerInterest.Name = "btnCustomerInterest";
            this.btnCustomerInterest.Size = new System.Drawing.Size(110, 31);
            this.btnCustomerInterest.TabIndex = 44;
            this.btnCustomerInterest.Text = "Customer Interest";
            this.btnCustomerInterest.UseVisualStyleBackColor = true;
            // 
            // btnCustomerType
            // 
            this.btnCustomerType.Location = new System.Drawing.Point(392, 418);
            this.btnCustomerType.Name = "btnCustomerType";
            this.btnCustomerType.Size = new System.Drawing.Size(112, 31);
            this.btnCustomerType.TabIndex = 45;
            this.btnCustomerType.Text = "Customer Type";
            this.btnCustomerType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 24);
            this.label1.TabIndex = 46;
            this.label1.Text = "Select one or multiple customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Select field";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Results";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 668);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomerType);
            this.Controls.Add(this.btnCustomerInterest);
            this.Controls.Add(this.btnContactStatus);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.lstSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.RadioButton rdbNotInterested;
        private System.Windows.Forms.RadioButton rdbNotContacted;
        private System.Windows.Forms.RadioButton rdbContacted;
        private System.Windows.Forms.RadioButton rdbInterested;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstSort;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPotentialCustomer;
        private System.Windows.Forms.RadioButton rdbLead;
        private System.Windows.Forms.RadioButton rdbExistingCustomer;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnContactStatus;
        private System.Windows.Forms.Button btnCustomerInterest;
        private System.Windows.Forms.Button btnCustomerType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

