using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public required Guid Id { get; set; } // This is the primary key
        [Display(Name = "First Name")] // This is the display name for the form
        public string? FirstName { get; set; } // This is the first name of the user
        [Display(Name = "Last Name")] // This is the display name for the form
        public string? LastName { get; set; } // This is the last name of the user
        [Display(Name = "Email Address")] // This is the display name for the form
        public string? EmailAddress { get; set; } // This is the email address of the user
        [Display(Name = "Date of Birth")] // This is the display name for the form
        public DateTime? DateOfBirth { get; set; } // This is the date of birth of the user
        [Display(Name = "Car Year")] // This is the display name for the form
        public int? CarYear { get; set; } // This is the year of the car
        [Display(Name = "Car Make")] // This is the display name for the form
        public string? CarMake { get; set; } // This is the make of the car
        [Display(Name = "Car Model")] // This is the display name for the form
        public string? CarModel { get; set; } // This is the model of the car
        [Display(Name = "DUI")] // This is the display name for the form
        public bool Dui { get; set; } // This is the DUI status of the user
        [Display(Name = "Speeding Tickets")] // This is the display name for the form
        public int? SpeedingTickets { get; set; } // This is the number of speeding tickets the user has
        public List<CoverageType> Coverages { get; set; } = new List<CoverageType>();  // This is the coverage type of the user
        [Column(TypeName = "decimal(18, 2)")] // This is the quote for the user
        public decimal Quote { get; set; } // This is the quote for the user
    }

    public enum CoverageType // This is the coverage type enum with six values and display names
    {

        [Display(Name = "Liability Only")]
        Collision = 0,

        [Display(Name = "Collision")]
        FullCoverage = 1,

        [Display(Name = "Comprehensive")]
        Comprehensive = 2,

        [Display(Name = "Personal Injury Protection")]
        PersonalInjuryProtection = 3,

        [Display(Name = "Uninsured Motorist")]
        UninsuredMotorist = 4,

        [Display(Name = "Full Coverage")]
        LiabilityOnly = 5,

        

       

        



        
    }

}