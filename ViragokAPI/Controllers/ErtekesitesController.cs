using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ViragokAPI.DataBase;
using ViragokAPI.Models;

namespace ViragokAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ErtekesitesController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetErtekesitesek()
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    var ertekesitesek = await sql.ertekesitesek.OrderBy(a => a.id).ToListAsync(); 
                    response.StatusCode = 200;
                    response.Message = "Sikeres lekérdezés!";
                    response.Data = ertekesitesek;
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
        public async Task<IActionResult> AddErtekesites([FromBody] Ertekesites ertekesites)
        {
            APIResponse response = new APIResponse();
            try
            {
                using (SQL sql = new SQL())
                {
                    await sql.ertekesitesek.AddAsync(ertekesites);
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
