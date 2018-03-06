using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new InteropService.SOAPServiceClient();

            DENOVO:

            Console.WriteLine("Digite uma lista de CPF's: ");
            var listCpf = Console.ReadLine();

            Console.WriteLine("Agora digite seu CPF: ");
            var cpf = Console.ReadLine();

            var result = service.ConsultarCPFP3(listCpf, cpf);

            foreach (var item in result)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Nome: {0}", item.Nome);
                Console.WriteLine("CPF: {0}", item.CPF);
                Console.WriteLine("Municipio/UF: {0}/{1}", item.Municipio, item.UF);
                Console.WriteLine("----------------------------");
            }

            Console.WriteLine("");

            var foreColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Busca realizada com sucesso!!");

            Console.WriteLine("");

            Console.ForegroundColor = foreColor;

            Console.WriteLine("Pesquisar novamente..=> s");
            Console.WriteLine("sair.................=> qualquer tecla");

            var key = Console.ReadLine();

            if (key.ToLower() == "s")
            {
                Console.Clear();
                goto DENOVO;
            }
        }
    }
}
