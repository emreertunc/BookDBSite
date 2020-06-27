using OrtakClassLibrary.DTOs;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public interface IKitaplarRepository
    {
        Task<int> CreateKitap(Kitap kitap);
        Task DeleteKitap(int Id);
        Task<DetailsKitapDTO> GetDetailsKitapDTO(int id);
        Task<IndexPageDTO> GetIndexPageDTO();
        Task<KitapUpdateDTO> GetKitapForUpdate(int id);
        Task<PaginatedResponse<List<Kitap>>> GetKitaplarFiltered(FilterKitaplarDTO filterKitaplarDTO);
        Task UpdateKitap(Kitap kitap);
    }
}
