namespace WindowsFormsApp1
{
    partial class 管理员工具
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(管理员工具));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.书籍管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewBook = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBook = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.usersManage = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.AllBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewAllUsers = new System.Windows.Forms.DataGridView();
            this.AllAdmins = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.书籍管理ToolStripMenuItem,
            this.usersManage});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 书籍管理ToolStripMenuItem
            // 
            this.书籍管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBook,
            this.deleteBook,
            this.updateBook});
            this.书籍管理ToolStripMenuItem.Name = "书籍管理ToolStripMenuItem";
            this.书籍管理ToolStripMenuItem.Size = new System.Drawing.Size(82, 25);
            this.书籍管理ToolStripMenuItem.Text = "书籍管理";
            // 
            // NewBook
            // 
            this.NewBook.Name = "NewBook";
            this.NewBook.Size = new System.Drawing.Size(146, 26);
            this.NewBook.Text = "新书入库";
            this.NewBook.Click += new System.EventHandler(this.新书入库ToolStripMenuItem_Click);
            // 
            // deleteBook
            // 
            this.deleteBook.Name = "deleteBook";
            this.deleteBook.Size = new System.Drawing.Size(146, 26);
            this.deleteBook.Text = "删除图书";
            this.deleteBook.Click += new System.EventHandler(this.deleteBook_Click);
            // 
            // updateBook
            // 
            this.updateBook.Name = "updateBook";
            this.updateBook.Size = new System.Drawing.Size(146, 26);
            this.updateBook.Text = "修改图书";
            this.updateBook.Click += new System.EventHandler(this.updateBook_Click);
            // 
            // usersManage
            // 
            this.usersManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsers,
            this.AllAdmins,
            this.AllBorrow});
            this.usersManage.Name = "usersManage";
            this.usersManage.Size = new System.Drawing.Size(82, 25);
            this.usersManage.Text = "用户管理";
            // 
            // allUsers
            // 
            this.allUsers.Name = "allUsers";
            this.allUsers.Size = new System.Drawing.Size(216, 26);
            this.allUsers.Text = "所有用户";
            this.allUsers.Click += new System.EventHandler(this.allUsers_Click);
            // 
            // AllBorrow
            // 
            this.AllBorrow.Name = "AllBorrow";
            this.AllBorrow.Size = new System.Drawing.Size(216, 26);
            this.AllBorrow.Text = "所有借阅";
            this.AllBorrow.Click += new System.EventHandler(this.AllBorrow_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewAllUsers
            // 
            this.dataGridViewAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllUsers.Location = new System.Drawing.Point(0, 153);
            this.dataGridViewAllUsers.Name = "dataGridViewAllUsers";
            this.dataGridViewAllUsers.RowTemplate.Height = 27;
            this.dataGridViewAllUsers.Size = new System.Drawing.Size(692, 297);
            this.dataGridViewAllUsers.TabIndex = 2;
            // 
            // AllAdmins
            // 
            this.AllAdmins.Name = "AllAdmins";
            this.AllAdmins.Size = new System.Drawing.Size(216, 26);
            this.AllAdmins.Text = "所有管理员";
            this.AllAdmins.Click += new System.EventHandler(this.AllAdmins_Click);
            // 
            // 管理员工具
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewAllUsers);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "管理员工具";
            this.Text = "admintool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 书籍管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewBook;
        private System.Windows.Forms.ToolStripMenuItem deleteBook;
        private System.Windows.Forms.ToolStripMenuItem updateBook;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usersManage;
        private System.Windows.Forms.ToolStripMenuItem allUsers;
        private System.Windows.Forms.DataGridView dataGridViewAllUsers;
        private System.Windows.Forms.ToolStripMenuItem AllBorrow;
        private System.Windows.Forms.ToolStripMenuItem AllAdmins;
    }
}