using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCHelloWorldTeam1.DbModels
{
    [Table("category")]
    public class Category
    {

        [Key]
        [Column("id")]
        public Int32 Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}