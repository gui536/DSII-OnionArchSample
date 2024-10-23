using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ChoreServices : IChoreService
    {
        private IChoreRepository _choreRepository;
        private readonly IMapper _mapper;
        public ChoreServices(IMapper mapper, IChoreRepository choreRepository)
        {
            _choreRepository = choreRepository;
            _mapper = mapper;
        }

        public async Task Add(ChoreDTO chore)
        {
            var mapChore = _mapper.Map<Chore>(chore);
            await _choreRepository.InsertAsync(mapChore);
        }

        public async Task<ChoreDTO> GetById(int? id)
        {
            var result = await _choreRepository.GetByIdAsync(id);
            return _mapper.Map<ChoreDTO>(result);
        }

        public async Task<IEnumerable<ChoreDTO>> GetAllByChoreId(int? ChoreId)
        {
            var result = await _choreRepository.GetAll();
            return _mapper.Map<IEnumerable<ChoreDTO>>(result);
        }

        public async Task Remove(ChoreDTO chore)
        {
            var mapChore = _choreRepository.GetByIdAsync(chore.Id).Result;
            await _choreRepository.DeleteAsync(mapChore);
        }

        public async Task Update(ChoreDTO chore)
        {
            var mapChore = _mapper.Map<Chore>(chore);
            await _choreRepository.UpdateAsync(mapChore);
        }
        public async Task<IEnumerable<ChoreDTO>> GetChores()
        {
            var result = await _choreRepository.GetAll();
            return _mapper.Map<IEnumerable<ChoreDTO>>(result);
        }

        public async Task<IEnumerable<ChoreDTO>> GetAllByUserId(int? userId)
        {
            var result = await _choreRepository.GetAllByUserId(userId);
            return _mapper.Map<IEnumerable<ChoreDTO>>(result);
        }
    }
}
