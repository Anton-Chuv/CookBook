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
    public partial class DishCard : UserControl {
        int _id;
        public DishCard() {
            InitializeComponent();
        }
        public DishCard(DBManager.DishFields dish) {
            InitializeComponent();
            DishNameLbl.Text = dish.Name;
            DishCompositionLbl.Text = dish.Composition;
            _id = dish.ID;
        }
    }
}
