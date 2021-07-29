using System;
using System.Collections.Generic;
using app_prova_prismatec.Extensions;
using app_prova_prismatec_Aplication.Services;
using app_prova_prismatec_Domain;
using app_prova_prismatec_Domain.Models;

namespace app_prova_prismatec
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.CreateLogger();
            Logger.PrintLog("Iniciando...");

            //TODO: Conforme a abordagem Domain Driven Design, crie uma instância e utilize a entidade "Empresa" e "Funcionario", populando suas propriedades.
            var empresa = FillEnterprise();
            var empresaService = new EmpresaService(empresa);
            Logger.PrintLog("Criando e preenchendo a entidade empresa e funcionario.");

            //TODO: Salve o objeto criado em formato .json em um arquivo local (pasta configurada no app settings).
            Logger.PrintLog("Criando Arquivo...");
            empresaService.CreateFile();
            Logger.PrintLog("Arquivo Criado.");

            //TODO: Altere os dados das propriedades e salve novamente o arquivo (o mesmo não pode ser sobrescrito).
            Logger.PrintLog("Alterando os valores das entidades empresa e funcionário...");
            empresaService.Update("43.881.369/0001-63", "Samuel Alves Ltda", "Samuel Técnologias", "16981442890");
            AlterEmployee(empresa);
            Logger.PrintLog("Entidades alteradas.");

            //TODO: Salve o objeto criado em formato .json em um arquivo local (pasta configurada no app settings).
            Logger.PrintLog("Criando o novo arquivo com as alterações feitas nas entidades empresa e funcionário...");
            empresaService.CreateFile();
            Logger.PrintLog("Arquivo criado com as alterações das entidades empresa e funcionário.");

            //TODO: Crie um método que verifica se no telefone da empresa, se o código da região é do RS (Utilize LINQ).
            Logger.PrintLog("Verificando se DDD do telefone infomado pertence ao RS...");
            Logger.PrintLog(empresaService.VerifyDDD());

            Logger.PrintLog("Finalizado...");

            //TODO: Imprima no console logs dos eventos de todas as ações realizadas no sistema.
            Console.ReadKey();
        }

        #region Metodos
        //Método que altera o funcionário
        private static void AlterEmployee(Empresa empresa)
        {
            foreach (var item in empresa.Funcionarios)
            {
                item.Alterar("38998756213", "Otávio Henrique", "1633081477", empresa.Id);
            }
        }
       
        //Método que cria e popula a empresa vinculando o funcionário a empresa
        private static Empresa FillEnterprise()
        {
            var idEmpresa = Guid.NewGuid();
            var funcionarios = FillEmployee(idEmpresa);
            var empresa = new Empresa(idEmpresa, "42.225.482/0001-28", "Luiz Fernando Ltda", "Luiz Fernando Soluções Informática", "1633381478", funcionarios);
            return empresa;
        }

        //Método que cria e popula o funcionario
        private static List<Funcionario> FillEmployee(Guid empresa)
        {
            return new List<Funcionario>()
            {
                new Funcionario(Guid.NewGuid(), "38697739873", "Luiz Fernando", empresa)
            };
        }
        #endregion
    }
}
