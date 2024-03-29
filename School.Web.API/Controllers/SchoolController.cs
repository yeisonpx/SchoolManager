﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using School.Service.Core;
using School.Service.Core.DTO.School;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace School.Web.API.Controllers
{
    [Route("api/v1/schools")]
    [ApiController]
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;

        public SchoolController(ISchoolService schoolService)
        {
            this._schoolService = schoolService;
        }
        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolDTO>>> Get()
        {
            var schools= await _schoolService.GetAllAsync();
            if (schools != null)
            {
                return Ok(schools);
            }
            return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolDTO>> Get(Guid id)
        {
            var schoold = await _schoolService.GetAsync(id);
            if (schoold != null)
            {
                return Ok(schoold);
            }
            return NotFound();
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Post([FromBody]CreateSchoolDTO schoolDTO )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _schoolService.CreateAsync(schoolDTO);
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put([FromBody]UpdateSchoolDTO schoolDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var schoold = await _schoolService.GetAsync(schoolDTO.Id);
            if (schoold != null)
            {
                await _schoolService.UpdateAsync(schoolDTO);
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
            var schoold = await _schoolService.GetAsync(id);
            if (schoold != null)
            {
                await _schoolService.DeleteAsync(id);
                return NoContent();
            }
            return NotFound();
        }
    }
}
