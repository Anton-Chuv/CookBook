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
            this._id = dishFields.ID;
        }

        private void AddSaveBtn_Click(object sender, EventArgs e) {
            DBManager.DishFields dishFields = new DBManager.DishFields();
            dishFields.Name = this.NameTextBox.Text;
            dishFields.Composition = this.CompositionTextBox.Text;
            if (_id == -1) 
                DBManager.AddRecord(dishFields);
            else {
                dishFields.ID = _id;
                DBManager.ChangeRecord(dishFields);
                Console.WriteLine("aa");
            }
            this.Close();
        }

        private void AddCancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddDishForm_Load(object sender, EventArgs e) {

        }
    }
}
