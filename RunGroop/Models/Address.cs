using System.ComponentModel.DataAnnotations;

namespace RunGroop.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}
