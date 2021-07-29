using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_prova_prismatec.Extensions
{
    public static class Logger
    {
        public static void CreateLogger()
        {
            Log.Logger = new LoggerConfiguration()
              .WriteTo.Console()
              .CreateLogger();
        }

        //Método que imprime o log no console
        public static void PrintLog(string msg)
        {
            Log.Information(msg);
        }
    }
}
