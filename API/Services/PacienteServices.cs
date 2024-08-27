using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Context;
using API.Models;

namespace API.Services
{
    public class PacienteServices
    {
        private readonly ClinicContext _context;

        public PacienteServices() 
        {
            _context = new ClinicContext();
        }

        public async Task CriarPaciente(Paciente paciente) 
        {
            Random random= new Random();
            paciente.Id = random.Next(10000, 99999);

            var hoje = DateTime.Now;
            paciente.Idade = hoje.Year - paciente.DataNascimento.Year;

            _context.Pacientes.Add(paciente);
            await _context.SaveChangesAsync();
        }

        public async Task<Paciente> BuscarPaciente(string cpf)
        {
            var DB = _context.Pacientes;
            var paciente = await DB.FirstOrDefaultAsync(p => p.CPF == cpf);

            return paciente;
        } 

    }
}