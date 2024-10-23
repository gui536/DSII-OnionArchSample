using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IMapper mapper, IUserRepository userRepository)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        
        public async Task Add(UserDTO user)
        {
            var mapUser = _mapper.Map<User>(user);
            await _userRepository.InsertAsync(mapUser);
        }

        public async Task<UserDTO> GetById(int? id)
        {
            var result = await _userRepository.GetByIdAsync(id);
            return _mapper.Map<UserDTO>(result);
        }

        public async Task<IEnumerable<UserDTO>>GetUsers()
        {
            var result = await _userRepository.GetAll();
            return _mapper.Map<IEnumerable<UserDTO>>(result);

        }

        public async Task Remove(UserDTO user)
        {
            var mapUser = _userRepository.GetByIdAsync(user.Id).Result;
            await _userRepository.DeleteAsync(mapUser);
        }

        public async Task Update(UserDTO user)
        {
            var mapUser = _mapper.Map<User>(user);
            await _userRepository.UpdateAsync(mapUser);
        }
    }
}
