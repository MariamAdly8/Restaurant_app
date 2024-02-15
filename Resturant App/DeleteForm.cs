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
    public partial class DeleteForm : Form
    {
        private User user;
        AppDBContext db = new AppDBContext();
        public DeleteForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Users.Remove(this.user);
            db.SaveChanges();
            MessageBox.Show("Deleted");
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }
    }
}
