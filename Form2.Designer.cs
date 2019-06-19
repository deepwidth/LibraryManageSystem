namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MyBook = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBookDataGridView = new System.Windows.Forms.DataGridView();
            this.textBoxBookName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonB = new System.Windows.Forms.Button();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.textBoxReturn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPasswd = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPasswd = new System.Windows.Forms.TextBox();
            this.panelRe = new System.Windows.Forms.Panel();
            this.dataGridViewReturn = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGridView)).BeginInit();
            this.panelReturn.SuspendLayout();
            this.panelPasswd.SuspendLayout();
            this.panelRe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.工具ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1055, 29);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChangeInfo,
            this.MyBook,
            this.deleteAccount});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 25);
            this.toolStripMenuItem1.Text = "账户";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ChangeInfo
            // 
            this.ChangeInfo.Name = "ChangeInfo";
            this.ChangeInfo.Size = new System.Drawing.Size(216, 26);
            this.ChangeInfo.Text = "修改信息";
            this.ChangeInfo.Click += new System.EventHandler(this.ChangeInfo_Click_1);
            // 
            // MyBook
            // 
            this.MyBook.Name = "MyBook";
            this.MyBook.Size = new System.Drawing.Size(216, 26);
            this.MyBook.Text = "我的借阅";
            this.MyBook.Click += new System.EventHandler(this.MyBook_Click);
            // 
            // deleteAccount
            // 
            this.deleteAccount.Name = "deleteAccount";
            this.deleteAccount.Size = new System.Drawing.Size(216, 26);
            this.deleteAccount.Text = "删除账户";
            this.deleteAccount.Click += new System.EventHandler(this.deleteAccount_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员工具ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(52, 25);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 管理员工具ToolStripMenuItem
            // 
            this.管理员工具ToolStripMenuItem.Name = "管理员工具ToolStripMenuItem";
            this.管理员工具ToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.管理员工具ToolStripMenuItem.Text = "管理员工具";
            this.管理员工具ToolStripMenuItem.Click += new System.EventHandler(this.管理员工具ToolStripMenuItem_Click);
            // 
            // SearchBookDataGridView
            // 
            this.SearchBookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBookDataGridView.Location = new System.Drawing.Point(0, 169);
            this.SearchBookDataGridView.Name = "SearchBookDataGridView";
            this.SearchBookDataGridView.RowTemplate.Height = 27;
            this.SearchBookDataGridView.Size = new System.Drawing.Size(786, 390);
            this.SearchBookDataGridView.TabIndex = 4;
            this.SearchBookDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchBookDataGridView_CellContentClick);
            // 
            // textBoxBookName
            // 
            this.textBoxBookName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBookName.Location = new System.Drawing.Point(126, 80);
            this.textBoxBookName.Name = "textBoxBookName";
            this.textBoxBookName.Size = new System.Drawing.Size(525, 28);
            this.textBoxBookName.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSearch.Location = new System.Drawing.Point(325, 123);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(98, 31);
            this.buttonSearch.TabIndex = 7;
            this.buttonSearch.Text = "全馆搜索";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelB.Location = new System.Drawing.Point(890, 169);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(106, 24);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "我要借书";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(846, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "图书ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxID.Location = new System.Drawing.Point(919, 225);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 28);
            this.textBoxID.TabIndex = 10;
            // 
            // buttonB
            // 
            this.buttonB.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonB.Location = new System.Drawing.Point(894, 271);
            this.buttonB.Name = "buttonB";
            this.buttonB.Size = new System.Drawing.Size(99, 32);
            this.buttonB.TabIndex = 11;
            this.buttonB.Text = "确定借阅";
            this.buttonB.UseVisualStyleBackColor = true;
            this.buttonB.Click += new System.EventHandler(this.buttonB_Click);
            // 
            // panelReturn
            // 
            this.panelReturn.Controls.Add(this.buttonReturn);
            this.panelReturn.Controls.Add(this.textBoxReturn);
            this.panelReturn.Controls.Add(this.label2);
            this.panelReturn.Controls.Add(this.label3);
            this.panelReturn.Location = new System.Drawing.Point(833, 326);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(197, 165);
            this.panelReturn.TabIndex = 12;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonReturn.Location = new System.Drawing.Point(60, 117);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(99, 32);
            this.buttonReturn.TabIndex = 15;
            this.buttonReturn.Text = "确定归还";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxReturn
            // 
            this.textBoxReturn.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxReturn.Location = new System.Drawing.Point(85, 71);
            this.textBoxReturn.Name = "textBoxReturn";
            this.textBoxReturn.Size = new System.Drawing.Size(100, 28);
            this.textBoxReturn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "图书ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(53, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "我要还书";
            // 
            // panelPasswd
            // 
            this.panelPasswd.Controls.Add(this.buttonCancel);
            this.panelPasswd.Controls.Add(this.label5);
            this.panelPasswd.Controls.Add(this.label4);
            this.panelPasswd.Controls.Add(this.buttonDelete);
            this.panelPasswd.Controls.Add(this.textBoxPasswd);
            this.panelPasswd.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panelPasswd.Location = new System.Drawing.Point(0, 77);
            this.panelPasswd.Name = "panelPasswd";
            this.panelPasswd.Size = new System.Drawing.Size(1047, 479);
            this.panelPasswd.TabIndex = 13;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCancel.Location = new System.Drawing.Point(935, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 28);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "取消删除";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(211, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "输入密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(378, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = "！！！危险操作！！！";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonDelete.Location = new System.Drawing.Point(465, 200);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(107, 42);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "删除账户";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPasswd
            // 
            this.textBoxPasswd.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPasswd.Location = new System.Drawing.Point(345, 126);
            this.textBoxPasswd.Name = "textBoxPasswd";
            this.textBoxPasswd.Size = new System.Drawing.Size(372, 28);
            this.textBoxPasswd.TabIndex = 14;
            // 
            // panelRe
            // 
            this.panelRe.Controls.Add(this.dataGridViewReturn);
            this.panelRe.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelRe.Location = new System.Drawing.Point(0, 160);
            this.panelRe.Name = "panelRe";
            this.panelRe.Size = new System.Drawing.Size(818, 396);
            this.panelRe.TabIndex = 14;
            // 
            // dataGridViewReturn
            // 
            this.dataGridViewReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReturn.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewReturn.Name = "dataGridViewReturn";
            this.dataGridViewReturn.RowTemplate.Height = 27;
            this.dataGridViewReturn.Size = new System.Drawing.Size(815, 396);
            this.dataGridViewReturn.TabIndex = 0;
            this.dataGridViewReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReturn_CellContentClick);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(1055, 555);
            this.Controls.Add(this.panelPasswd);
            this.Controls.Add(this.panelRe);
            this.Controls.Add(this.buttonB);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.SearchBookDataGridView);
            this.Controls.Add(this.textBoxBookName);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form2";
            this.Text = "图书管理";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGridView)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            this.panelPasswd.ResumeLayout(false);
            this.panelPasswd.PerformLayout();
            this.panelRe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bobToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员工具ToolStripMenuItem;
        private System.Windows.Forms.DataGridView SearchBookDataGridView;
        private System.Windows.Forms.TextBox textBoxBookName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ToolStripMenuItem ChangeInfo;
        private System.Windows.Forms.ToolStripMenuItem MyBook;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonB;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem deleteAccount;
        private System.Windows.Forms.Panel panelPasswd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPasswd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelRe;
        private System.Windows.Forms.DataGridView dataGridViewReturn;
    }
}