using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_prova_prismatec_Aplication.Services.Interfaces
{
    public interface IEmpresaService
    {
        void CreateFile();
        void Update(string cnpj, string razaoSocial, string nomeNomeFantasia, string telefone);
        string VerifyDDD();
    }
}
