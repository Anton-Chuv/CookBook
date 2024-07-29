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
    public partial class UserSelectionForm : Form {
        public UserSelectionForm() {
            InitializeComponent();
        }

        private void GuestBtn_Click(object sender, EventArgs e) {
            this.Hide();
            GuestListOfDishesForm listOfDishesForm = new GuestListOfDishesForm();
            listOfDishesForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            listOfDishesForm.Show();
        }

        private void CookBtn_Click(object sender, EventArgs e) {

        }

        private void ChiefBtn_Click(object sender, EventArgs e) {
            this.Hide();
            ChiefListOfDishesForm listOfDishesForm = new ChiefListOfDishesForm();
            listOfDishesForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            listOfDishesForm.Show();
        }
    }
}
