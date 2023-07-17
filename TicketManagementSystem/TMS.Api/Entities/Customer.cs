using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TMS.Api.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string CustomerName { get; set; }
        
        [Required]
        public string Email { get; set; }
    }
}
