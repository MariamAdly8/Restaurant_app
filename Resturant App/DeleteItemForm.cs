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
    public partial class DeleteItemForm : Form
    {
        AppDBContext db = new AppDBContext();
        Items item = new Items();
        public DeleteItemForm(Items item)
        {
            InitializeComponent();
            this.item = item;
        }

        private void DeleteItemForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.items.Remove(this.item);
            db.SaveChanges();
            MessageBox.Show("Deleted");
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }
    }
}
