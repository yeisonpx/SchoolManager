using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Service.Core;
using School.Service.Core.DTO.School.Teacher;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Teacher.Web.API.Controllers
{
    [Route("api/v1/schools/teachers")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService TeacherService)
        {
            this._teacherService = TeacherService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TeacherDTO>>> Get()
        {
            var Teachers= await _teacherService.GetAllAsync();
            if (Teachers != null)
            {
                return Ok(Teachers);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDTO>> Get(Guid id)
        {
            var Teacherd = await _teacherService.GetAsync(id);
            if (Teacherd != null)
            {
                return Ok(Teacherd);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateTeacherDTO TeacherDTO )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _teacherService.CreateAsync(TeacherDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody]UpdateTeacherDTO TeacherDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var Teacherd = await _teacherService.GetAsync(TeacherDTO.Id);
            if (Teacherd != null)
            {
                await _teacherService.UpdateAsync(TeacherDTO);
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
            var Teacherd = await _teacherService.GetAsync(id);
            if (Teacherd != null)
            {
                await _teacherService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
