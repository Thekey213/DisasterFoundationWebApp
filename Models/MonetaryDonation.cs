namespace DisasterFoundationWebApp.Models
{
    public class MonetaryDonation
    {
        public int MonetaryDonationId { get; set; }
        public int DonationId { get; set; } // Foreign key to Donation
        public Donation Donation { get; set; } // Navigation property
                                               // Other monetary donation-related properties
    }

}
