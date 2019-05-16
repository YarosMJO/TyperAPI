using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TyperAPI.BL.Services;
using TyperAPI.DAL.Models;
using TyperAPI.Shared.Dtos;

namespace TyperAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/words")]
    public class WordController : Controller
    {
        private readonly IMapper mapper;
        private readonly BaseService service;

        public WordController(IMapper mapper, BaseService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        //GET: /api/v1/words
        [HttpGet]
        public  async Task<IActionResult> Get()
        {
            var items = await Task.Run(() => service.GetAll<Word>());
            if (items != null) return Ok(items);
            return NoContent();
        }

        //GET: /api/v1/words/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await Task.Run(() => service.GetById<Word>(id));
            if (item != null) return Ok(item);
            return NoContent();
        }

        //PUT: /api/v1/words/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] WordDto entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => service.Update(mapper.Map<WordDto, Word>(entity)));
                    await service.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return Ok();
        }

        //POST: /api/v1/words
        [HttpPost("{id}")]
        public async Task<IActionResult> Post([FromBody] WordDto entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => service.Add(mapper.Map<WordDto, Word>(entity)));
                    await service.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return Ok();

        }

        //DELETE: /api/v1/words/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid) 
            {
                try
                {
                    await Task.Run(() => service.Remove<Word>(id));
                    await service.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }    
            }
            return Ok();
        }

    }
}