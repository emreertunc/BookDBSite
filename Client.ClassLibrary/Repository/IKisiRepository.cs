using OrtakClassLibrary.DTOs;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public interface IKisiRepository
    {
        Task CreateKisi(Kisi kisi);
        Task DeleteKisi(int Id);
        Task<PaginatedResponse<List<Kisi>>> GetKisiler(PaginationDTO paginationDTO);
        Task<List<Kisi>> GetKisilerByName(string name);
        Task<Kisi> GetKisiById(int id);
        Task UpdateKisi(Kisi kisi);
    }
}
