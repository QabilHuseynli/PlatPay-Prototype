using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using PlatPay_Prototype.DAL;

namespace PlatPay_Prototype
{
    public partial class BankAccount : Form
    {
        public int Id { get; set; }
        public BankAccount(int cardId)
        {
            InitializeComponent();
            Id = cardId;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BankAccount_Load(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();
            var card = dbContext
                .BankCards
                .Where(p => p.Id == this.Id)
                .Include(p => p.Edvs)
                .FirstOrDefault();
            var edvs = card.Edvs;

            double alledvs = 0;
            foreach (var edv in edvs)
            {
                ListViewItem edvItem = new ListViewItem(edv.Id.ToString());
                edvItem.SubItems.Add(edv.EdvAmount.ToString());
                listView1.Items.Add(edvItem);
                alledvs += edv.EdvAmount;
            }

            label6.Text = card.FirsName;
            label5.Text = card.LastName;
            label8.Text = card.CardId;
            label7.Text = card.Balance + "₼";
            label9.Text = alledvs == 0 ? "0" : alledvs.ToString().Substring(0, 5) + "₼";



        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
