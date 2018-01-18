namespace Soundown.Forms.Controls
{
    partial class TrackControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trackPictureBox = new System.Windows.Forms.PictureBox();
            this.trackLabel = new System.Windows.Forms.Label();
            this.downloadButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.successPictureBox = new System.Windows.Forms.PictureBox();
            this.trackAuthorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // trackPictureBox
            // 
            this.trackPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trackPictureBox.InitialImage = null;
            this.trackPictureBox.Location = new System.Drawing.Point(5, 6);
            this.trackPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackPictureBox.Name = "trackPictureBox";
            this.trackPictureBox.Size = new System.Drawing.Size(67, 67);
            this.trackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackPictureBox.TabIndex = 0;
            this.trackPictureBox.TabStop = false;
            // 
            // trackLabel
            // 
            this.trackLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackLabel.Location = new System.Drawing.Point(76, 5);
            this.trackLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackLabel.Name = "trackLabel";
            this.trackLabel.Size = new System.Drawing.Size(248, 21);
            this.trackLabel.TabIndex = 1;
            this.trackLabel.Text = "track name";
            // 
            // downloadButton
            // 
            this.downloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadButton.Location = new System.Drawing.Point(327, 50);
            this.downloadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(90, 27);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Downloading";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.removeButton.Location = new System.Drawing.Point(263, 50);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(60, 27);
            this.removeButton.TabIndex = 3;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // successPictureBox
            // 
            this.successPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.successPictureBox.Location = new System.Drawing.Point(401, 33);
            this.successPictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.successPictureBox.Name = "successPictureBox";
            this.successPictureBox.Size = new System.Drawing.Size(16, 16);
            this.successPictureBox.TabIndex = 4;
            this.successPictureBox.TabStop = false;
            // 
            // trackAuthorLabel
            // 
            this.trackAuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackAuthorLabel.Location = new System.Drawing.Point(76, 30);
            this.trackAuthorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.trackAuthorLabel.Name = "trackAuthorLabel";
            this.trackAuthorLabel.Size = new System.Drawing.Size(228, 21);
            this.trackAuthorLabel.TabIndex = 5;
            this.trackAuthorLabel.Text = "track author";
            // 
            // TrackControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.successPictureBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.trackLabel);
            this.Controls.Add(this.trackPictureBox);
            this.Controls.Add(this.trackAuthorLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TrackControl";
            this.Size = new System.Drawing.Size(420, 81);
            ((System.ComponentModel.ISupportInitialize)(this.trackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.successPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox trackPictureBox;
        private System.Windows.Forms.Label trackLabel;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.PictureBox successPictureBox;
        private System.Windows.Forms.Label trackAuthorLabel;
    }
}
