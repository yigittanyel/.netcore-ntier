using AutoMapper;
using FishingApp.Business.Services.Abstract;
using FishingApp.Business.Utilities.CustomExceptions;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.DataAccess.Repositories.Concrete;
using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.DTOs.Kullanici;
using FishingApp.Entity.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace FishingApp.Business.Services.Concrete
{
    public class KullaniciService : IKullaniciService
    {
        private readonly IKullaniciRepository _kullaniciRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public KullaniciService(IKullaniciRepository kullaniciRepository, IMapper mapper, IConfiguration configuration)
        {
            _kullaniciRepository = kullaniciRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public async Task<KullaniciDTO> AddKullanici(KullaniciToAddDTO kullaniciToAddDTO)
        {
            var addedKullanici = await _kullaniciRepository.Add(_mapper.Map<Kullanici>(kullaniciToAddDTO));

            return _mapper.Map<KullaniciDTO>(addedKullanici);
        }

        public async Task DeleteKullanici(int kullaniciId)
        {
            var kullaniciToDelete = await _kullaniciRepository.Get(x => x.Id == kullaniciId);

            if (kullaniciToDelete is null)
            {
                throw new NotFoundException();
            }

            await _kullaniciRepository.Delete(kullaniciToDelete);
        }

        public async Task<KullaniciDTO> GetKullanici(int kullaniciId)
        {
            var kullaniciToReturn = await _kullaniciRepository.Get(x => x.Id == kullaniciId);

            if (kullaniciToReturn is null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<KullaniciDTO>(kullaniciToReturn);
        }

        public async Task<List<KullaniciDTO>> GetKullanicis()
        {
            var kullanicisToReturn = await _kullaniciRepository.GetList();

            return _mapper.Map<List<KullaniciDTO>>(kullanicisToReturn);
        }
        public async Task<KullaniciDTO> UpdateKullanici(KullaniciToUpdateDTO kullaniciToUpdateDTO)
        {
            var kullanici = await _kullaniciRepository.Get(x => x.Id == kullaniciToUpdateDTO.Id);

            if (kullanici is null)
            {
                throw new NotFoundException();
            }

            var kullaniciToUpdate = _mapper.Map<Kullanici>(kullaniciToUpdateDTO);

            return _mapper.Map<KullaniciDTO>(await _kullaniciRepository.Update(kullaniciToUpdate));
        }
        public async Task<KullaniciDTO> Login(KullaniciToLoginDTO kullaniciToLoginDTO)
        {
            var kullanici = await _kullaniciRepository.Get(
                u => u.KullaniciAdi == kullaniciToLoginDTO.KullaniciAdi.ToLower() && u.Sifre == kullaniciToLoginDTO.Sifre);

            if (kullanici == null)
                return null;

            var kullaniciToReturn = _mapper.Map<KullaniciDTO>(kullanici);

            kullaniciToReturn.Token = GenerateToken(kullanici.Id, kullanici.KullaniciAdi);

            return kullaniciToReturn;
        }

        public async Task<KullaniciDTO> Register(KullaniciToRegisterDTO kullaniciToRegisterDTO)
        {
            kullaniciToRegisterDTO.KullaniciAdi = kullaniciToRegisterDTO.KullaniciAdi.ToLower();

            var addedKullanici = await _kullaniciRepository.Add(_mapper.Map<Kullanici>(kullaniciToRegisterDTO));

            var kullaniciToReturn = _mapper.Map<KullaniciDTO>(addedKullanici);
            kullaniciToReturn.Token  = GenerateToken(addedKullanici.Id, addedKullanici.KullaniciAdi);

            return kullaniciToReturn;
        }

        private string GenerateToken(int userId, string username)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, userId.ToString()),
            new Claim(ClaimTypes.Name, username)
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = creds
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
