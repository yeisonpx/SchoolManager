using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using School.Domain.Core;
using School.Service.Core;
using School.Service.Core.DTO.School.Signature;

namespace Signature.Services
{
    public class SignatureService : ISignatureService
    {
        private readonly ISignatureRepository _repository;
        private readonly IMapper _mapper;

        public SignatureService(ISignatureRepository SignatureRepository,
            IMapper mapper)
        {
            this._repository = SignatureRepository;
            this._mapper = mapper;
        }

        public async Task CreateAsync(CreateSignatureDTO SignatureDto)
        {
            var signature = _mapper.Map<School.Domain.Signature>(SignatureDto);
            await this._repository.CreateAsync(signature);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<SignatureDTO>> GetAllAsync()
        {
            var signatures = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<SignatureDTO>>(signatures);
        }

        public async Task<SignatureDTO> GetAsync(Guid id)
        {
            var signature = await _repository.GetAsync(id);
            return _mapper.Map<SignatureDTO>(signature);
        }

        public async Task<IEnumerable<SignatureDTO>> SearchAsync(SearchSignatureDTO filterDto, int pageFrom = 0, int limit = 0, string[] sortBy = null)
        {
            var filter = _mapper.Map<School.Domain.Signature>(filterDto);
            var signatures = await _repository.SearchAsync(filter, pageFrom, limit, sortBy);
           return _mapper.Map<IEnumerable<SignatureDTO>>(signatures);
        }

        public async Task UpdateAsync(UpdateSignatureDTO signatureDto)
        {
           var signature = _mapper.Map<School.Domain.Signature>(signatureDto);
            await _repository.UpdateAsync(signature);
        }
    }
}
