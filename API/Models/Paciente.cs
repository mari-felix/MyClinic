using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Paciente
    {
        public int Id { get; set;}
        public string CPF { get; set;}
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public List<Consulta> Consultas { get; set; } 
        public DateTime UltimaConsulta { get; set; }

    }
}