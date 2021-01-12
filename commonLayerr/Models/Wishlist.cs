using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace commonLayerr.Models
{
    public class Wishlist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int wishList_id { get; set; }
        public int product_id { get; set; }

        [ForeignKey("product_id")]
        public Product Product { get; set; }
        public string loginUser { get; set; }
        public bool addedToCart { get; set; }
    }
}
