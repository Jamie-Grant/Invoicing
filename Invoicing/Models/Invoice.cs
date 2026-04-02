namespace Invoicing.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyEmail  { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public List<string> Services { get; set; }
        public int Amount { get; set; }
        public int AccountNumber { get; set; }
        public int SortCode { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
