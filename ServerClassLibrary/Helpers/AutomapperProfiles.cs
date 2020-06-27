using AutoMapper;
using OrtakClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServerClassLibrary.Helpers
{
    public class AutomapperProfiles : Profile
    {
        public AutomapperProfiles()
        {
            CreateMap<Kisi, Kisi>()
                .ForMember(x => x.Resim, option => option.Ignore());

            CreateMap<Kitap, Kitap>()
                .ForMember(x => x.KitapKapak, option => option.Ignore());
        }
    }
}
