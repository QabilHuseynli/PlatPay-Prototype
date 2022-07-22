namespace PlatPay_Prototype.Models
{
    public class BankCard
    {
        public int Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public string Pin { get; set; }
        public string CardId { get; set; }
        public string Cvv { get; set; }
        public DateTime ExpiredDate { get; set; }
        public double Balance { get; set; }
        public DateTime CreadtedAt { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<Edv> Edvs { get; set; }
    }
}
