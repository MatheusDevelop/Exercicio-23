using System;
using System.Collections.Generic;
//Nesta atividade faça o mesmo exemplo dado em aula, incrementando com uma classe Cartao, com seus devidos métodos construtores e atributos: titular, numero, bandeira, vencimento e cvv;
// Crie uma lista de cartões no Program.cs, utilize foreach para mostrar para o usuário os cartões instanciados 
namespace Aula23
{
    class Program
    {
        // cria um Cartao.cs
        static void Main(string[] args)
        {
             List<Cartao> cartao = new List<Cartao>();

           
            
            cartao.Add(new Cartao("Henrique",6595,"VISA","30/05/2020","553"));

            cartao.Add(new Cartao("Barbosa",2525,"ELO","25/05/2020","552"));

           
            
            foreach (var item in cartao)
            {
                
                Console.WriteLine("Nome:.........{0,15}",item.titular);
                Console.WriteLine("Numero:.......{0,15}",item.numero);
                Console.WriteLine("Bandeira:.....{0,15}",item.bandeira);
                Console.WriteLine("Vencimento:...{0,15}",item.vencimento);
                Console.WriteLine("cvv:..........{0,15}\n",item.cvv);
            }

           
            




            
        }
    }
}
