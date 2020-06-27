using ClientClassLibrary.Helpers;
using OrtakClassLibrary.DTOs;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public class KitaplarRepository : IKitaplarRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/kitaplar";

        public KitaplarRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<IndexPageDTO> GetIndexPageDTO()
        {
            return await httpService.GetHelper<IndexPageDTO>(url);
        }

        public async Task<KitapUpdateDTO> GetKitapForUpdate(int id)
        {
            return await httpService.GetHelper<KitapUpdateDTO>($"{url}/update/{id}");
        }

        public async Task<DetailsKitapDTO> GetDetailsKitapDTO(int id)
        {
            return await httpService.GetHelper<DetailsKitapDTO>($"{url}/{id}");
        }

        public async Task<PaginatedResponse<List<Kitap>>> GetKitaplarFiltered(FilterKitaplarDTO filterKitaplarDTO)
        {
            var responseHTTP = await httpService.Post<FilterKitaplarDTO, List<Kitap>>($"{url}/filter", filterKitaplarDTO);
            var totalAmountPages = int.Parse(responseHTTP.HttpResponseMessage.Headers.GetValues("totalAmountPages").FirstOrDefault());
            var paginatedResponse = new PaginatedResponse<List<Kitap>>()
            {
                Response = responseHTTP.Response,
                TotalAmountPages = totalAmountPages
            };

            return paginatedResponse;
        }

        public async Task<int> CreateKitap(Kitap kitap)
        {
            var response = await httpService.Post<Kitap, int>(url, kitap);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }

            return response.Response;
        }

        public async Task UpdateKitap(Kitap kitap)
        {
            var response = await httpService.Put(url, kitap);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteKitap(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
