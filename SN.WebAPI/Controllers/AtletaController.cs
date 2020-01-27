using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SN.Repository;

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
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.atletas.ToListAsync();
                return Ok(results);   
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados falhou!");
            }
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var result = await _context.atletas.FirstOrDefaultAsync(x => x.Id == id);
                return Ok(result);   
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de Dados falhou!");
            }
        }
    }
}