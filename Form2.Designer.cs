namespace ImageStore
{
    partial class Form2
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
            picImage = new PictureBox();
            btnDeleteImage = new Button();
            btnSaveImage = new Button();
            btnExit = new Button();
            dgImageList = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            lblResult = new Label();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgImageList).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.BorderStyle = BorderStyle.FixedSingle;
            picImage.Location = new Point(12, 12);
            picImage.Name = "picImage";
            picImage.Size = new Size(567, 290);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 1;
            picImage.TabStop = false;
            // 
            // btnDeleteImage
            // 
            btnDeleteImage.Enabled = false;
            btnDeleteImage.Location = new Point(376, 308);
            btnDeleteImage.Name = "btnDeleteImage";
            btnDeleteImage.Size = new Size(203, 58);
            btnDeleteImage.TabIndex = 4;
            btnDeleteImage.Text = "Delete";
            btnDeleteImage.UseVisualStyleBackColor = true;
            // 
            // btnSaveImage
            // 
            btnSaveImage.Enabled = false;
            btnSaveImage.Location = new Point(376, 372);
            btnSaveImage.Name = "btnSaveImage";
            btnSaveImage.Size = new Size(203, 58);
            btnSaveImage.TabIndex = 5;
            btnSaveImage.Text = "Save";
            btnSaveImage.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(376, 436);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 58);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgImageList
            // 
            dgImageList.AllowUserToAddRows = false;
            dgImageList.AllowUserToDeleteRows = false;
            dgImageList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgImageList.BackgroundColor = SystemColors.Control;
            dgImageList.BorderStyle = BorderStyle.None;
            dgImageList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgImageList.ColumnHeadersVisible = false;
            dgImageList.Columns.AddRange(new DataGridViewColumn[] { id, name });
            dgImageList.Location = new Point(12, 308);
            dgImageList.MultiSelect = false;
            dgImageList.Name = "dgImageList";
            dgImageList.ReadOnly = true;
            dgImageList.RowHeadersVisible = false;
            dgImageList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgImageList.Size = new Size(358, 186);
            dgImageList.TabIndex = 7;
            dgImageList.SelectionChanged += dgImageList_SelectionChanged;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            // 
            // name
            // 
            name.HeaderText = "NAME";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(23, 23);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(540, 269);
            lblResult.TabIndex = 8;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 506);
            Controls.Add(lblResult);
            Controls.Add(dgImageList);
            Controls.Add(btnExit);
            Controls.Add(btnSaveImage);
            Controls.Add(btnDeleteImage);
            Controls.Add(picImage);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recover Image";
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgImageList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImage;
        private Button btnDeleteImage;
        private Button btnSaveImage;
        private Button btnExit;
        private DataGridView dgImageList;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private Label lblResult;
    }
}