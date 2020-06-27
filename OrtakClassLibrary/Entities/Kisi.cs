using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OrtakClassLibrary.Entities
{
    public class Kisi
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Biyografi { get; set; }
        public string Resim { get; set; }
        [Required]
        public DateTime? DogumTarihi { get; set; }
        public List<KitapYazarlari> KitapYazarlari { get; set; } = new List<KitapYazarlari>();
        [NotMapped]
        public string Character { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Kisi p2)
            {
                return Id == p2.Id;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
