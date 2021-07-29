using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_prova_prismatec_Domain.Models
{
    public class Funcionario
    {
        public Guid Id { get; private set; }
        public string Cpf { get; private set; }
        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public Guid IdEmpresa { get; private set; }
        public Funcionario(Guid id, string cpf, string nome, Guid idEmpresa)
        {
            Id = id;
            Cpf = cpf;
            Nome = nome;
            IdEmpresa = idEmpresa;
        }
        public void Alterar(string cpf, string nome,string telefone, Guid idEmpresa)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
            this.IdEmpresa = idEmpresa;
        }
    }
}
