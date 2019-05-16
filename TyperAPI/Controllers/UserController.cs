using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TyperAPI.BL.Services;
using TyperAPI.DAL.Models;
using TyperAPI.Shared.Dtos;

namespace TyperAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/v1/users")]
    public class UserController : Controller
    {
        private readonly IMapper mapper;
        private readonly BaseService service;

        public UserController(IMapper mapper, BaseService service)
        {
            this.mapper = mapper;
            this.service = service;
        }

        //GET: /api/v1/users
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var items = await Task.Run(() => service.GetAll<User>());
            if (items != null) return Ok(items);
            return NoContent();
        }

        //GET: /api/v1/users/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await Task.Run(() => service.GetById<User>(id));
            if (item != null) return Ok(item);
            return NoContent();
        }

        //PUT: /api/v1/users/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody] UserDto entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => service.Update(mapper.Map<UserDto, User>(entity)));
                    await service.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }
            return Ok();
        }

        //POST: /api/v1/users
        [HttpPost("{id}")]
        public async Task<IActionResult> Post([FromBody] UserDto entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => service.Add(mapper.Map<UserDto, User>(entity)));
                    await service.SaveChangesAsync();
                }
                catch (Exception)
                {
                    return BadRequest();
                }
            }

            return Ok();

        }

        //DELETE: /api/v1/users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await Task.Run(() => service.Remove<User>(id));
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