using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Service.Core;
using School.Service.Core.DTO.School.Signature;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Signature.Web.API.Controllers
{
    [Route("api/v1/schoolds/signatures")]
    [ApiController]
    public class SignatureController : Controller
    {
        private readonly ISignatureService _signatureService;

        public SignatureController(ISignatureService SignatureService)
        {
            this._signatureService = SignatureService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SignatureDTO>>> Get()
        {
            var Signatures= await _signatureService.GetAllAsync();
            if (Signatures != null)
            {
                return Ok(Signatures);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SignatureDTO>> Get(Guid id)
        {
            var Signatured = await _signatureService.GetAsync(id);
            if (Signatured != null)
            {
                return Ok(Signatured);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateSignatureDTO SignatureDTO )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _signatureService.CreateAsync(SignatureDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody]UpdateSignatureDTO SignatureDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Signatured = await _signatureService.GetAsync(SignatureDTO.Id);
            if (Signatured != null)
            {
                await _signatureService.UpdateAsync(SignatureDTO);
                return NoContent();
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Signatured = await _signatureService.GetAsync(id);
            if (Signatured != null)
            {
                await _signatureService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
