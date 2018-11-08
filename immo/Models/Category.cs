using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immo.Models
{
    public class Category
    {
        [Key]
        public int idCat { get; set; }
        public String Type { get; set; }   
    }
}