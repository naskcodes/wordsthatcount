using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Filters;

namespace wordsthatcount.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistroController : ControllerBase
{
    private readonly DbContextWordsThatCount _wtcdbcontext;

    public RegistroController(DbContextWordsThatCount wtcdbcontext)
    {
        _wtcdbcontext = wtcdbcontext;
    }

    [HttpGet]
    public IActionResult Registros()
    {
        var retorno = _wtcdbcontext.Registros.AsNoTracking().OrderBy(p => p.dataRegistro).ToList();
        return Ok(retorno);
    }

    [HttpPost]
    public IActionResult RegistraRegistro([FromBody] Registro registro)
    {
        _wtcdbcontext.Registros.Add(registro);
        _wtcdbcontext.SaveChanges();
        return Ok(registro);
    }
}