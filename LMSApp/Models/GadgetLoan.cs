namespace LMSApp.Models
{
    public class GadgetLoan
    {
        public int Id { get; set; }
        public string? GadgetName { get; set; }
        public string? Description { get; set;}
        public int Price { get; set; }
        public float ThreeMonInt{ get; set; }     
        public float SixMonInt { get; set; }
        public float TwelveMonInt { get; set; }

        public GadgetLoan() 
        { }

        public GadgetLoan(int id, string? gadgetName, string? description, int price, float threeMonInt, float sixMonInt, float twelveMonInt)
        {
            Id = id;
            GadgetName = gadgetName;
            Description = description;
            Price = price;
            ThreeMonInt = threeMonInt;
            SixMonInt = sixMonInt;
            TwelveMonInt = twelveMonInt;
        }
    }
}
