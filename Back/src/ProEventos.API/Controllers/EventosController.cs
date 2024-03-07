using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

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
    public List<Evento> Get()
    {
        return _context.Eventos?.ToList();
    }

    [HttpGet("{id}")]
    public Evento? GetById(int id)
    {
#pragma warning disable CS8604 // Possible null reference argument.
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
#pragma warning restore CS8604 // Possible null reference argument.
    }

    [HttpPost]
    public string Post()
    {
        return "Exemplo Post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo Put com Id {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo Delete com Id {id}";
    }
  
}
