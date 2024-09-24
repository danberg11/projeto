using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.model
{
    internal class escolinha
    {
        private static int id;
        private static string nome;
        private static int idade;
        private static string posicao;

        public static int Id { get => id; set => id = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static int Idade { get => idade; set => idade = value; }
        public static string Posicao { get => posicao; set => posicao = value; }
    }
}
