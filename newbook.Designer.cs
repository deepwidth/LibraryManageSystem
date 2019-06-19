namespace WindowsFormsApp1
{
    partial class newbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newbook));
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelauthor = new System.Windows.Forms.Label();
            this.labelscore = new System.Windows.Forms.Label();
            this.labelpress = new System.Windows.Forms.Label();
            this.labelprice = new System.Windows.Forms.Label();
            this.labelamount = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxScore = new System.Windows.Forms.TextBox();
            this.textBoxPress = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOK.Location = new System.Drawing.Point(355, 392);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 32);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(240, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(89, 19);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Bookname";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(377, 33);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(294, 25);
            this.textBoxName.TabIndex = 2;
            // 
            // labelauthor
            // 
            this.labelauthor.AutoSize = true;
            this.labelauthor.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelauthor.Location = new System.Drawing.Point(256, 88);
            this.labelauthor.Name = "labelauthor";
            this.labelauthor.Size = new System.Drawing.Size(69, 19);
            this.labelauthor.TabIndex = 3;
            this.labelauthor.Text = "Author";
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelscore.Location = new System.Drawing.Point(257, 145);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(59, 19);
            this.labelscore.TabIndex = 4;
            this.labelscore.Text = "Score";
            // 
            // labelpress
            // 
            this.labelpress.AutoSize = true;
            this.labelpress.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelpress.Location = new System.Drawing.Point(257, 198);
            this.labelpress.Name = "labelpress";
            this.labelpress.Size = new System.Drawing.Size(59, 19);
            this.labelpress.TabIndex = 5;
            this.labelpress.Text = "Press";
            // 
            // labelprice
            // 
            this.labelprice.AutoSize = true;
            this.labelprice.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelprice.Location = new System.Drawing.Point(257, 255);
            this.labelprice.Name = "labelprice";
            this.labelprice.Size = new System.Drawing.Size(59, 19);
            this.labelprice.TabIndex = 6;
            this.labelprice.Text = "Price";
            // 
            // labelamount
            // 
            this.labelamount.AutoSize = true;
            this.labelamount.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelamount.Location = new System.Drawing.Point(241, 309);
            this.labelamount.Name = "labelamount";
            this.labelamount.Size = new System.Drawing.Size(69, 19);
            this.labelamount.TabIndex = 7;
            this.labelamount.Text = "Amount";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(377, 82);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(294, 25);
            this.textBoxAuthor.TabIndex = 8;
            // 
            // textBoxScore
            // 
            this.textBoxScore.Location = new System.Drawing.Point(377, 144);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.Size = new System.Drawing.Size(294, 25);
            this.textBoxScore.TabIndex = 9;
            // 
            // textBoxPress
            // 
            this.textBoxPress.Location = new System.Drawing.Point(377, 198);
            this.textBoxPress.Name = "textBoxPress";
            this.textBoxPress.Size = new System.Drawing.Size(294, 25);
            this.textBoxPress.TabIndex = 10;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(377, 255);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(294, 25);
            this.textBoxPrice.TabIndex = 11;
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(377, 309);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(294, 25);
            this.textBoxAmount.TabIndex = 12;
            // 
            // newbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxPress);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.labelamount);
            this.Controls.Add(this.labelprice);
            this.Controls.Add(this.labelpress);
            this.Controls.Add(this.labelscore);
            this.Controls.Add(this.labelauthor);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "newbook";
            this.Text = "newbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelauthor;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Label labelpress;
        private System.Windows.Forms.Label labelprice;
        private System.Windows.Forms.Label labelamount;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.TextBox textBoxScore;
        private System.Windows.Forms.TextBox textBoxPress;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxAmount;
    }
}