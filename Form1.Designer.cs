namespace ImageStore
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picImage = new PictureBox();
            txtImageName = new TextBox();
            lblResult = new Label();
            btnSelectImage = new Button();
            btnRecoverImage = new Button();
            btnInsertImage = new Button();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(12, 12);
            picImage.Name = "picImage";
            picImage.Size = new Size(567, 290);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // txtImageName
            // 
            txtImageName.Enabled = false;
            txtImageName.Location = new Point(12, 308);
            txtImageName.Name = "txtImageName";
            txtImageName.Size = new Size(567, 23);
            txtImageName.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(12, 334);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(776, 107);
            lblResult.TabIndex = 2;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSelectImage
            // 
            btnSelectImage.Location = new Point(585, 12);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(203, 58);
            btnSelectImage.TabIndex = 3;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // btnRecoverImage
            // 
            btnRecoverImage.Location = new Point(585, 273);
            btnRecoverImage.Name = "btnRecoverImage";
            btnRecoverImage.Size = new Size(203, 58);
            btnRecoverImage.TabIndex = 4;
            btnRecoverImage.Text = "Recover Image";
            btnRecoverImage.UseVisualStyleBackColor = true;
            // 
            // btnInsertImage
            // 
            btnInsertImage.Enabled = false;
            btnInsertImage.Location = new Point(585, 76);
            btnInsertImage.Name = "btnInsertImage";
            btnInsertImage.Size = new Size(203, 58);
            btnInsertImage.TabIndex = 5;
            btnInsertImage.Text = "Insert Image";
            btnInsertImage.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInsertImage);
            Controls.Add(btnRecoverImage);
            Controls.Add(btnSelectImage);
            Controls.Add(lblResult);
            Controls.Add(txtImageName);
            Controls.Add(picImage);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insert image in database";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picImage;
        private TextBox txtImageName;
        private Label lblResult;
        private Button btnSelectImage;
        private Button btnRecoverImage;
        private Button btnInsertImage;
    }
}
