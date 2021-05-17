using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjecttManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjecttManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthentificationController : ControllerBase
    {
        private readonly ProjectsDbContext _context;
        public AuthentificationController(ProjectsDbContext context)
        {
            _context = context;
        }

        [HttpPost("Register")]
        public async Task<ActionResult<Utilisateur>> RegisterUtilisateur(Utilisateur utilisateur)
        {
            _context.Utilisateurs.Add(utilisateur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetUtilisateur", new { id = utilisateur.UtilisateurId }, utilisateur);
        }
        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> LoginUtilisateur( string email, string password)
        {
            //var user = await _context.Utilisateurs.FromSqlRaw($"Select * from Utilisateurs where Email = {email}").ToListAsync();
            // Console.WriteLine(user);
            var result = _context.Utilisateurs.Where(e => e.Email == email);
            if (result.Count() == 0)
            {
                return BadRequest("Email Does Not Exists!");
            }
            if (result.First().Password != password)
            {
                return  BadRequest("Wrong Password");
            }
                    return Ok (result.First().UtilisateurId);
            
        }


    }
}
