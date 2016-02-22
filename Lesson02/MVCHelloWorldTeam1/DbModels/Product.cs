using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCHelloWorldTeam1.DbModels
{
    [Table("product")]
    public class Product
    {
        [Key]
        [Column("id")]
        public Int32 Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("quantity")]
        public Decimal Quantity { get; set; }

        [Column("code")]
        public Int32 Code { get; set; }

        [Column("Created_at")]
        public DateTime Created_at { get; set; }

        [Column("category_id")]
        public Int32 categoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}