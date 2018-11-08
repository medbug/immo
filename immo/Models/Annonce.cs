using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace immo.Models
{
    public class Annonce
    {
        [Key]
        public int AnnonceID { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public Genre genre { get; set; }

    }

    public enum Genre
    {
        Achat, Location
    }


}