using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Service.Core;
using School.Service.Core.DTO.School.Section;
using Section.Service.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Section.Web.API.Controllers
{
    [Route("api/v1/schoolds/sections")]
    [ApiController]
    public class SectionController : Controller
    {
        private readonly ISectionService _sectionService;

        public SectionController(ISectionService SectionService)
        {
            this._sectionService = SectionService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SectionDTO>>> Get()
        {
            var Sections= await _sectionService.GetAllAsync();
            if (Sections != null)
            {
                return Ok(Sections);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectionDTO>> Get(Guid id)
        {
            var Sectiond = await _sectionService.GetAsync(id);
            if (Sectiond != null)
            {
                return Ok(Sectiond);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateSectionDTO SectionDTO )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _sectionService.CreateAsync(SectionDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody]UpdateSectionDTO SectionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Sectiond = await _sectionService.GetAsync(SectionDTO.Id);
            if (Sectiond != null)
            {
                await _sectionService.UpdateAsync(SectionDTO);
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
            var Sectiond = await _sectionService.GetAsync(id);
            if (Sectiond != null)
            {
                await _sectionService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
