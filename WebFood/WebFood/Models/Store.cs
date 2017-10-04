using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebFood.Models
{
    public class Store
    {
        [Key]
        public int ID { get; set; }
        public String StoreName { get; set; }
        public String StoreLogo { get; set; }
        public bool IsActive { get; set; }
        public String StoreCoverImage { get; set; }
        public String StroreCoverImageOnTextOne { get; set; }
        public String StroreCoverImageOnTextTwo { get; set; }
        public String StroreCoverImageOnTextThree { get; set; }
        public String StroreAboutUsTitle { get; set; }
        public String StroreAboutUsDescription { get; set; }
        public String StroreAboutUsImage { get; set; }
        public List<Menu> StoreMenus { get; set; }

    }
}