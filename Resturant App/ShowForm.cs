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
    public partial class ShowForm : Form
    {
        private User user;
        AppDBContext db = new AppDBContext();
        public ShowForm(User user)
        {
            InitializeComponent();
            this.user=user;
        }

        private void ShowForm_Load(object sender, EventArgs e)
        {
            nametx.Text = this.user.Name;
            emailtx.Text = this.user.Email;
            userNametx.Text = this.user.UserName;
            passtx.Text = this.user.Password;
            pictureBox.ImageLocation = this.user.photo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d = new DashBoard();
            this.Hide();
            d.ShowDialog();
        }
    }
}
