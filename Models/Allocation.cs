namespace DisasterFoundationWebApp.Models
{
    public class Allocation
    {
        public int AllocationId { get; set; }
        public int DisasterId { get; set; } // Foreign key to Disaster
        public Disaster Disaster { get; set; } // Navigation property
        public int DonationId { get; set; } // Foreign key to Donation
        public Donation Donation { get; set; } // Navigation property
    }

}
