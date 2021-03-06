using System;
using System.ComponentModel.DataAnnotations;

namespace HotelListingAppVersion2.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength:150, ErrorMessage = "Country Name is Too Long")]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = " Address Name is Too Long")]
        public string Address { get; set; }
        [Required]
        [Range(1,5)]
        public double Rating { get; set; }
        [Required]
        public int CountryId { get; set; }
       

    }
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
