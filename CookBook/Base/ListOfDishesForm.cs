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
            DBManager DB = new DBManager();

            for (int i = 0; i < 10; i++)
                this.LayoutPanel.Controls.Add(new DishCard(new DBManager.DishFields()));
        }
    }
}
