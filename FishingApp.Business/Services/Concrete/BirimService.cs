using AutoMapper;
using FishingApp.Business.Services.Abstract;
using FishingApp.Business.Utilities.CustomExceptions;
using FishingApp.DataAccess.Repositories.Abstract;
using FishingApp.Entity.DTOs.Birim;
using FishingApp.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingApp.Business.Services.Concrete
{
    public class BirimService : IBirimService
    {
        private readonly IBirimRepository _birimRepository;
        private readonly IMapper _mapper;

        public BirimService(IBirimRepository birimRepository, IMapper mapper)
        {
            _birimRepository = birimRepository;
            _mapper = mapper;
        }

        public async Task<BirimDTO> AddBirim(BirimToAddDTO birimToAddDTO)
        {
            var addedUser = await _birimRepository.Add(_mapper.Map<Birim>(birimToAddDTO));

            return _mapper.Map<BirimDTO>(addedUser);
        }

        public async Task DeleteBirim(int birimId)
        {
            var birimToDelete = await _birimRepository.Get(x => x.Id == birimId);

            if (birimToDelete is null)
            {
                throw new NotFoundException();
            }

            await _birimRepository.Delete(birimToDelete);
        }

        public async Task<BirimDTO> GetBirim(int birimId)
        {
            var birimToReturn = await _birimRepository.Get(x => x.Id == birimId);

            if (birimToReturn is null)
            {
                throw new NotFoundException();
            }

            return _mapper.Map<BirimDTO>(birimToReturn);
        }

        public async Task<List<BirimDTO>> GetBirims()
        {
            var birimsToReturn = await _birimRepository.GetList();

            return _mapper.Map<List<BirimDTO>>(birimsToReturn);
        }

        public async Task<BirimDTO> UpdateBirim(BirimToUpdateDTO birimToUpdateDTO)
        {
            var birim = await _birimRepository.Get(x => x.Id == birimToUpdateDTO.Id);

            if (birim is null)
            {
                throw new NotFoundException();
            }

            var birimToUpdate = _mapper.Map<Birim>(birimToUpdateDTO);

            return _mapper.Map<BirimDTO>(await _birimRepository.Update(birimToUpdate));
        }
    }
}
