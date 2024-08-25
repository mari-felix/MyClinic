using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Medico
    {
        public int Id { get; set; }
        public string CRM { get; set; }
        public string Name { get; set; }
        public string Especialidade { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}