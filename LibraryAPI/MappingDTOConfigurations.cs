using AutoMapper;
using LibraryAPI.Models;
using LibraryAPI.Models.DTOs;

namespace LibraryAPI
{
    public class MappingDTOConfigurations : Profile
    {
        public MappingDTOConfigurations() 
        {
            CreateMap<Book, CreateBookDTO>().ReverseMap();
        }
    }
}
