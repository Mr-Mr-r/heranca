using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Program
    {
        static void Main(string[] args)
        {
            client cpf = new client();
            pessoa nome= new pessoa();
            pessoa telefone= new pessoa();
            pessoa contato= new pessoa();
            Endereco endereco= new Endereco();
            nome.cadastrarNome();
            telefone.cadastrarTel();
            contato.cadastrarContato();
            endereco.cadastrarEndereco();
            endereco.exibirEndereco();
            nome.exibirNome();
            Console.ReadKey();
        }
        
    }
}
