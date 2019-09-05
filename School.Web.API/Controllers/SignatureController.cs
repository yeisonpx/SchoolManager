using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Service.Core;
using School.Service.Core.DTO.School.Signature;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Signature.Web.API.Controllers
{
    [Route("api/v1/schools/signatures")]
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
            var signatures= await _signatureService.GetAllAsync();
            if (signatures != null)
            {
                return Ok(signatures);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SignatureDTO>> Get(Guid id)
        {
            var signature = await _signatureService.GetAsync(id);
            if (signature != null)
            {
                return Ok(signature);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateSignatureDTO signatureDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _signatureService.CreateAsync(signatureDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]UpdateSignatureDTO signatureDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var signature = await _signatureService.GetAsync(signatureDTO.Id);
            if (signature != null)
            {
                await _signatureService.UpdateAsync(signatureDTO);
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
            var signature = await _signatureService.GetAsync(id);
            if (signature != null)
            {
                await _signatureService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
