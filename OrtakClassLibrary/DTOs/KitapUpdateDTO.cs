using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrtakClassLibrary.DTOs
{
    public class KitapUpdateDTO
    {
        public Kitap Kitap { get; set; }
        public List<Kisi> Yazar { get; set; }
        public List<Kitaptur> SelectedKitapturler { get; set; }
        public List<Kitaptur> NotSelectedKitapturler { get; set; }
    }
}
