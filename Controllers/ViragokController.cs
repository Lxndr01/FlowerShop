using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViragokAPI.DataBase;
using ViragokAPI.Models;

namespace ViragokAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViragokController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetViragok()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var viragok = await sql.viragok.OrderBy(a => a.id).ToListAsync();                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = viragok;
                }
                return Ok(response);
            } catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
                response.Data = ex;

            }
            return BadRequest(response);
        }


        [HttpPost]
        public async Task<IActionResult> AddVirag([FromBody] Viragok virag)
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    await sql.viragok.AddAsync(virag);
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
