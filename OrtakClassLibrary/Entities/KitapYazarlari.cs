using System;
using System.Collections.Generic;
using System.Text;

namespace OrtakClassLibrary.Entities
{
    public class KitapYazarlari
    {
        public int KisiId { get; set; }
        public int KitapId { get; set; }
        public Kisi Kisi { get; set; }
        public Kitap Kitap { get; set; }
        public string Character { get; set; }
        public int Order { get; set; }
    }
}
