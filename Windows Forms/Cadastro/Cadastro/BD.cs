using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    public class BD
    {
        // Aqui criaremos uma string de conexão com o banco de dados.
        public static string StringConexao
        {
            get //Obter a string
            {
                return @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\pedro.hdsantos4\Documents\BD_Projeto1.mdf; Integrated Security = True; Connect Timeout = 30";
            }
        }
    }
}
