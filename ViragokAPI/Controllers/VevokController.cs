using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViragokAPI.DataBase;
using ViragokAPI.Models;

namespace ViragokAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VevokController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetVevok()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var vevok =  await sql.vevok.OrderBy(a => a.email).ToListAsync();
                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = vevok;
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
        public async Task<IActionResult> AddVevo([FromBody] Vevok vevo)
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    await sql.vevok.AddAsync(vevo);
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
