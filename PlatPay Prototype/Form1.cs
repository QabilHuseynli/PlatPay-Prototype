using System.IO.Ports;
using PlatPay_Prototype.DAL;
using PlatPay_Prototype.Models;

namespace PlatPay_Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialPort _serialPort = new SerialPort();
            _serialPort.PortName = "COM3"; //Set your board COM
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            while (true)
            {
                string SerialCardId = _serialPort.ReadLine();
                if (SerialCardId != String.Empty)
                {
                    var amount = Convert.ToDouble(textBox1.Text);
                    var edv = (((amount * 18) / 118) * 0.15);

                    var InputCardId = SerialCardId.Substring(0, 10);
                    using var dbContext = new AppDbContext();
                    var card = dbContext
                        .BankCards
                        .Where(p => p.CardId == InputCardId && p.IsDeleted == false)
                        .FirstOrDefault();
                    if (card == null)
                    {
                        MessageBox.Show("Bele Kart Movcud Deyil");
                    }
                    else if (amount > card.Balance)
                    {
                        MessageBox.Show("Balansda Kifayet Qeder Mebleg Yoxdu");
                    }
                    else
                    {
                        card.Balance -= Convert.ToDouble(textBox1.Text);
                        var edvAmount = new Edv
                        {
                            BankCardId = card.Id,
                            EdvAmount = edv,
                            status = false
                        };
                        dbContext.Add(edvAmount);
                        dbContext.SaveChanges();


                        var msg = "Odenis Ugurlu oldu\n" +
                                  "Mebleg : " + amount + "₼" + "\n" +
                                  "Edv : " + edv.ToString().Substring(0, 5) + "₼";
                        MessageBox.Show(msg);

                    }


                    _serialPort.Close();

                    break;

                }
                Thread.Sleep(200);
            }

            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Console.WriteLine(textBox1.Text);
            //Console.WriteLine(textBox1_TextChanged);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel admin = new AdminPanel();
            admin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}