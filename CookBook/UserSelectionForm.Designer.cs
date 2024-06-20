namespace CookBook {
    partial class UserSelectionForm {
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
            GuestBtn = new Button();
            ChiefBtn = new Button();
            CookBtn = new Button();
            SuspendLayout();
            // 
            // GuestBtn
            // 
            GuestBtn.Location = new Point(30, 12);
            GuestBtn.Name = "GuestBtn";
            GuestBtn.Size = new Size(75, 23);
            GuestBtn.TabIndex = 0;
            GuestBtn.Text = "Гость";
            GuestBtn.UseVisualStyleBackColor = true;
            GuestBtn.Click += GuestBtn_Click;
            // 
            // ChiefBtn
            // 
            ChiefBtn.Location = new Point(30, 70);
            ChiefBtn.Name = "ChiefBtn";
            ChiefBtn.Size = new Size(75, 23);
            ChiefBtn.TabIndex = 2;
            ChiefBtn.Text = "Шеф";
            ChiefBtn.UseVisualStyleBackColor = true;
            ChiefBtn.Click += ChiefBtn_Click;
            // 
            // CookBtn
            // 
            CookBtn.Location = new Point(30, 41);
            CookBtn.Name = "CookBtn";
            CookBtn.Size = new Size(75, 23);
            CookBtn.TabIndex = 1;
            CookBtn.Text = "Повар";
            CookBtn.UseVisualStyleBackColor = true;
            CookBtn.Visible = false;
            CookBtn.Click += CookBtn_Click;
            // 
            // UserSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(134, 111);
            Controls.Add(ChiefBtn);
            Controls.Add(CookBtn);
            Controls.Add(GuestBtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UserSelectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private Button GuestBtn;
        private Button ChiefBtn;
        private Button CookBtn;
    }
}