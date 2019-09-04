using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using School.Service.Core.DTO.School.Signature;

namespace School.Service.Core
{
    public interface ISignatureService
    {
        Task CreateAsync(CreateSignatureDTO Signature);
        Task UpdateAsync(UpdateSignatureDTO Signature);
        Task DeleteAsync(Guid id);
        Task<SignatureDTO> GetAsync(Guid id);
        Task<IEnumerable<SignatureDTO>> GetAllAsync();
        Task<IEnumerable<SignatureDTO>> SearchAsync(SearchSignatureDTO filter, int pageFrom = 0, int limit = 0, string[] sortBy = null);

    }
}
