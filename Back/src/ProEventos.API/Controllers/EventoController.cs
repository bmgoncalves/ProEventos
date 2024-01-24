using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public EventoController()
    {
       
    }
   

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;        
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);        
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


    private IEnumerable<Evento> _evento = new Evento[]{
            new (){
                EventoId = 1,
                Tema = "Angular 11 e .NET 6",
                Local = "Belo Horizonte",
                DataEvento = DateTime.Now.AddDays(2).ToShortDateString(),
                QtdPessoas = 250,
                Lote = "1º Lote",
                ImagemURL = "foto.png"
            },
            new (){
                EventoId = 2,
                Tema = "Angular RxJs",
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(2).ToShortDateString(),
                QtdPessoas = 350,
                Lote = "1º Lote",
                ImagemURL = "foto.png"
            }
    };
}
