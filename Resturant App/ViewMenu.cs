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
    public partial class ViewMenu : Form
    {
        AppDBContext db = new AppDBContext();
        public ViewMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DashBoard d=new DashBoard();
            this.Hide();
            d.Show();
        }

        private void ViewMenu_Load(object sender, EventArgs e)
        {
            var menu = from i in db.items select new { i.itemId, i.name, i.price };
            dataGridView1.DataSource = menu.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Update", Name = "Update", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                int i_id = Convert.ToInt32(row.Cells["itemId"].Value);
                Items sel = db.items.Where(i => i.itemId == i_id).FirstOrDefault();

                if (e.ColumnIndex == dataGridView1.Columns["Update"].Index)
                {
                    if (sel != null)
                    {
                        UpdateItemForm u = new UpdateItemForm(sel);
                        u.Show();
                        this.Hide();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    if (sel != null)
                    {
                        DeleteItemForm u = new DeleteItemForm(sel);
                        u.Show();
                        this.Hide();
                    }
                }
            }
        }
    }
}
