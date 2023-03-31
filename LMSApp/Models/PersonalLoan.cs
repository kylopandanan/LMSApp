namespace LMSApp.Models
{
    public class PersonalLoan
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int MinLoanAmount { get; set; }
        public int MaxLoanAmount { get; set;}
        public int MinPaymentTerm { get; set;}
        public int MaxPaymentTerm { get; set;}

        public PersonalLoan() 
        {
        
        }

        public PersonalLoan(int id, string description, int minLoanAmount, int maxLoanAmount, int minPaymentTerm, int maxPaymentTerm)
        {
            Id = id;
            Description = description;
            MinLoanAmount = minLoanAmount;
            MaxLoanAmount = maxLoanAmount;
            MinPaymentTerm = minPaymentTerm;
            MaxPaymentTerm = maxPaymentTerm;
        }
    }
}
