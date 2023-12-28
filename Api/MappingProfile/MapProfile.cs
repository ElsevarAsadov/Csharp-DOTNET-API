using Api.Business.DTO.ProfessionDtos;
using Api.Business.DTO.WorkerDtos;
using Api.Core.Entities;
using AutoMapper;

namespace Api.MappingProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {

            CreateMap<ProfessionCreateDto, Profession>().ReverseMap();
            CreateMap<ProfessionGetDto, Profession>().ReverseMap();
            CreateMap<ProfessionUpdateDto, Profession>().ReverseMap();


            CreateMap<WorkerCreateDto, Worker>().ReverseMap();
            CreateMap<WorkerGetDto, Worker>().ReverseMap();
            CreateMap<WorkerUpdateDto, Worker>().ReverseMap();
        }
    }
}
