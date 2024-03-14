namespace Explorer_UI
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btSelect_file = new System.Windows.Forms.Button();
            this.btSelect_folder = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btCut = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSelect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Path";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(170, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(551, 22);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(170, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(551, 22);
            this.textBox3.TabIndex = 5;
            // 
            // btSelect_file
            // 
            this.btSelect_file.Location = new System.Drawing.Point(804, 34);
            this.btSelect_file.Name = "btSelect_file";
            this.btSelect_file.Size = new System.Drawing.Size(107, 47);
            this.btSelect_file.TabIndex = 6;
            this.btSelect_file.Text = "select file";
            this.btSelect_file.UseVisualStyleBackColor = true;
            this.btSelect_file.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSelect_folder
            // 
            this.btSelect_folder.Location = new System.Drawing.Point(943, 34);
            this.btSelect_folder.Name = "btSelect_folder";
            this.btSelect_folder.Size = new System.Drawing.Size(107, 47);
            this.btSelect_folder.TabIndex = 7;
            this.btSelect_folder.Text = "select folder";
            this.btSelect_folder.UseVisualStyleBackColor = true;
            this.btSelect_folder.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCopy
            // 
            this.btCopy.Location = new System.Drawing.Point(170, 286);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(150, 48);
            this.btCopy.TabIndex = 8;
            this.btCopy.Text = "copy";
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btCut
            // 
            this.btCut.Location = new System.Drawing.Point(375, 286);
            this.btCut.Name = "btCut";
            this.btCut.Size = new System.Drawing.Size(150, 48);
            this.btCut.TabIndex = 9;
            this.btCut.Text = "cut";
            this.btCut.UseVisualStyleBackColor = true;
            this.btCut.Click += new System.EventHandler(this.button4_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(571, 286);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(150, 48);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.button5_Click);
            // 
            // btSelect
            // 
            this.btSelect.Location = new System.Drawing.Point(804, 165);
            this.btSelect.Name = "btSelect";
            this.btSelect.Size = new System.Drawing.Size(107, 47);
            this.btSelect.TabIndex = 11;
            this.btSelect.Text = "select ";
            this.btSelect.UseVisualStyleBackColor = true;
            this.btSelect.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 608);
            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCut);
            this.Controls.Add(this.btCopy);
            this.Controls.Add(this.btSelect_folder);
            this.Controls.Add(this.btSelect_file);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Form3";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btSelect_file;
        private System.Windows.Forms.Button btSelect_folder;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btCut;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSelect;
    }
}