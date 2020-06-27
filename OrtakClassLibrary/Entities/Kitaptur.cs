using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrtakClassLibrary.Entities
{
    public class Kitaptur
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Isim { get; set; }
        public List<KitaplarKitapturler> KitaplarKitapturler { get; set; } = new List<KitaplarKitapturler>();
    }
}
