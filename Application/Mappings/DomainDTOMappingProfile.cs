using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
 /*Criação dos mapeamentos para o automapper,
  * o reverse map possibilita que esse mapeamento seja two-way
  * Isso, é, tanto de Chore pra ChoreDTO como de ChoreDTO para Chore
  * O mesmo vale para o User e UserDTO*/

    public class DomainDTOMappingProfile : Profile
    {
        public DomainDTOMappingProfile() {
            CreateMap<Chore, ChoreDTO>().ReverseMap();
            CreateMap<User, UserDTO>().ReverseMap();
        }
    }
}
