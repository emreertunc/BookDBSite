using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OrtakClassLibrary.Entities
{
    public class Kitap
    {
        public int Id { get; set; }
        [Required]
        public string Baslik { get; set; }
        public string Ozet { get; set; }
        public bool KitapListele { get; set; }
        public string TanitimVideo { get; set; }
        [Required]
        public DateTime? YayinTarihi { get; set; }
        public string KitapKapak { get; set; }
        public List<KitaplarKitapturler> KitaplarKitapturler { get; set; } = new List<KitaplarKitapturler>();
        public List<KitapYazarlari> KitapYazarlari { get; set; } = new List<KitapYazarlari>();
        public string TitleBrief
        {
            get
            {
                if (string.IsNullOrEmpty(Baslik))
                {
                    return null;
                }

                if (Baslik.Length > 60)
                {
                    return Baslik.Substring(0, 60) + "...";
                }
                else
                {
                    return Baslik;
                }
            }
        }
    }
}