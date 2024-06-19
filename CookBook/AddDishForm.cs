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
        public AddDishForm() {
            InitializeComponent();
        }

        private void AddSaveBtn_Click(object sender, EventArgs e) {
            DBManager.DishFields dishFields = new DBManager.DishFields();
            dishFields.Name = this.NameTextBox.Text;
            dishFields.Composition = this.CompositionTextBox.Text;
            DBManager.AddRecord(dishFields);
        }

        private void AddCancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
