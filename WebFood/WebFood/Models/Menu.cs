using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFood.Models
{
    public class Menu
    {
        [Key]
        public int ID { get; set; }
        public virtual Store store { get; set; }
        public String MenuName { get; set; }
        public String MenuDescription { get; set; }
        public String MenuImage { get; set; }
        public Decimal Price { get; set; }
        public int NumberOfPersonsForDish { get; set; }
        public String Ingredient { get; set; }
    }
}