using System.ComponentModel.DataAnnotations;

namespace WorldGaming.Models
{
    public class ProductDet
    {









        [Key]

        public int Id { get; set; }

        public int Size { get; set; }

        public string? Type { get; set; }

        public string? Platform { get; set; }


        public string? Multiplayer { get; set; }







        public virtual Products Products { get; set; }




    }
}
