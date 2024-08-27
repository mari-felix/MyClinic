using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Services
{
    public class ConsultaServices
    {
        private readonly ClinicContext _context;

        public ConsultaServices() 
        {
            _context = new ClinicContext();
        }

        public async Task MarcarConsulta(string pacienteCPF, string medicoCRM, DateTime dataConsulta)
        {
            var pacientesDB = _context.Pacientes;
            var medicosDB = _context.Medicos;

            var paciente = await pacientesDB.FirstOrDefaultAsync(p => p.CPF == pacienteCPF);
            var medico = await medicosDB.FirstOrDefaultAsync(m => m.CRM == medicoCRM);

            Consulta consulta = new Consulta();
            Random random = new Random();

            consulta.Id = random.Next(1000, 9999);
            consulta.Paciente = paciente;
            consulta.Medico = medico;
            consulta.DataConsulta = dataConsulta;

            paciente.Consultas.Add(consulta);
            medico.Consultas.Add(consulta);

            await _context.SaveChangesAsync();
        }
    }
}