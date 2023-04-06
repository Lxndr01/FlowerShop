using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViragokAPI.DataBase;
using ViragokAPI.Models;

namespace ViragokAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViragKategoriaController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetViragKategoriak()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var viragkateg = await sql.viragKategoriak.OrderBy(a => a.id).ToListAsync(); 
                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = viragkateg;
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
                response.Data = ex;

            }
            return BadRequest(response);
        }


        [HttpPost]
        public async Task<IActionResult> AddViragKat([FromBody] ViragKategoria viragKategoria)
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    await sql.viragKategoriak.AddAsync(viragKategoria);
                    await sql.SaveChangesAsync();
                    response.StatusCode = 200;
                    response.Message = "Sikeres létrehozás!";
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
                response.Data = ex;

            }
            return BadRequest(response);
        }
    }
}
