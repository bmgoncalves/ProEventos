using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;

    public EventoController(DataContext context)
    {
            _context = context;
    }
   

    [HttpGet]
    public List<Evento> Get()
    {
        return _context.Eventos.ToList();        
    }

    [HttpGet("{id}")]
    public Evento? GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);        
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
