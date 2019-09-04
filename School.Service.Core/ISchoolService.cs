using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Service.Core.DTO.School;

namespace School.Service.Core
{
    public interface ISchoolService
    {
        Task CreateAsync(CreateSchoolDTO school);
        Task UpdateAsync(UpdateSchoolDTO school);
        Task DeleteAsync(Guid id);
        Task<SchoolDTO> GetAsync(Guid id);
        Task<IEnumerable<SchoolDTO>> GetAllAsync();
        Task<IEnumerable<SchoolDTO>> SearchAsync(SearchSchoolDTO filter, int pageFrom=0, int limit=0, string[] sortBy=null);
    }
}
