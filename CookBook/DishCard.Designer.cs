namespace CookBook {
    partial class DishCard {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            DishNameLbl = new Label();
            DishPreviewBox = new PictureBox();
            DishCompositionLbl = new Label();
            BtnsLayoutPanel = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)DishPreviewBox).BeginInit();
            SuspendLayout();
            // 
            // DishNameLbl
            // 
            DishNameLbl.AutoSize = true;
            DishNameLbl.Font = new Font("Segoe UI", 14F);
            DishNameLbl.Location = new Point(106, 0);
            DishNameLbl.Name = "DishNameLbl";
            DishNameLbl.Size = new Size(95, 25);
            DishNameLbl.TabIndex = 0;
            DishNameLbl.Text = "Название";
            // 
            // DishPreviewBox
            // 
            DishPreviewBox.Dock = DockStyle.Left;
            DishPreviewBox.Image = Properties.Resources._3671795_food_location_icon;
            DishPreviewBox.Location = new Point(0, 0);
            DishPreviewBox.Name = "DishPreviewBox";
            DishPreviewBox.Size = new Size(100, 100);
            DishPreviewBox.SizeMode = PictureBoxSizeMode.CenterImage;
            DishPreviewBox.TabIndex = 1;
            DishPreviewBox.TabStop = false;
            // 
            // DishCompositionLbl
            // 
            DishCompositionLbl.AutoSize = true;
            DishCompositionLbl.Location = new Point(106, 25);
            DishCompositionLbl.Name = "DishCompositionLbl";
            DishCompositionLbl.Size = new Size(45, 15);
            DishCompositionLbl.TabIndex = 2;
            DishCompositionLbl.Text = "Состав";
            // 
            // BtnsLayoutPanel
            // 
            BtnsLayoutPanel.Location = new Point(295, 3);
            BtnsLayoutPanel.Name = "BtnsLayoutPanel";
            BtnsLayoutPanel.Size = new Size(52, 94);
            BtnsLayoutPanel.TabIndex = 3;
            // 
            // DishCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(BtnsLayoutPanel);
            Controls.Add(DishCompositionLbl);
            Controls.Add(DishPreviewBox);
            Controls.Add(DishNameLbl);
            Name = "DishCard";
            Size = new Size(350, 100);
            Load += DishCard_Load;
            ((System.ComponentModel.ISupportInitialize)DishPreviewBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DishNameLbl;
        private PictureBox DishPreviewBox;
        private Label DishCompositionLbl;
        private FlowLayoutPanel BtnsLayoutPanel;
    }
}
