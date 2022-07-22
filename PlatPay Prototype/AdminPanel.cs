
using PlatPay_Prototype.DAL;

namespace PlatPay_Prototype
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            //using var dbContext = new AppDbContext();
            //var cards = dbContext
            //    .BankCards
            //    .Where(p => p.IsDeleted == false).ToList();
            //cards;
        }
    }
}
