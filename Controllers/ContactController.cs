using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Context;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ScheduleContext _scheduleContext;
        public ContactController(ScheduleContext scheduleContext)
        {
            _scheduleContext = scheduleContext;
        }
        //TODO adicionar crud na tabela de contatos

        [HttpPost("CreateContact")]
        public IActionResult Create(Contact contact)
        {
            _scheduleContext.Add(contact);
            _scheduleContext.SaveChanges();
            return Ok(contact);
        }

        [HttpGet("GetContactById")]
        public IActionResult GetContactById(int id)
        {
            var contato = _scheduleContext.Contact.Find(id);
            if(contato == null)  
             return NotFound();

            return Ok(contato);
        }
    } 
}