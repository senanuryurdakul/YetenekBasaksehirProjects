namespace _12_OOPTemelPersipler.Entities
{
    public class Customer
    {
        public Customer()
        {
            IsActive = true;
        }
        public string? CustomerID { get;} = Guid.NewGuid().ToString();
        public string? CustomerName { get; set; }
        public string? Email { get; set; }
        public string? Country { get; } = "Türkiye";
        public bool IsActive { get; set; } 
    }
}
