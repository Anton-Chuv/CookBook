namespace CookBook {
    partial class AddDishForm {
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
            NameTextBox = new TextBox();
            CompositionTextBox = new TextBox();
            AddNameLbl = new Label();
            AddCompositionLbl = new Label();
            AddCancelBtn = new Button();
            AddSaveBtn = new Button();
            PictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 33);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(360, 23);
            NameTextBox.TabIndex = 0;
            // 
            // CompositionTextBox
            // 
            CompositionTextBox.Location = new Point(12, 83);
            CompositionTextBox.Multiline = true;
            CompositionTextBox.Name = "CompositionTextBox";
            CompositionTextBox.Size = new Size(254, 100);
            CompositionTextBox.TabIndex = 1;
            // 
            // AddNameLbl
            // 
            AddNameLbl.AutoSize = true;
            AddNameLbl.Font = new Font("Segoe UI", 12F);
            AddNameLbl.Location = new Point(12, 9);
            AddNameLbl.Name = "AddNameLbl";
            AddNameLbl.Size = new Size(81, 21);
            AddNameLbl.TabIndex = 2;
            AddNameLbl.Text = "Название:";
            // 
            // AddCompositionLbl
            // 
            AddCompositionLbl.AutoSize = true;
            AddCompositionLbl.Font = new Font("Segoe UI", 12F);
            AddCompositionLbl.Location = new Point(12, 59);
            AddCompositionLbl.Name = "AddCompositionLbl";
            AddCompositionLbl.Size = new Size(62, 21);
            AddCompositionLbl.TabIndex = 3;
            AddCompositionLbl.Text = "Состав:";
            // 
            // AddCancelBtn
            // 
            AddCancelBtn.Location = new Point(12, 189);
            AddCancelBtn.Name = "AddCancelBtn";
            AddCancelBtn.Size = new Size(75, 23);
            AddCancelBtn.TabIndex = 4;
            AddCancelBtn.Text = "Отмена";
            AddCancelBtn.UseVisualStyleBackColor = true;
            AddCancelBtn.Click += AddCancelBtn_Click;
            // 
            // AddSaveBtn
            // 
            AddSaveBtn.Location = new Point(297, 189);
            AddSaveBtn.Name = "AddSaveBtn";
            AddSaveBtn.Size = new Size(75, 23);
            AddSaveBtn.TabIndex = 5;
            AddSaveBtn.Text = "Сохранить";
            AddSaveBtn.UseVisualStyleBackColor = true;
            AddSaveBtn.Click += AddSaveBtn_Click;
            // 
            // PictureBox
            // 
            PictureBox.BackgroundImage = Properties.Resources._8680289_image_add_line_icon;
            PictureBox.BackgroundImageLayout = ImageLayout.Center;
            PictureBox.BorderStyle = BorderStyle.FixedSingle;
            PictureBox.Location = new Point(272, 83);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(100, 100);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox.TabIndex = 6;
            PictureBox.TabStop = false;
            PictureBox.DragDrop += PictureBox_DragDrop;
            PictureBox.DragEnter += PictureBox_DragEnter;
            // 
            // AddDishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 220);
            Controls.Add(PictureBox);
            Controls.Add(AddSaveBtn);
            Controls.Add(AddCancelBtn);
            Controls.Add(AddCompositionLbl);
            Controls.Add(AddNameLbl);
            Controls.Add(CompositionTextBox);
            Controls.Add(NameTextBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddDishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDishForm";
            Load += AddDishForm_Load;
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameTextBox;
        private TextBox CompositionTextBox;
        private Label AddNameLbl;
        private Label AddCompositionLbl;
        private Button AddCancelBtn;
        public Button AddSaveBtn;
        private PictureBox PictureBox;
    }
}