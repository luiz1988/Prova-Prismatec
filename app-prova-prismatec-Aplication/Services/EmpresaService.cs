using app_prova_prismatec_Aplication.Extensions;
using app_prova_prismatec_Aplication.Services.Interfaces;
using app_prova_prismatec_Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace app_prova_prismatec_Aplication.Services
{
    public class EmpresaService : IEmpresaService
    {
        private Empresa empresa;
        List<string> DDDRS = new List<string>() {"51","52","53","54","55"};

        #region Construtor
        public EmpresaService(Empresa _empresa)
        {
            empresa = _empresa;
        }
        #endregion

        #region Métodos
        //Método que cria um arquivo no formato passado
        public void CreateFile()
        {
            string path = Utils.DirectoryPathName();
            Utils.CreateFileJson(empresa, path);

        }

        //Método  que altera os os atributos da empresa
        public void Update(string cnpj, string razaoSocial, string nomeNomeFantasia, string telefone)
        {
            empresa.AlterEnterprise(razaoSocial, nomeNomeFantasia, telefone);
        }

        public string VerifyDDD()
        {
           return empresa.ValidPhoneCode(DDDRS);
        }

        #endregion
    }
}
