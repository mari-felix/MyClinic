using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }
        public DateTime DataConsulta { get; set; }
    }
}