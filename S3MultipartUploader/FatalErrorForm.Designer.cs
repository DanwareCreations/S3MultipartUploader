﻿namespace S3MultipartUploader {
    partial class FatalErrorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.BtnSendReport = new System.Windows.Forms.Button();
            this.LblTop = new System.Windows.Forms.Label();
            this.LblFrom = new System.Windows.Forms.Label();
            this.TxtFrom = new System.Windows.Forms.TextBox();
            this.LblBody = new System.Windows.Forms.Label();
            this.SplitMain = new System.Windows.Forms.SplitContainer();
            this.TxtError = new System.Windows.Forms.TextBox();
            this.LblSendReport = new System.Windows.Forms.Label();
            this.ChkSendReport = new System.Windows.Forms.CheckBox();
            this.ToolTipMain = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).BeginInit();
            this.SplitMain.Panel1.SuspendLayout();
            this.SplitMain.Panel2.SuspendLayout();
            this.SplitMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnClose.Location = new System.Drawing.Point(320, 57);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 1;
            this.BtnClose.Text = "Close";
            this.ToolTipMain.SetToolTip(this.BtnClose, "Close and exit the application.");
            this.BtnClose.UseVisualStyleBackColor = true;
            // 
            // TxtBody
            // 
            this.TxtBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBody.Location = new System.Drawing.Point(44, 68);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtBody.Size = new System.Drawing.Size(336, 84);
            this.TxtBody.TabIndex = 6;
            this.TxtBody.Text = "Come on S3 Multipart Uploader team, get it together!";
            this.ToolTipMain.SetToolTip(this.TxtBody, "Optional.  Any additional details that you would like to provide.  For example, s" +
        "teps that you took to reach this error.");
            // 
            // BtnSendReport
            // 
            this.BtnSendReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSendReport.AutoSize = true;
            this.BtnSendReport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnSendReport.Location = new System.Drawing.Point(278, 158);
            this.BtnSendReport.Name = "BtnSendReport";
            this.BtnSendReport.Size = new System.Drawing.Size(102, 23);
            this.BtnSendReport.TabIndex = 7;
            this.BtnSendReport.Text = "Send Error Report";
            this.ToolTipMain.SetToolTip(this.BtnSendReport, "Send the provided error details and custom message to support.");
            this.BtnSendReport.UseVisualStyleBackColor = true;
            this.BtnSendReport.Click += new System.EventHandler(this.BtnSendReport_Click);
            // 
            // LblTop
            // 
            this.LblTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTop.Location = new System.Drawing.Point(12, 9);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(383, 45);
            this.LblTop.TabIndex = 0;
            this.LblTop.Text = "Well this is embarassing...  Try restarting S3 Multipart Uploader, and please sen" +
    "d us an error report so that we can prevent future issues like this from occurri" +
    "ng.  Full error details are below.";
            // 
            // LblFrom
            // 
            this.LblFrom.AutoSize = true;
            this.LblFrom.Location = new System.Drawing.Point(5, 45);
            this.LblFrom.Name = "LblFrom";
            this.LblFrom.Size = new System.Drawing.Size(33, 13);
            this.LblFrom.TabIndex = 3;
            this.LblFrom.Text = "From:";
            this.ToolTipMain.SetToolTip(this.LblFrom, "Optional.  The Email address at which you would like us to get back to you about " +
        "this error.");
            // 
            // TxtFrom
            // 
            this.TxtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFrom.Location = new System.Drawing.Point(44, 42);
            this.TxtFrom.Name = "TxtFrom";
            this.TxtFrom.Size = new System.Drawing.Size(336, 20);
            this.TxtFrom.TabIndex = 4;
            this.ToolTipMain.SetToolTip(this.TxtFrom, "Optional.  The Email address at which you would like us to get back to you about " +
        "this error.\r\n");
            // 
            // LblBody
            // 
            this.LblBody.AutoSize = true;
            this.LblBody.Location = new System.Drawing.Point(4, 71);
            this.LblBody.Name = "LblBody";
            this.LblBody.Size = new System.Drawing.Size(34, 13);
            this.LblBody.TabIndex = 5;
            this.LblBody.Text = "Body:";
            this.ToolTipMain.SetToolTip(this.LblBody, "Optional.  Any additional details that you would like to provide.  For example, s" +
        "teps that you took to reach this error.");
            // 
            // SplitMain
            // 
            this.SplitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitMain.Location = new System.Drawing.Point(12, 86);
            this.SplitMain.Name = "SplitMain";
            this.SplitMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitMain.Panel1
            // 
            this.SplitMain.Panel1.Controls.Add(this.TxtError);
            // 
            // SplitMain.Panel2
            // 
            this.SplitMain.Panel2.Controls.Add(this.LblSendReport);
            this.SplitMain.Panel2.Controls.Add(this.LblBody);
            this.SplitMain.Panel2.Controls.Add(this.TxtBody);
            this.SplitMain.Panel2.Controls.Add(this.BtnSendReport);
            this.SplitMain.Panel2.Controls.Add(this.LblFrom);
            this.SplitMain.Panel2.Controls.Add(this.TxtFrom);
            this.SplitMain.Panel2.Enabled = false;
            this.SplitMain.Size = new System.Drawing.Size(383, 348);
            this.SplitMain.SplitterDistance = 160;
            this.SplitMain.TabIndex = 0;
            this.SplitMain.TabStop = false;
            // 
            // TxtError
            // 
            this.TxtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtError.Location = new System.Drawing.Point(0, 0);
            this.TxtError.Multiline = true;
            this.TxtError.Name = "TxtError";
            this.TxtError.ReadOnly = true;
            this.TxtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtError.Size = new System.Drawing.Size(383, 160);
            this.TxtError.TabIndex = 0;
            this.TxtError.TabStop = false;
            this.ToolTipMain.SetToolTip(this.TxtError, "Details of the Exception that crashed S3 Multipart Uploader.");
            this.TxtError.WordWrap = false;
            // 
            // LblSendReport
            // 
            this.LblSendReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblSendReport.Location = new System.Drawing.Point(3, 6);
            this.LblSendReport.Name = "LblSendReport";
            this.LblSendReport.Size = new System.Drawing.Size(373, 33);
            this.LblSendReport.TabIndex = 0;
            this.LblSendReport.Text = "You may include additional details in the \"Body\" area.  If you would like us to g" +
    "et back to you, please include your Email address in the \"From\" box.";
            // 
            // ChkSendReport
            // 
            this.ChkSendReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChkSendReport.AutoSize = true;
            this.ChkSendReport.Location = new System.Drawing.Point(182, 61);
            this.ChkSendReport.Name = "ChkSendReport";
            this.ChkSendReport.Size = new System.Drawing.Size(132, 17);
            this.ChkSendReport.TabIndex = 0;
            this.ChkSendReport.Text = "Send an Error Report?";
            this.ToolTipMain.SetToolTip(this.ChkSendReport, "Send us an error report so we can prevent future issues like this from occurring!" +
        "");
            this.ChkSendReport.UseVisualStyleBackColor = true;
            this.ChkSendReport.CheckedChanged += new System.EventHandler(this.ChkSendReport_CheckedChanged);
            // 
            // FatalErrorForm
            // 
            this.AcceptButton = this.BtnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnClose;
            this.ClientSize = new System.Drawing.Size(407, 446);
            this.Controls.Add(this.ChkSendReport);
            this.Controls.Add(this.SplitMain);
            this.Controls.Add(this.LblTop);
            this.Controls.Add(this.BtnClose);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(260, 450);
            this.Name = "FatalErrorForm";
            this.Text = "A Fatal Error Occurred";
            this.SplitMain.Panel1.ResumeLayout(false);
            this.SplitMain.Panel1.PerformLayout();
            this.SplitMain.Panel2.ResumeLayout(false);
            this.SplitMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitMain)).EndInit();
            this.SplitMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.Button BtnSendReport;
        private System.Windows.Forms.Label LblTop;
        private System.Windows.Forms.Label LblFrom;
        private System.Windows.Forms.TextBox TxtFrom;
        private System.Windows.Forms.Label LblBody;
        private System.Windows.Forms.SplitContainer SplitMain;
        private System.Windows.Forms.TextBox TxtError;
        private System.Windows.Forms.Label LblSendReport;
        private System.Windows.Forms.CheckBox ChkSendReport;
        private System.Windows.Forms.ToolTip ToolTipMain;
    }
}