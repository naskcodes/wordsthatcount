using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;

namespace Back.Models;

public class DbContextWordsThatCount : DbContext
{
    public DbContextWordsThatCount(DbContextOptions<DbContextWordsThatCount> options) : base(options) { }
    public DbSet<Registro> Registros { get; set; }
}

public class Registro
{
    public int id { get; set; }
    public int palavras { get; set; }
    public string usuario { get; set; }
    public DateTime dataRegistro { get; set; }
}