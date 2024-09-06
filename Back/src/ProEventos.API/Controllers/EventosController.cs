using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        private readonly DataContext _context;
        public EventosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos.ToArray();
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

        [HttpPost()]
        public IActionResult Create([FromBody] Evento evento)
        {
            if(evento != null)
            {
                _context.Eventos.Add(evento);
                _context.SaveChanges();
                return new CreatedResult("eventos", evento);

            }
            return new StatusCodeResult(412);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateById(int id)
        {
            if(id > 0)
            {
                Evento evento = _context.Eventos.FirstOrDefault(x => x.EventoId == id);
                _context.Eventos.Update(evento);
                _context.SaveChanges();
                return Ok("Atualizado");
            }

            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            if(id > 0)
            {
                Evento evento = _context.Eventos.FirstOrDefault(x => x.EventoId == id);
                _context.Eventos.Remove(evento);
                _context.SaveChanges();
                return Ok("Deletado");
            }
            
            return NotFound();
        }
    }
}
