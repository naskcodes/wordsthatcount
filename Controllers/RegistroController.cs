using wordsthatcount.Modelos;
using Microsoft.AspNetCore.Mvc;

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
    public IActionResult RegistraRegistro(Registro registro)
    {
        _wtcdbcontext.Registros.Add(registro);
        _wtcdbcontext.SaveChanges();
        return Ok(registro);
    }
}