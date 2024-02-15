using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Resturant_App.Data;

namespace Resturant_App
{
    public partial class AddItem : Form
    {
        AppDBContext db = new AppDBContext();
        public AddItem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Items item1= new Items()
            {
                name=Iname.Text,
                price=Iprice.Text
            };
            if (item1.name == "" || item1.price == "")
            {
                MessageBox.Show("Empty cell");
                return;
            }
            try
            {
                int x = Convert.ToInt32(item1.name);
                MessageBox.Show("Invalid Name");
                return;
            }
            catch
            {}
            try
            {
                int x = Convert.ToInt32(item1.price);
                if (x < 0)
                {
                    MessageBox.Show("Invalid price value");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid price value");
                return;
            }
            db.items.Add(item1);
            db.SaveChanges();
            MessageBox.Show("Done");
            DashBoard d=new DashBoard();
            this.Hide();
            d.Show();
        }

        private void Iprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Iname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d=new DashBoard();
            d.Show();
            this.Hide();
        }
    }
}
