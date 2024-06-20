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
            DishPreviewBox = new PictureBox();
            BtnsLayoutPanel = new FlowLayoutPanel();
            DishCompositionRichTextBox = new RichTextBox();
            DishNameLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)DishPreviewBox).BeginInit();
            SuspendLayout();
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
            // BtnsLayoutPanel
            // 
            BtnsLayoutPanel.Location = new Point(295, 3);
            BtnsLayoutPanel.Name = "BtnsLayoutPanel";
            BtnsLayoutPanel.Size = new Size(52, 94);
            BtnsLayoutPanel.TabIndex = 3;
            // 
            // DishCompositionRichTextBox
            // 
            DishCompositionRichTextBox.BackColor = SystemColors.Control;
            DishCompositionRichTextBox.BorderStyle = BorderStyle.None;
            DishCompositionRichTextBox.Location = new Point(106, 27);
            DishCompositionRichTextBox.Name = "DishCompositionRichTextBox";
            DishCompositionRichTextBox.ReadOnly = true;
            DishCompositionRichTextBox.ScrollBars = RichTextBoxScrollBars.Vertical;
            DishCompositionRichTextBox.Size = new Size(183, 70);
            DishCompositionRichTextBox.TabIndex = 6;
            DishCompositionRichTextBox.TabStop = false;
            DishCompositionRichTextBox.Text = "Состав";
            // 
            // DishNameLbl
            // 
            DishNameLbl.Font = new Font("Segoe UI", 12F, FontStyle.Underline, GraphicsUnit.Point, 204);
            DishNameLbl.Location = new Point(103, 3);
            DishNameLbl.Margin = new Padding(0, 0, 3, 0);
            DishNameLbl.Name = "DishNameLbl";
            DishNameLbl.Size = new Size(186, 21);
            DishNameLbl.TabIndex = 7;
            DishNameLbl.Text = "Название";
            // 
            // DishCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(DishNameLbl);
            Controls.Add(DishCompositionRichTextBox);
            Controls.Add(BtnsLayoutPanel);
            Controls.Add(DishPreviewBox);
            Name = "DishCard";
            Size = new Size(350, 100);
            Load += DishCard_Load;
            ((System.ComponentModel.ISupportInitialize)DishPreviewBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox DishPreviewBox;
        private FlowLayoutPanel BtnsLayoutPanel;
        private RichTextBox DishCompositionRichTextBox;
        private Label DishNameLbl;
    }
}
