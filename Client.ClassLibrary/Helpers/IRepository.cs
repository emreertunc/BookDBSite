using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Helpers
{
    public interface IRepository
    {
        List<Kitap> GetKitaplar();
    }
}
