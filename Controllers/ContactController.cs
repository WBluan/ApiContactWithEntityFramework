using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Context;
using Api.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    //Ponto de entrada dos nossos métodos Http

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
        public async Task<IActionResult> Create([FromBody]Contact contact)
        {
            if(contact == null )
            {
                return BadRequest("Contact cannot be null.");
            }
            await _scheduleContext.AddAsync(contact); 
            await _scheduleContext.SaveChangesAsync();
            //adiciona a rota que o usuário pode acessar para obter o registro criado
            return CreatedAtAction(nameof(GetContactById), new {id = contact.Id}, contact);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetContactById(int id)
        {
            var contact = await _scheduleContext.Contact.FindAsync(id);
            if(contact== null)  
             return  NotFound();

            return Ok(contact);
        }

        [HttpGet("GetContacts")]
        public async Task<IActionResult> GetContacts()
        {
            List<Contact> contatcts = await _scheduleContext.Contact.ToListAsync();
            if(contatcts == null) 
             return NotFound();

            return Ok(contatcts); 
        }

        [HttpGet("GetContactByName")]
        public async Task<IActionResult> GetContactByName(string name)
        {
            var contacts =  await _scheduleContext.Contact
                .Where(c => c.Name.Contains(name))
                .ToListAsync();

            if(contacts == null)
                return  NotFound($"No contacts found with name containing '{name}'.");
            return Ok(contacts);
        }

    
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContact(int id, [FromBody]Contact contact)
        {
            var contactDb = await _scheduleContext.Contact.FindAsync(id);
            if(contactDb == null)
                return  NotFound();
            contactDb.Name = contact.Name;
            contactDb.Phone = contact.Phone;
            contactDb.Active = contact.Active;

            _scheduleContext.Contact.Update(contactDb);
           await _scheduleContext.SaveChangesAsync(); 
            return Ok(contactDb);
        }

        [HttpPatch("UpdateContact")]
        public async Task<IActionResult> UpdateContactData(int id, string nome, string phone, bool active)
        {
            var contact = await _scheduleContext.Contact.FindAsync(id);
            if(contact == null)
                return  NotFound();
            contact.Name = nome;
            contact.Phone = phone;
            contact.Active = active;

            _scheduleContext.Contact.Update(contact);
            await _scheduleContext.SaveChangesAsync();
            return Ok(contact); 
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            var contact = await _scheduleContext.Contact.FindAsync(id);
            if(contact == null)
                return  NotFound();

            _scheduleContext.Contact.Remove(contact);
           await  _scheduleContext.SaveChangesAsync();
            return NoContent();
        }
    } 
}