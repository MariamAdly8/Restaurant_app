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
    public partial class MainForm : Form
    {
        AppDBContext db = new AppDBContext();
        User user = new User();
        public MainForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlaceOrderForm p = new PlaceOrderForm(user);
            p.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard dashBoard = new DashBoard();
            dashBoard.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
