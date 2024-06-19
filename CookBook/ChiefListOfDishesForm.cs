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
    public partial class ChiefListOfDishesForm : ListOfDishesForm {
        public ChiefListOfDishesForm() {
            InitializeComponent();
        }

        private void ChiefListOfDishesForm_Load(object sender, EventArgs e) {
            Button AddBtn = new Button();
            DishCard dishCard = new DishCard();
            AddBtn.Size = new Size(dishCard.Width, dishCard.Height);
            AddBtn.Text = "Add";
            AddBtn.Click += (object s, EventArgs ev) => {
                //this.Hide();
                AddDishForm addDishForm = new AddDishForm();
                addDishForm.FormClosed += (object s, FormClosedEventArgs ev) => { 
                    //this.Show(); 
                };
                addDishForm.Show();
            };                
            this.LayoutPanel.Controls.Add(AddBtn);
            this.LayoutPanel.Controls.SetChildIndex(AddBtn, 0);
        }
    }
}
