namespace WindowsFormsApp1
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
            this.btnRead = new System.Windows.Forms.Button();
            this.filePath = new System.Windows.Forms.TextBox();
            this.fileList = new System.Windows.Forms.ListBox();
            this.btnUpdatePath = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.lblExtensions = new System.Windows.Forms.Label();
            this.chkExtensionRAR = new System.Windows.Forms.CheckBox();
            this.chkExtensionZIP = new System.Windows.Forms.CheckBox();
            this.btnUpdateExtension = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(462, 86);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 20);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(80, 32);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(376, 20);
            this.filePath.TabIndex = 1;
            this.filePath.TextChanged += new System.EventHandler(this.filePath_TextChanged);
            // 
            // fileList
            // 
            this.fileList.FormattingEnabled = true;
            this.fileList.Location = new System.Drawing.Point(80, 86);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(376, 95);
            this.fileList.TabIndex = 2;
            this.fileList.SelectedValueChanged += new System.EventHandler(this.fileList_SelectedValueChanged);
            // 
            // btnUpdatePath
            // 
            this.btnUpdatePath.Enabled = false;
            this.btnUpdatePath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdatePath.Location = new System.Drawing.Point(462, 32);
            this.btnUpdatePath.Name = "btnUpdatePath";
            this.btnUpdatePath.Size = new System.Drawing.Size(75, 20);
            this.btnUpdatePath.TabIndex = 3;
            this.btnUpdatePath.Text = "Update";
            this.btnUpdatePath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdatePath.UseVisualStyleBackColor = true;
            this.btnUpdatePath.Click += new System.EventHandler(this.btnUpdatePath_Click);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(12, 32);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 4;
            this.lblPath.Text = "Path:";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Location = new System.Drawing.Point(13, 86);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(31, 13);
            this.lblFiles.TabIndex = 5;
            this.lblFiles.Text = "Files:";
            // 
            // lblExtensions
            // 
            this.lblExtensions.AutoSize = true;
            this.lblExtensions.Location = new System.Drawing.Point(12, 59);
            this.lblExtensions.Name = "lblExtensions";
            this.lblExtensions.Size = new System.Drawing.Size(67, 13);
            this.lblExtensions.TabIndex = 6;
            this.lblExtensions.Text = "Extension(s):";
            // 
            // chkExtensionRAR
            // 
            this.chkExtensionRAR.AutoSize = true;
            this.chkExtensionRAR.Location = new System.Drawing.Point(80, 59);
            this.chkExtensionRAR.Name = "chkExtensionRAR";
            this.chkExtensionRAR.Size = new System.Drawing.Size(52, 17);
            this.chkExtensionRAR.TabIndex = 7;
            this.chkExtensionRAR.Text = ".RAR";
            this.chkExtensionRAR.UseVisualStyleBackColor = true;
            this.chkExtensionRAR.CheckedChanged += new System.EventHandler(this.chkExtension_CheckedChanged);
            // 
            // chkExtensionZIP
            // 
            this.chkExtensionZIP.AutoSize = true;
            this.chkExtensionZIP.Location = new System.Drawing.Point(138, 59);
            this.chkExtensionZIP.Name = "chkExtensionZIP";
            this.chkExtensionZIP.Size = new System.Drawing.Size(46, 17);
            this.chkExtensionZIP.TabIndex = 8;
            this.chkExtensionZIP.Text = ".ZIP";
            this.chkExtensionZIP.UseVisualStyleBackColor = true;
            this.chkExtensionZIP.CheckedChanged += new System.EventHandler(this.chkExtension_CheckedChanged);
            // 
            // btnUpdateExtension
            // 
            this.btnUpdateExtension.Enabled = false;
            this.btnUpdateExtension.Location = new System.Drawing.Point(462, 60);
            this.btnUpdateExtension.Name = "btnUpdateExtension";
            this.btnUpdateExtension.Size = new System.Drawing.Size(75, 20);
            this.btnUpdateExtension.TabIndex = 9;
            this.btnUpdateExtension.Text = "Update";
            this.btnUpdateExtension.UseVisualStyleBackColor = true;
            this.btnUpdateExtension.Click += new System.EventHandler(this.btnUpdateExtension_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUpdateExtension);
            this.Controls.Add(this.chkExtensionZIP);
            this.Controls.Add(this.chkExtensionRAR);
            this.Controls.Add(this.lblExtensions);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.btnUpdatePath);
            this.Controls.Add(this.fileList);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnUpdatePath;
        private System.Windows.Forms.TextBox filePath;
        private System.Windows.Forms.ListBox fileList;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Label lblExtensions;
        private System.Windows.Forms.CheckBox chkExtensionRAR;
        private System.Windows.Forms.CheckBox chkExtensionZIP;
        private System.Windows.Forms.Button btnUpdateExtension;
        private System.Windows.Forms.TextBox textBox1;
    }
}

