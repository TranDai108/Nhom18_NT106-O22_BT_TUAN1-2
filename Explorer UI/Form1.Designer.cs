namespace Explorer_UI
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
            this.btBack = new System.Windows.Forms.Button();
            this.btForward = new System.Windows.Forms.Button();
            this.btOpen = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(12, 15);
            this.btBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(50, 27);
            this.btBack.TabIndex = 0;
            this.btBack.Text = "<<";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // btForward
            // 
            this.btForward.Location = new System.Drawing.Point(67, 15);
            this.btForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btForward.Name = "btForward";
            this.btForward.Size = new System.Drawing.Size(50, 27);
            this.btForward.TabIndex = 0;
            this.btForward.Text = ">>";
            this.btForward.UseVisualStyleBackColor = true;
            this.btForward.Click += new System.EventHandler(this.btForward_Click);
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(645, 15);
            this.btOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(56, 27);
            this.btOpen.TabIndex = 0;
            this.btOpen.Text = "Open";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(122, 18);
            this.tbPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(517, 22);
            this.tbPath.TabIndex = 1;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(16, 52);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(685, 291);
            this.webBrowser1.TabIndex = 2;
            // 
            // btMenu
            // 
            this.btMenu.Location = new System.Drawing.Point(122, 348);
            this.btMenu.Name = "btMenu";
            this.btMenu.Size = new System.Drawing.Size(75, 23);
            this.btMenu.TabIndex = 3;
            this.btMenu.Text = "Menu";
            this.btMenu.UseVisualStyleBackColor = true;
            this.btMenu.Click += new System.EventHandler(this.btMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 372);
            this.Controls.Add(this.btMenu);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.btForward);
            this.Controls.Add(this.btBack);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Explorer UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btForward;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btMenu;
    }
}

