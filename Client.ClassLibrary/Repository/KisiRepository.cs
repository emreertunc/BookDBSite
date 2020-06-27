using ClientClassLibrary.Helpers;
using OrtakClassLibrary.DTOs;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public class KisiRepository:IKisiRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/kisiler";

        public KisiRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<PaginatedResponse<List<Kisi>>> GetKisiler(PaginationDTO paginationDTO)
        {
            return await httpService.GetHelper<List<Kisi>>(url, paginationDTO);
        }

        public async Task<List<Kisi>> GetKisilerByName(string name)
        {
            var response = await httpService.Get<List<Kisi>>($"{url}/search/{name}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task<Kisi> GetKisiById(int id)
        {
            return await httpService.GetHelper<Kisi>($"{url}/{id}");
        }

        public async Task CreateKisi(Kisi kisi)
        {
            var response = await httpService.Post(url, kisi);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateKisi(Kisi kisi)
        {
            var response = await httpService.Put(url, kisi);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteKisi(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
