using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace immo.Models
{
    public class Annonce
    {
        public int AnnonceID { get; set; }
        public string Description { get; set; }

        public Annonce () {
            Description = "une annonce normale pour tester";
            }

    }
}