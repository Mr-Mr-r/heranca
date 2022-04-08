using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja
{
    class Endereco
    {
        public string cep;
        public string logradouro;
        public int numero;
        public string complemento;
        public string bairro;
        public string cidade;
        public string estado;

        public void cadastrarEndereco()
        {
            Console.WriteLine("Digite seu cep");
            cep = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu logradouro");
            logradouro = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu numero");
            numero =int.Parse( Console.ReadLine().ToUpper());
            Console.WriteLine("Digite seu complemento");
            complemento = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu bairro");
            bairro = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu cidade");
            cidade = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite seu estado");
            estado = Console.ReadLine().ToUpper();

        }
        public void exibirEndereco()
        {
            Console.WriteLine("cep:" + cep);
            Console.WriteLine("logradouro: " + logradouro);
            Console.WriteLine("numero: " + numero);
            Console.WriteLine("complemento: " + complemento);
            Console.WriteLine("bairro" + bairro);
            Console.WriteLine("cidade" + cidade);
            Console.WriteLine("estado" + estado);
        }
    }
}
