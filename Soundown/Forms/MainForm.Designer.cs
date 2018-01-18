namespace Soundown.Forms
{
    partial class MainForm
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
            this.mainFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.downloadAllButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.changeDownloadDirButton = new System.Windows.Forms.Button();
            this.processButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainFlowPanel
            // 
            this.mainFlowPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainFlowPanel.AutoScroll = true;
            this.mainFlowPanel.Location = new System.Drawing.Point(14, 89);
            this.mainFlowPanel.Name = "mainFlowPanel";
            this.mainFlowPanel.Size = new System.Drawing.Size(608, 410);
            this.mainFlowPanel.TabIndex = 0;
            // 
            // urlTextBox
            // 
            this.urlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlTextBox.Location = new System.Drawing.Point(12, 14);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(610, 23);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UrlTextBox_KeyPress);
            // 
            // downloadAllButton
            // 
            this.downloadAllButton.Location = new System.Drawing.Point(128, 43);
            this.downloadAllButton.Name = "downloadAllButton";
            this.downloadAllButton.Size = new System.Drawing.Size(110, 40);
            this.downloadAllButton.TabIndex = 0;
            this.downloadAllButton.Text = "Download All";
            this.downloadAllButton.UseVisualStyleBackColor = true;
            this.downloadAllButton.Click += new System.EventHandler(this.downloadAllButton_Click);
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(244, 43);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(110, 40);
            this.removeAllButton.TabIndex = 2;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            this.removeAllButton.Click += new System.EventHandler(this.removeAllButton_Click);
            // 
            // changeDownloadDirButton
            // 
            this.changeDownloadDirButton.Location = new System.Drawing.Point(360, 43);
            this.changeDownloadDirButton.Name = "changeDownloadDirButton";
            this.changeDownloadDirButton.Size = new System.Drawing.Size(262, 40);
            this.changeDownloadDirButton.TabIndex = 3;
            this.changeDownloadDirButton.Text = "Change Download Directory";
            this.changeDownloadDirButton.UseVisualStyleBackColor = true;
            this.changeDownloadDirButton.Click += new System.EventHandler(this.changeDownloadDirButton_Click);
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(12, 43);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(110, 40);
            this.processButton.TabIndex = 4;
            this.processButton.Text = "Process Url";
            this.processButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 511);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.changeDownloadDirButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.downloadAllButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.mainFlowPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(650, 550);
            this.Name = "MainForm";
            this.Text = "Soundown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel mainFlowPanel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button downloadAllButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button changeDownloadDirButton;
        private System.Windows.Forms.Button processButton;
    }
}

