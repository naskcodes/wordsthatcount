using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace back
{
    class Registro
    {
        public int Id { get; set; }
        public int palavras { get; set; }
        public string usuario { get; set; }
        public DateTime dataRegistro { get; set; }

        public void ExibirRegistro()
        {
            Console.WriteLine($"Usuário: {usuario}");
            Console.WriteLine($"Data: {dataRegistro}");
            Console.WriteLine($"Palavras: {palavras}");
        }
    }
}
