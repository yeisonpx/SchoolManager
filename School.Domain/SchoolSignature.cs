using System;
namespace School.Domain
{
    public class SchoolSignature
    {
        public Guid SchoolId { get; set; }
        public School School { get; set; }
        public Guid SignatureId { get; set; }
        public Signature Signature { get; set; }
        public int Credits { get; set; }
    }
}
