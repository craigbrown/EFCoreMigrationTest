using System.ComponentModel.DataAnnotations;

namespace EFCoreMigrationTest
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        public string AddressLine1 { get; set; } = null!;

        public string City { get; set; } = null!;
    }
}
