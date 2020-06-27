using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrtakClassLibrary.DTOs
{
    public class DetailsKitapDTO
    {
        public Kitap Kitap { get; set; }
        public List<Kitaptur> Kitapturler { get; set; }
        public List<Kisi> Yazar { get; set; }
    }
}
