namespace EroMeWebScrapper
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
            this.txtURL = new System.Windows.Forms.TextBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDownloadStatus = new System.Windows.Forms.Label();
            this.lbDownloadPath = new System.Windows.Forms.Label();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.TxtDownloadStatus = new System.Windows.Forms.Label();
            this.LinkList = new System.Windows.Forms.CheckedListBox();
            this.LinkAddBtn = new System.Windows.Forms.Button();
            this.BtnSelectAll = new System.Windows.Forms.Button();
            this.BtnDeselectAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(336, 9);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(299, 20);
            this.txtURL.TabIndex = 0;
            this.txtURL.Text = "Enter URL";
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(664, 421);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(84, 23);
            this.BtnSubmit.TabIndex = 1;
            this.BtnSubmit.Text = "Start";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL";
            // 
            // lbDownloadStatus
            // 
            this.lbDownloadStatus.AutoSize = true;
            this.lbDownloadStatus.Location = new System.Drawing.Point(231, 469);
            this.lbDownloadStatus.Name = "lbDownloadStatus";
            this.lbDownloadStatus.Size = new System.Drawing.Size(0, 13);
            this.lbDownloadStatus.TabIndex = 3;
            this.lbDownloadStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbDownloadStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbDownloadPath
            // 
            this.lbDownloadPath.AutoSize = true;
            this.lbDownloadPath.Location = new System.Drawing.Point(229, 35);
            this.lbDownloadPath.Name = "lbDownloadPath";
            this.lbDownloadPath.Size = new System.Drawing.Size(80, 13);
            this.lbDownloadPath.TabIndex = 4;
            this.lbDownloadPath.Text = "Download Path";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(336, 35);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(299, 20);
            this.tbFilePath.TabIndex = 5;
            this.tbFilePath.Text = "Enter where you want to save files";
            this.tbFilePath.TextChanged += new System.EventHandler(this.tbFilePath_TextChanged);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(641, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(84, 23);
            this.btnBrowse.TabIndex = 6;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // TxtDownloadStatus
            // 
            this.TxtDownloadStatus.AutoSize = true;
            this.TxtDownloadStatus.Location = new System.Drawing.Point(336, 62);
            this.TxtDownloadStatus.Name = "TxtDownloadStatus";
            this.TxtDownloadStatus.Size = new System.Drawing.Size(0, 13);
            this.TxtDownloadStatus.TabIndex = 7;
            // 
            // LinkList
            // 
            this.LinkList.FormattingEnabled = true;
            this.LinkList.Location = new System.Drawing.Point(234, 111);
            this.LinkList.Name = "LinkList";
            this.LinkList.Size = new System.Drawing.Size(514, 304);
            this.LinkList.TabIndex = 8;
            // 
            // LinkAddBtn
            // 
            this.LinkAddBtn.Location = new System.Drawing.Point(642, 6);
            this.LinkAddBtn.Name = "LinkAddBtn";
            this.LinkAddBtn.Size = new System.Drawing.Size(83, 23);
            this.LinkAddBtn.TabIndex = 9;
            this.LinkAddBtn.Text = "Add";
            this.LinkAddBtn.UseVisualStyleBackColor = true;
            this.LinkAddBtn.Click += new System.EventHandler(this.LinkAddBtn_Click);
            // 
            // BtnSelectAll
            // 
            this.BtnSelectAll.Location = new System.Drawing.Point(234, 421);
            this.BtnSelectAll.Name = "BtnSelectAll";
            this.BtnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.BtnSelectAll.TabIndex = 10;
            this.BtnSelectAll.Text = "Select All";
            this.BtnSelectAll.UseVisualStyleBackColor = true;
            this.BtnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // BtnDeselectAll
            // 
            this.BtnDeselectAll.Location = new System.Drawing.Point(328, 421);
            this.BtnDeselectAll.Name = "BtnDeselectAll";
            this.BtnDeselectAll.Size = new System.Drawing.Size(75, 23);
            this.BtnDeselectAll.TabIndex = 11;
            this.BtnDeselectAll.Text = "DeselectAll";
            this.BtnDeselectAll.UseVisualStyleBackColor = true;
            this.BtnDeselectAll.Click += new System.EventHandler(this.BtnDeselectAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 509);
            this.Controls.Add(this.BtnDeselectAll);
            this.Controls.Add(this.BtnSelectAll);
            this.Controls.Add(this.LinkAddBtn);
            this.Controls.Add(this.LinkList);
            this.Controls.Add(this.TxtDownloadStatus);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.lbDownloadPath);
            this.Controls.Add(this.lbDownloadStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.txtURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDownloadStatus;
        private System.Windows.Forms.Label lbDownloadPath;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label TxtDownloadStatus;
        private System.Windows.Forms.CheckedListBox LinkList;
        private System.Windows.Forms.Button LinkAddBtn;
        private System.Windows.Forms.Button BtnSelectAll;
        private System.Windows.Forms.Button BtnDeselectAll;
    }
}

