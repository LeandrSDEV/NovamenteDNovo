namespace NovamenteDenovo.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesRecord Sales { get; set; }

        public SalesRecord() { }

        public SalesRecord(int id, DateTime date, double amount, SalesRecord sales)
        {
            Id = id;   
            Date = date;
            Amount = amount;
            Sales = sales;
        }
    }
}
