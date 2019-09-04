using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Service.Core.DTO.School.Section;

namespace Section.Service.Core
{
    public interface ISectionService
    {
        Task CreateAsync(CreateSectionDTO Section);
        Task UpdateAsync(UpdateSectionDTO Section);
        Task DeleteAsync(Guid id);
        Task<SectionDTO> GetAsync(Guid id);
        Task<IEnumerable<SectionDTO>> GetAllAsync();
        Task<IEnumerable<SectionDTO>> SearchAsync(SearchSectionDTO filter, int pageFrom = 0, int limit = 0, string[] sortBy = null);


    }
}
