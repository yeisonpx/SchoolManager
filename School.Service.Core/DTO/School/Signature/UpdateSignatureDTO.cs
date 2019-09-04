using System;

namespace School.Service.Core.DTO.School.Signature
{
    public class UpdateSignatureDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description
        {
            get; set;
        }
    }
}