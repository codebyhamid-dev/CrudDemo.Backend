using AutoMapper;
using CrudDemo.Backend.CrudDemo.Contracts;
using CrudDemo.Backend.CrudDemo.Domain;

namespace CrudDemo.Backend.CrudDemo.Application
{
    public class StudentMappingProfile:Profile
    {
        public StudentMappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<StudentCreateDto,Student>().ReverseMap();
            CreateMap<StudentUpdateDto,Student>().ReverseMap();
        }
    }
}
