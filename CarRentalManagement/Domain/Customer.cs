namespace CarRentalManagement.Domain
{
    public class Customer: BaseModelDomain
    {
        public string?  DrivingLicense { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? EmailAddress { get; set; }

    }
}
