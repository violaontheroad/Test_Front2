using Test.Data;
using Test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Test.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _db;

        public UserController(DataContext db)
        {
            _db = db;
        }
          public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        

    }
}

// [HttpPost()]
//         public async Task<IActionResult> PostAsync(
//             [FromBody] User model,
//             [FromServices]DataContext context)
//         {
//            try
//            {
//                 await context.Users.AddAsync(model);
//                 await context.SaveChangesAsync();

//                 return RedirectToAction("Index");
//                 // return Created($"v1/users/{model.Id}", model);
//             }
//             catch (DbUpdateException ex)
//             {
//                 return StatusCode(500, "E003-Não foi possível incluir o Usuário");
//             }
//             catch (Exception ex)
//             {
//                 return StatusCode(500, "E004-Falha interna no servidor");
//             }
        