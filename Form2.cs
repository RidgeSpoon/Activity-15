using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<food> foods = new List<food>();
            foods.Add(new food() { ID = 1, Name = "Pizza" });
            foods.Add(new food() { ID = 2, Name = "Hamburger" });
            foods.Add(new food() { ID = 3, Name = "Cheeseburger" });
            foods.Add(new food() { ID = 4, Name = "Pretzel & Cheese" });
            foods.Add(new food() { ID = 5, Name = "Hotdog" });
            foods.Add(new food() { ID = 6, Name = "Pasta Salad" });
            foods.Add(new food() { ID = 7, Name = "Chicken Alfredo" });
            foods.Add(new food() { ID = 8, Name = "Pot Pie" });
            foods.Add(new food() { ID = 9, Name = "Shepherds Pie" });
            foods.Add(new food() { ID = 10, Name = "Thanksgiving" });

            food.DataSource = foods;
            food.ValueMember = "ID";
            food.DisplayMember = "Name";

            
        }

        private void food_SelectedIndexChanged(object sender, EventArgs e)
        {
            food obj = food.SelectedItem as food;
        }

        private void drink_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
