using System.ComponentModel.DataAnnotations;

namespace WorldGaming.Models
{
    public class Products
    {



        [Key]
        public int Id { get; set; }


        public string? ProductName { get; set; }

        public int ProductPrice { get; set; }

        public string? Image { get; set; }






    }
}
