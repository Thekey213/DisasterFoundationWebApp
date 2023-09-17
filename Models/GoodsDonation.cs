namespace DisasterFoundationWebApp.Models
{
    public class GoodsDonation
    {
        public int GoodsDonationId { get; set; }
        public int DonationId { get; set; } // Foreign key to Donation
        public Donation Donation { get; set; } // Navigation property
                                               // Other goods donation-related properties
    }

}
