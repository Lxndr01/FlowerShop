using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViragokAPI.DataBase;
using ViragokAPI.Models;

namespace ViragokAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViewController : ControllerBase
    {
        [HttpGet("vviragok")]
        public async Task<IActionResult> GetVViragok()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var vviragok = await sql.v_viragok.OrderBy(a => a.id).ToListAsync();
                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = vviragok;
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
        [HttpGet("vertekesites")]
        public async Task<IActionResult> GetVErtekesitesek()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var vviragok = await sql.v_ertekesitesek.OrderBy(a => a.id).ToListAsync();
                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = vviragok;
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
