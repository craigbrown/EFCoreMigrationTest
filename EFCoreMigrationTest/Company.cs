using System.ComponentModel.DataAnnotations;

namespace EFCoreMigrationTest
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string Name { get; set; } = null!;

        public Address Address { get; set; } = null!;
    }
}
