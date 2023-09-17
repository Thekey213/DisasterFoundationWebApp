namespace DisasterFoundationWebApp.Models
{
    public class Donation
    {
        public int DonationId { get; set; }
        public string UserId { get; set; } // Foreign key to ApplicationUser
        public ApplicationUser User { get; set; } // Navigation property
                                                  // Other donation-related properties
    }

}
