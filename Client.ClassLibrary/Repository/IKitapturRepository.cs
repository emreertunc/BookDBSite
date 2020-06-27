using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public interface IKitapturRepository
    {
        Task TurOlustur(Kitaptur kitaptur);
        Task<Kitaptur> GetKitaptur(int Id);
        Task<List<Kitaptur>> GetKitapturler();
        Task UpdateKitaptur(Kitaptur kitaptur);
        Task DeleteKitaptur(int Id);
    }
}
