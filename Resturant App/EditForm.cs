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

namespace Resturant_App
{
    public partial class EditForm : Form
    {
        private User user;
        AppDBContext db=new AppDBContext();
        string imagePath = "";
        public EditForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d=new DashBoard();
            this.Hide();
            d.ShowDialog();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            nametx.Text = this.user.Name;
            emailtx.Text = this.user.Email;
            userNametx.Text = this.user.UserName;
            passtx.Text = this.user.Password;
            pictureBox.ImageLocation = this.user.photo;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileName.EndsWith(".jpg") || ofd.FileName.EndsWith(".png"))
                {
                    imagePath = ofd.FileName;
                    pictureBox.ImageLocation = ofd.FileName;
                }
                else
                {
                    MessageBox.Show("You should upload an image");
                    return;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.user.Name = nametx.Text;
            this.user.UserName = userNametx.Text;
            this.user.Email = emailtx.Text;
            this.user.Password = passtx.Text;
            this.user.photo = pictureBox.ImageLocation;

            if (this.user.Name == "" || this.user.UserName == "" || this.user.Password == "" || this.user.Email == "")
            {
                MessageBox.Show("Empty cell");
                return;
            }

            try
            {
                int x = Convert.ToInt32(user.Name);
                MessageBox.Show("Invalid Name");
                return;
            }
            catch
            {

            }

            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+\.\w+$");
            if (!reg.IsMatch(user.Email))
            {
                MessageBox.Show("Error: Invalid email");
                return;
            }


            db.Users.Update(this.user);
            db.SaveChanges();

            if (!string.IsNullOrEmpty(imagePath))
            {
                string newPath = Environment.CurrentDirectory + "\\Users\\" + this.user.UserId + ".jpg";
                File.Delete(newPath);
                File.Copy(imagePath, newPath);
                this.user.photo = newPath;
                db.SaveChanges();
            }
            MessageBox.Show("Updated"); 
            this.Hide();
            DashBoard d = new DashBoard();
            d.ShowDialog();
        }

        private void agetx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gendertx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void passtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userNametx_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailtx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nametx_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
