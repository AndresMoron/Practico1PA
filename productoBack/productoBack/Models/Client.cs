
namespace productoBack
{
    using System.ComponentModel.DataAnnotations;

    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        [Required]
            [Display(Name = "Client Name")]
        public string Name { get; set; }
        public string Mail { get; set; }
    }
}