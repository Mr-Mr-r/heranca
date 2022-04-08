using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class pessoa
    {
        public string nome;
        public string telefone;
        public string contato;
        public Endereco endereco;



        public void cadastrarNome()
        {
            Console.WriteLine("Digite seu nome");
            nome = Console.ReadLine().ToUpper();

        }
        public void cadastrarTel()
        {
            Console.WriteLine("Digite seu telefone");
            telefone = Console.ReadLine().ToUpper();

        }
        public void cadastrarContato()
        {
            Console.WriteLine("Digite seu contato");
            contato = Console.ReadLine().ToUpper();

        }
        

        public void exibirNome()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("telefone: " + telefone);
            Console.WriteLine("contato: " + contato);
        }
        
    }
}
