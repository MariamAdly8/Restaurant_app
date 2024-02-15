using Resturant_App.Data;
namespace Resturant_App
{
    public partial class Login : Form
    {
        public User user;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UNtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp s=new SignUp();
            s.Show();
           // this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AppDBContext db=new AppDBContext();
            string username=UNBox.Text;
            string password= PassBox.Text;
            if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
            {
                user = db.Users.Where(a => a.UserName == username && a.Password == password).FirstOrDefault();
                if(user != null)
                {
                    MessageBox.Show("Hello, "+ user.Name);
                    MainForm d = new MainForm(user);
                    d.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("can't be found");
                }
            }
            else
            {
                MessageBox.Show("Empty cell!");
            }
            
        }

        private void PassBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}