using ClientClassLibrary.Helpers;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientClassLibrary.Repository
{
    public class KitapturRepository : IKitapturRepository
    {
        private readonly IHttpService httpService;
        private string url = "api/kitapturler";

        public KitapturRepository(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<Kitaptur>> GetKitapturler()
        {
            var response = await httpService.Get<List<Kitaptur>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }
        public async Task<Kitaptur> GetKitaptur(int Id)
        {
            var response = await httpService.Get<Kitaptur>($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
            return response.Response;
        }

        public async Task TurOlustur(Kitaptur kitaptur)
        {
            var response = await httpService.Post(url, kitaptur);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task UpdateKitaptur(Kitaptur kitaptur)
        {
            var response = await httpService.Put(url, kitaptur);
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }

        public async Task DeleteKitaptur(int Id)
        {
            var response = await httpService.Delete($"{url}/{Id}");
            if (!response.Success)
            {
                throw new ApplicationException(await response.GetBody());
            }
        }
    }
}
