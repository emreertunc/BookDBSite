using System;
using System.Collections.Generic;
using System.Text;

namespace OrtakClassLibrary.Entities
{
    public class KitaplarKitapturler
    {
        public int KitapId { get; set; }
        public int KitapturId { get; set; }
        public Kitap Kitap { get; set; }
        public Kitaptur Kitaptur { get; set; }
    }
}
