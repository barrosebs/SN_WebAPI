using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SN.WebAPI.Data;
using SN.WebAPI.Model;
using Microsoft.AspNetCore.Http;

namespace SN.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtletaController : ControllerBase
    {
        public DataContext _context { get; }
        public AtletaController(DataContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var results = _context.atletas.ToList();
                return Ok(results);   
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados falhou!");
            }
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_context.atletas.FirstOrDefault(x => x.Id == id));   
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados falhou!");
            }
        }
    }
}