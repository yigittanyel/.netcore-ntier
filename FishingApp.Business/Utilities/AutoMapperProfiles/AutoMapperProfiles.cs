using AutoMapper;
using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Grup;
using FishingApp.Entity.DTOs.Kampanya;
using FishingApp.Entity.DTOs.KampanyaSonuc;
using FishingApp.Entity.DTOs.Kullanici;
using FishingApp.Entity.DTOs.Sablon;
using FishingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Utilities.AutoMapperProfiles
{
    public static class AutoMapperProfiles
    {
        public class AutoMapperProfile : Profile
        {
            public AutoMapperProfile()
            {
                CreateMap<Birim, BirimDTO>().ReverseMap();
                CreateMap<Birim, BirimToAddDTO>().ReverseMap();
                CreateMap<Birim, BirimToDeleteDTO>().ReverseMap();
                CreateMap<Birim, BirimToUpdateDTO>().ReverseMap();

                CreateMap<Grup, GrupDTO>().ReverseMap();
                CreateMap<Grup, GrupToAddDTO>().ReverseMap();
                CreateMap<Grup, GrupToDeleteDTO>().ReverseMap();
                CreateMap<Grup, GrupToUpdateDTO>().ReverseMap();

                CreateMap<Kampanya, KampanyaDTO>().ReverseMap();
                CreateMap<Kampanya, KampanyaToAddDTO>().ReverseMap();
                CreateMap<Kampanya, KampanyaToDeleteDTO>().ReverseMap();
                CreateMap<Kampanya, KampanyaToUpdateDTO>().ReverseMap();

                CreateMap<KampanyaSonuc, KampanyaSonucDTO>().ReverseMap();
                CreateMap<KampanyaSonuc, KampanyaSonucToAddDTO>().ReverseMap();
                CreateMap<KampanyaSonuc, KampanyaSonucToDeleteDTO>().ReverseMap();
                CreateMap<KampanyaSonuc, KampanyaSonucToUpdateDTO>().ReverseMap();


                CreateMap<Kullanici, KullaniciDTO>().ReverseMap();
                CreateMap<Kullanici, KullaniciToAddDTO>().ReverseMap();
                CreateMap<Kullanici, KullaniciToDeleteDTO>().ReverseMap();
                CreateMap<Kullanici, KullaniciToUpdateDTO>().ReverseMap();
                CreateMap<Kullanici, KullaniciToLoginDTO>().ReverseMap();
                CreateMap<Kullanici, KullaniciToRegisterDTO>().ReverseMap();

                CreateMap<Sablon, SablonDTO>().ReverseMap();
                CreateMap<Sablon, SablonToAddDTO>().ReverseMap();
                CreateMap<Sablon, SablonToDeleteDTO>().ReverseMap();
                CreateMap<Sablon, SablonToUpdateDTO>().ReverseMap();
            }
        }
    }
}
