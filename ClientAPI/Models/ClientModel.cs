using System.ComponentModel.DataAnnotations;
namespace ClientAPI.Models
{
    public class ClientModel
    {
        [Key]
        public Guid ClientId { get; set; }
        [Required]
        public string ClientFirstName { get; set; }
        [Required]
        public string ClientLastName { get; set; }
        [Required]
        public string ClientGender { get; set; }
        [Required]
        public string ClientIDNumber { get; set; }
        [Required]
        public string ClientAddress { get; set; }
        [Required]
        public string ClientCity { get; set; }
        [Required]
        public string ClientEmailAddress { get; set; }
        [Required]
        public string ClientPhoneNumber { get; set; }
    }
}
