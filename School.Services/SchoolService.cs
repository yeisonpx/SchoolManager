using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using School.Domain.Core;
using School.Service.Core;
using School.Service.Core.DTO.School;

namespace School.Services
{
    public class SchoolService : ISchoolService
    {
        private readonly ISchoolRepository _repository;
        private readonly IMapper _mapper;

        public SchoolService(ISchoolRepository schoolRepository,
            IMapper mapper)
        {
            this._repository = schoolRepository;
            this._mapper = mapper;
        }

        public async Task CreateAsync(CreateSchoolDTO schoolDto)
        {
            var school = _mapper.Map<Domain.School>(schoolDto);
            await this._repository.CreateAsync(school);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<SchoolDTO>> GetAllAsync()
        {
            var schoolds = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<SchoolDTO>>(schoolds);
        }

        public async Task<SchoolDTO> GetAsync(Guid id)
        {
            var school = await _repository.GetAsync(id);
            return _mapper.Map<SchoolDTO>(school);
        }

        public async Task<IEnumerable<SchoolDTO>> SearchAsync(SearchSchoolDTO filterDto, int pageFrom = 0, int limit = 0, string[] sortBy = null)
        {
            var filter = _mapper.Map<Domain.School>(filterDto);
            var schoolds = await _repository.SearchAsync(filter, pageFrom, limit, sortBy);
           return _mapper.Map<IEnumerable<SchoolDTO>>(schoolds);
        }

        public async Task UpdateAsync(UpdateSchoolDTO schoolDto)
        {
           var school = _mapper.Map<Domain.School>(schoolDto);
            await _repository.UpdateAsync(school);
        }
    }
}
