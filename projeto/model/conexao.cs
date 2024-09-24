using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.model
{
    internal class conexao
    {
        public static string Conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\daniel.bnoliveira\source\repos\projeto\projeto\dados\bdEscolinha.mdf;Integrated Security=True";
        }
    }
}
