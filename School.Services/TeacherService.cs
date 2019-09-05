using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using School.Domain.Core;
using School.Service.Core;
using School.Service.Core.DTO.School.Teacher;

namespace Teacher.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository TeacherRepository,
            IMapper mapper)
        {
            this._repository = TeacherRepository;
            this._mapper = mapper;
        }

        public async Task CreateAsync(CreateTeacherDTO TeacherDto)
        {
            var teacher = _mapper.Map<School.Domain.Teacher>(TeacherDto);
            await this._repository.CreateAsync(teacher);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<TeacherDTO>> GetAllAsync()
        {
            var teachers = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
        }

        public async Task<TeacherDTO> GetAsync(Guid id)
        {
            var teacher = await _repository.GetAsync(id);
            return _mapper.Map<TeacherDTO>(teacher);
        }

        public async Task<IEnumerable<TeacherDTO>> SearchAsync(SearchTeacherDTO filterDto, int pageFrom = 0, int limit = 0, string[] sortBy = null)
        {
            var filter = _mapper.Map<School.Domain.Teacher>(filterDto);
            var teachers = await _repository.SearchAsync(filter, pageFrom, limit, sortBy);
           return _mapper.Map<IEnumerable<TeacherDTO>>(teachers);
        }

        public async Task UpdateAsync(UpdateTeacherDTO TeacherDto)
        {
           var teacher = _mapper.Map<School.Domain.Teacher>(TeacherDto);
            await _repository.UpdateAsync(teacher);
        }
    }
}
