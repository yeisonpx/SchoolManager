using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Service.Core.DTO.School.Teacher;

namespace School.Service.Core
{
    public interface ITeacherService
    {
        Task CreateAsync(CreateTeacherDTO Teacher);
        Task UpdateAsync(UpdateTeacherDTO Teacher);
        Task DeleteAsync(Guid id);
        Task<TeacherDTO> GetAsync(Guid id);
        Task<IEnumerable<TeacherDTO>> GetAllAsync();
        Task<IEnumerable<TeacherDTO>> SearchAsync(SearchTeacherDTO filter, int pageFrom = 0, int limit = 0, string[] sortBy = null);

    }
}
