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
        int _btnSize = 40;
        public DBManager.DishFields _dishFields { get; }
        public int ID { get { return _dishFields.ID; } }
        public DishCard(DBManager.DishFields dish) {
            _dishFields = dish;
            InitializeComponent();
            int _maxNameLen = 20;
            if (dish.Name.Length > _maxNameLen) {
                DishNameLbl.Text = dish.Name.Substring(0, _maxNameLen) + "…";
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(DishNameLbl, dish.Name);
            }
            else
                DishNameLbl.Text = dish.Name;
            //DishCompositionLbl.Text = dish.Composition;
            //DishCompositionBox.Text = dish.Composition;
            DishCompositionRichTextBox.Text = dish.Composition;
        }
        public void AddBtn(Button btn) {
            btn.Size = new Size(_btnSize, _btnSize);
            btn.FlatStyle = FlatStyle.System;
            this.BtnsLayoutPanel.Controls.Add(btn);
        }

        private void DishCard_Load(object sender, EventArgs e) {

        }
    }
}
