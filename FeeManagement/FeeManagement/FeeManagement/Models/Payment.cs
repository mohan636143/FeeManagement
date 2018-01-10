using System;
namespace FeeManagement.Models
{
    public class Payment
    {
        public DateTime PaymentDate { get; set; }
        public string Towards { get; set; }
        public string Mode { get; set; }
        public string Amount { get; set; }
    }
}
