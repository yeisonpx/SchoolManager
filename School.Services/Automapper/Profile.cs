using System;
using School.Service.Core.DTO.School;
using School.Service.Core.DTO.School.Section;
using School.Service.Core.DTO.School.Signature;
using School.Service.Core.DTO.School.Teacher;

namespace School.Services.Automapper
{
    public class MapperProfile : AutoMapper.Profile
    {
        public MapperProfile()
        {
            this.CreateMap<Domain.Teacher, TeacherDTO>().ReverseMap();
            this.CreateMap<Domain.Teacher, CreateTeacherDTO>().ReverseMap();
            this.CreateMap<Domain.Teacher, UpdateTeacherDTO>().ReverseMap();
            this.CreateMap<Domain.Teacher, SearchTeacherDTO>().ReverseMap();

            this.CreateMap<Domain.School, SchoolDTO>().ReverseMap();
            this.CreateMap<Domain.School, CreateSchoolDTO>().ReverseMap();
            this.CreateMap<Domain.School, UpdateSchoolDTO>().ReverseMap();
            this.CreateMap<Domain.School, SearchSchoolDTO>().ReverseMap();

            this.CreateMap<Domain.Signature, SignatureDTO>().ReverseMap();
            this.CreateMap<Domain.Signature, CreateSignatureDTO>().ReverseMap();
            this.CreateMap<Domain.Signature, UpdateSignatureDTO>().ReverseMap();
            this.CreateMap<Domain.Signature, SearchSignatureDTO>().ReverseMap();

            this.CreateMap<Domain.Section, SectionDTO>().ReverseMap();
            this.CreateMap<Domain.Section, CreateSectionDTO>().ReverseMap();
            this.CreateMap<Domain.Section, UpdateSectionDTO>().ReverseMap();
            this.CreateMap<Domain.Section, SearchSectionDTO>().ReverseMap();
        }
    }
}
