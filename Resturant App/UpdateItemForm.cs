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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Resturant_App
{
    public partial class UpdateItemForm : Form
    {
        Items it=new Items();
        AppDBContext db = new AppDBContext();
        public UpdateItemForm(Items i)
        {
            InitializeComponent();
            this.it = i;
        }

        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            Iname.Text = this.it.name;
            Iprice.Text = this.it.price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.it.name = Iname.Text;
            this.it.price = Iprice.Text;
            if (this.it.name == "" || this.it.price == "")
            {
                MessageBox.Show("Empty cell");
                return;
            }
            try
            {
                int x = Convert.ToInt32(this.it.name);
                MessageBox.Show("Invalid Name");
                return;
            }
            catch
            { }
            try
            {
                int x = Convert.ToInt32(this.it.price);
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
            db.items.Update(this.it);
            db.SaveChanges();
            MessageBox.Show("Done");
            DashBoard d = new DashBoard();
            this.Hide();
            d.Show();
        }
    }
}
