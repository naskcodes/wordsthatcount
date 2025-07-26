using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Back.Models;

namespace wordsthatcount.Controllers;

[Route("api/[controller]")]
[ApiController]

public class RegistroController : ControllerBase
{
    private readonly DbContextWordsThatCount _wtcdbcontext;

    public RegistroController(DbContextWordsThatCount wtcdbcontext)
    {
        _wtcdbcontext = wtcdbcontext;
    }

    [HttpPost]
    public IActionResult RegistraRegistro([FromBody] Registro registro)
    {
        _wtcdbcontext.Registros.Add(registro);
        _wtcdbcontext.SaveChanges();
        return Ok(registro);
    }
}