namespace LedgerAPI.Models
{
    public class User
    {
        public int id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Ledger>? ledgers { get; set; } = new List<Ledger>();
    }
}
