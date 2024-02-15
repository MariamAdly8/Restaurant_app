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
    public partial class PlaceOrderForm : Form
    {
        AppDBContext db = new AppDBContext();
        User user;
        int num, total = 0,amount;
        public PlaceOrderForm(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            var itms = from i in db.items select new { i.name };
            var it=itms.ToList();
            for(int i = 0; i < it.Count; i++)
            {
                listBox1.Items.Add(it[i].name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm dashBoard = new MainForm(this.user);
            this.Hide();
            dashBoard.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            quantityUpDown.Text = "0" ;
            totalprice.Clear();
            string name = listBox1.GetItemText(listBox1.SelectedItem);
            itemname.Text = name;
            var pr = from p in db.items where p.name == name select p.price; 
            var price=pr.ToList();
            try
            {
                itemprice.Text = price[0];
            }
            catch{}
        }

        private void quantityUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (itemprice.Text != "") 
            {
                int quan = int.Parse(quantityUpDown.Value.ToString());
                int price = int.Parse(itemprice.Text);
                totalprice.Text = (quan * price).ToString();
            }
        }

        private void totalprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (total > 0)
            {
                Orders order = new Orders()
                {
                    userID = this.user.UserId,
                    TotalPrice = total.ToString(),
                    date = date.Value
                };
                db.orders.Add(order);
                db.SaveChanges();
                MessageBox.Show("Done, the total cost is " + total);
                MainForm dashBoard = new MainForm(this.user);
                this.Hide();
                dashBoard.Show();
            }
            else
            {
                MessageBox.Show("There is no order!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                total -= amount;
            }
            catch { }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (totalprice.Text != "0" && totalprice.Text != "" && quantityUpDown.Value > 0) 
            {
                num = dataGridView1.Rows.Add();
                dataGridView1.Rows[num].Cells[0].Value = itemname.Text;
                dataGridView1.Rows[num].Cells[1].Value = itemprice.Text;
                dataGridView1.Rows[num].Cells[2].Value = quantityUpDown.Value.ToString();
                dataGridView1.Rows[num].Cells[3].Value = totalprice.Text;
                total += int.Parse(totalprice.Text);
                itemname.Text = "";
                quantityUpDown.Value = 0;
                itemprice.Text = "";
                totalprice.Text = "";
            }
        }
    }
}
