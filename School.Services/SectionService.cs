using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using School.Domain.Core;
using School.Service.Core.DTO.School.Section;
using Section.Service.Core;

namespace Section.Services
{
    public class SectionService : ISectionService
    {
        private readonly ISectionRepository _repository;
        private readonly IMapper _mapper;

        public SectionService(ISectionRepository SectionRepository,
            IMapper mapper)
        {
            this._repository = SectionRepository;
            this._mapper = mapper;
        }

        public async Task CreateAsync(CreateSectionDTO SectionDto)
        {
            var section = _mapper.Map<School.Domain.Section>(SectionDto);
            await this._repository.CreateAsync(section);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<SectionDTO>> GetAllAsync()
        {
            var sections = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<SectionDTO>>(sections);
        }

        public async Task<SectionDTO> GetAsync(Guid id)
        {
            var section = await _repository.GetAsync(id);
            return _mapper.Map<SectionDTO>(section);
        }

        public async Task<IEnumerable<SectionDTO>> SearchAsync(SearchSectionDTO filterDto, int pageFrom = 0, int limit = 0, string[] sortBy = null)
        {
            var filter = _mapper.Map<School.Domain.Section>(filterDto);
            var sections = await _repository.SearchAsync(filter, pageFrom, limit, sortBy);
           return _mapper.Map<IEnumerable<SectionDTO>>(sections);
        }

        public async Task UpdateAsync(UpdateSectionDTO sectionDto)
        {
           var section = _mapper.Map<School.Domain.Section>(sectionDto);
            await _repository.UpdateAsync(section);
        }
    }
}
