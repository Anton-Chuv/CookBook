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
            
        }
        protected override void ReloadList() {
            base.ReloadList();

            AddButtons();
        }

        private void AddButtons() {
            // кнопка добавления
            Button AddBtn = new Button();
            DishCard dishCard = new DishCard(new DBManager.DishFields());
            AddBtn.Size = new Size(dishCard.Width, dishCard.Height);
            AddBtn.Text = "Add";
            AddBtn.Click += (object s, EventArgs ev) => {
                //this.Hide();
                AddDishForm addDishForm = new AddDishForm();
                addDishForm.FormClosed += (object s, FormClosedEventArgs ev) => {
                    //this.Show(); 
                    ReloadList();
                };
                addDishForm.Show();
            };
            this.LayoutPanel.Controls.Add(AddBtn);
            this.LayoutPanel.Controls.SetChildIndex(AddBtn, 0);

            // кнопка удаления
            foreach (DishCard card in this.LayoutPanel.Controls.OfType<DishCard>()) {
                Button removeBtn = new Button();
                //removeBtn.Text = "D";
                removeBtn.BackgroundImage = Properties.Resources._8664938_trash_can_delete_remove_icon;
                removeBtn.BackgroundImageLayout = ImageLayout.Center;
                //removeBtn.FlatStyle = FlatStyle.Flat;

                removeBtn.Click += (object s, EventArgs ev) => {
                    DialogResult result = MessageBox.Show($"Вы уверены что хотите удалить {card._dishFields.Name}",
                        "",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button2
                        ); //
                    if (result == DialogResult.Yes) {
                        DBManager.DeleteRecord(card.ID);
                        this.LayoutPanel.Controls.Remove(card);
                    }
                };
                card.AddBtn(removeBtn);

                Button changeBtn = new Button();
                //changeBtn.Text = "C";
                changeBtn.BackgroundImage = Properties.Resources._2931178_change_edit_pencil_creative_design_icon__1_;
                changeBtn.BackgroundImageLayout = ImageLayout.Center;

                changeBtn.Click += (object s, EventArgs ev) => {
                    //this.Hide();
                    AddDishForm addDishForm = new AddDishForm(card._dishFields);
                    addDishForm.FormClosed += (object s, FormClosedEventArgs ev) => {
                        //this.Show(); 
                        ReloadList();
                    };
                    addDishForm.Show();
                };
                card.AddBtn(changeBtn);
            }
        }
    }
}
