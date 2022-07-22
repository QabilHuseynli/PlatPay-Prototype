namespace PlatPay_Prototype.Models
{
    public class Edv
    {
        public int Id { get; set; }
        public double EdvAmount { get; set; }
        public int BankCardId { get; set; }
        public BankCard BankCard { get; set; }
        public bool status { get; set; }
    }
}
