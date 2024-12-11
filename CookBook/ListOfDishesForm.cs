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
    public partial class ListOfDishesForm : Form {
        public ListOfDishesForm() {
            InitializeComponent();
        }

        private void ListOfDishesForm_Load(object sender, EventArgs e) {

            ReloadList();
            //this.LayoutPanel.Controls.Add(new DishCard(new DBManager.DishFields()));
        }

        protected virtual void ReloadList() {
            foreach (Control control in this.LayoutPanel.Controls) {
                control.Dispose();
            }
            this.LayoutPanel.Controls.Clear();
            foreach (var dish in DBManager.GetList()) {
                this.LayoutPanel.Controls.Add(new DishCard(dish));
            }
        }
    }
}
