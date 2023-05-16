﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodosBackEnd.Service.Todos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TodosBackEnd.Controllers
{
    [Route("v1/api/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodosService _todosService;
        public TodosController(ITodosService todosService)
        {
            _todosService = todosService;
        }
        // GET: api/<TodosController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_todosService.GetTodos());
        }

        // GET api/<TodosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TodosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TodosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TodosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
