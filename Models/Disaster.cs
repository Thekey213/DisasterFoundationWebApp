namespace DisasterFoundationWebApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Disaster
    {
        public int DisasterId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string DisasterType { get; set; }
    }

}
