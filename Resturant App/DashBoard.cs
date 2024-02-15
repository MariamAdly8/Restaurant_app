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
    public partial class DashBoard : Form
    {
        AppDBContext db = new AppDBContext();
        User user=new User();
        public DashBoard()
        {
            InitializeComponent();
        }
        public DashBoard(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SignUp s=new SignUp();
            s.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void showAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allUers = from u in db.Users select new { u.UserId, u.UserName, u.Email };
            dataGridView1.DataSource=allUers.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text="Edit", Name="Edit",UseColumnTextForButtonValue=true});
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
    
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var row=dataGridView1.Rows[e.RowIndex];
                int u_id = Convert.ToInt32(row.Cells["UserId"].Value);
                User sel=db.Users.Where(u => u.UserId == u_id).FirstOrDefault();

                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    if (sel != null)
                    {
                        EditForm ef=new EditForm(sel);
                        this.Hide();
                        ef.ShowDialog();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["Show"].Index)
                {
                    if (sel != null)
                    {
                        ShowForm sf = new ShowForm(sel);
                        this.Hide();
                        sf.ShowDialog();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    if (sel != null)
                    {
                        DeleteForm sf = new DeleteForm(sel);
                        this.Hide();
                        sf.ShowDialog();
                    }
                }
            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddItem a=new AddItem();
            this.Hide();
            a.Show();
        }

        private void menuItemsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            ViewMenu a=new ViewMenu();
            this.Hide();
            a.Show();
        }

        private void addNewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaceOrderForm p = new PlaceOrderForm(user);
            this.Hide();
            p.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
