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
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Resturant_App
{
    public partial class SignUp : Form
    {
         string imagePath="";
        public SignUp()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UNtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDBContext db = new AppDBContext();
            User user1 = new User()
            {
                Name = nametx.Text,
                UserName = userNametx.Text,
                Email = emailtx.Text,
                Password = passtx.Text,
                photo= imagePath
            };

            if (user1.Name == "" || user1.UserName == "" || user1.Password == "" || user1.Email == "")
            {
                MessageBox.Show("Empty cell");
                return;
            }
            try
            {
                int x = Convert.ToInt32(user1.Name);
                MessageBox.Show("Invalid Name");
                return;
            }
            catch
            {
               
            }

            Regex reg = new Regex(@"^\w+([-_.]\w+)*@\w+\.\w+$");
            if (!reg.IsMatch(user1.Email))
            {
                MessageBox.Show("Error: Invalid email");
                return;
            }

            db.Users.Add(user1);
            db.SaveChanges();
            MessageBox.Show("Done");

            if (!string.IsNullOrEmpty(imagePath))
            {
                string newPath = Environment.CurrentDirectory + "\\Users\\" + user1.UserId + ".jpg";
                File.Copy(imagePath, newPath);
                user1.photo = newPath;
                db.SaveChanges();
            }
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void agetx_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void agetx_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();  
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(ofd.FileName.EndsWith(".jpg") || ofd.FileName.EndsWith(".png"))
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
