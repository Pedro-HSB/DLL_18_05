using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa
{
    public class Pessoa
    {
        public String nome;
        public String telefone;
        public String email;
        public String cpf;
        public String dataNasc;

        public void MonstraNome()
        {
            Console.WriteLine("Nome: " + nome);
            Console.ReadLine();
        }
    }
}
