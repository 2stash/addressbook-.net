using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Contacts
    {
        [Key]
        public int Id { get; set; }
        [Required]  
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
