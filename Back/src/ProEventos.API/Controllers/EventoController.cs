using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .Net 5",
                Local = "Santos",
                Lote = "1º Lote",
                QtdPessoas = 200,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 12 e .Net 6",
                Local = "São Vicente",
                Lote = "3º Lote",
                QtdPessoas = 340,
                DataEvento = DateTime.Now.AddDays(5).ToString(),
                ImagemURL = "foto.jpeg"
            }
        };

        [HttpGet]
        public IEnumerable<Evento> Get() {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id) {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public String Post() {
            return "Exemplo POST";
        }

        [HttpPut("{id}")]
        public String Put(int id) {
            return $"Exemplo PUT com id = {id}";
        }

        [HttpDelete("{id}")]
        public String Delete(int id) {
            return $"Exemplo DELETE com id = {id}";
        }
    }
}
