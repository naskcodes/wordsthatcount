namespace WordsThatCount.Models;

internal class Registro
{
    public Registro(Usuario usuario, int palavras, DateTime data)
    {
        Usuario = usuario;
        Palavras = palavras;
        DataRegistro = data;
    }

    public int Palavras { get; }
    public Usuario Usuario { get; }
    public DateTime DataRegistro { get; }
}