using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlatPay_Prototype.DAL;

namespace PlatPay_Prototype
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var dbContext = new AppDbContext();
            var card = dbContext.BankCards
                .Where(p => p.CardId == textBox1.Text)
                .FirstOrDefault();
            if (card is null)
            {
                MessageBox.Show("Kart Movcud Deyil");
            }
            else if (card.Pin == textBox2.Text)
            {
                BankAccount bankAccount = new BankAccount(card.Id);
                bankAccount.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pin Yanlisdi");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int c = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            c++;
            if (c % 2 == 0)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
