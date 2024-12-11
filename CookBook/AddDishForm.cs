using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookBook {
    public partial class AddDishForm : Form {
        int _id = -1;
        public AddDishForm() {
            InitializeComponent();
        }

        public AddDishForm(DBManager.DishFields dishFields) {
            InitializeComponent();
            this.NameTextBox.Text = dishFields.Name;
            this.CompositionTextBox.Text = dishFields.Composition;
            this.PictureBox.Image = dishFields.Picture;
            this._id = dishFields.ID;
        }

        private void AddSaveBtn_Click(object sender, EventArgs e) {
            DBManager.DishFields dishFields = new DBManager.DishFields();
            dishFields.Name = this.NameTextBox.Text;
            dishFields.Composition = this.CompositionTextBox.Text;
            dishFields.Picture = this.PictureBox.Image;
            if (_id == -1)
                DBManager.AddRecord(dishFields);
            else {
                dishFields.ID = _id;
                DBManager.ChangeRecord(dishFields);
            }
            this.Close();
        }

        private void AddCancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddDishForm_Load(object sender, EventArgs e) {
            PictureBox.AllowDrop = true;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e) {
            var image = e.Data.GetData(DataFormats.FileDrop);
            if (image != null) {
                var fileNames = image as string[];
                if (fileNames.Length > 0) {
                    this.PictureBox.Image = Image.FromFile(fileNames[0]);
                    //this.PictureBox.
                }
            }

            //PictureBox.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
            //e.Effect = e.AllowedEffect;
        }
    }
}
