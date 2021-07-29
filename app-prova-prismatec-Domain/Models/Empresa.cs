using app_prova_prismatec_Domain.Models;
using System;
using System.Collections.Generic;

namespace app_prova_prismatec_Domain
{
    public class Empresa
    {
        public Guid Id { get; private set; }

        public string Cnpj { get; private set; }

        public string RazaoSocial { get; private set; }

        public string NomeFantasia { get; private set; }

        public string Telefone { get; private set; }

        public IList<Funcionario> Funcionarios { get; private set; }
        public Empresa(Guid id, string cnpj, string razaoSocial, string nomeFantasia, string telefone, List<Funcionario> funcionarios)
        {
            Id = id;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
            NomeFantasia = nomeFantasia;
            Telefone = telefone;
            Funcionarios = funcionarios;
        }

        public void CreateEmployee(Funcionario func)
        {
            this.Funcionarios.Add(func);
        }

        public void AlterEnterprise(string razaoSocial, string nomeFantasia, string telefone)
        {
            this.RazaoSocial = razaoSocial;
            this.NomeFantasia = nomeFantasia;
            this.Telefone = telefone;
        }

        public string ValidPhoneCode(List<string> dddRS)
        {
            if (dddRS.Contains(this.Telefone.Substring(0, 2)))
                return $"O DDD '{this.Telefone.Substring(0, 2)}' pertence ao RS.";

            else
                return $"O DDD '{this.Telefone.Substring(0, 2)}' não pertence ao RS.";
        }
    }
}
