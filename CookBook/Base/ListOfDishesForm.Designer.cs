namespace CookBook {
    partial class ListOfDishesForm {
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
            LayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // LayoutPanel
            // 
            LayoutPanel.AutoScroll = true;
            LayoutPanel.Dock = DockStyle.Fill;
            LayoutPanel.Location = new Point(0, 0);
            LayoutPanel.Name = "LayoutPanel";
            LayoutPanel.Size = new Size(800, 450);
            LayoutPanel.TabIndex = 1;
            // 
            // ListOfDishesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LayoutPanel);
            Name = "ListOfDishesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ListOfDishesForm";
            Load += ListOfDishesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        protected FlowLayoutPanel LayoutPanel;
    }
}