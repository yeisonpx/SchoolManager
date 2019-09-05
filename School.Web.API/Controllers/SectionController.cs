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
    [Route("api/v1/schools/sections")]
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
            var sections= await _sectionService.GetAllAsync();
            if (sections != null)
            {
                return Ok(sections);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SectionDTO>> Get(Guid id)
        {
            var section = await _sectionService.GetAsync(id);
            if (section != null)
            {
                return Ok(section);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateSectionDTO sectionDTO )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _sectionService.CreateAsync(sectionDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]UpdateSectionDTO sectionDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var section = await _sectionService.GetAsync(sectionDTO.Id);
            if (section != null)
            {
                await _sectionService.UpdateAsync(sectionDTO);
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
            var section = await _sectionService.GetAsync(id);
            if (section != null)
            {
                await _sectionService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
