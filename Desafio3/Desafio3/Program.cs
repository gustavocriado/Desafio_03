using Desafio3.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alunos> alunos = new List<Alunos>();
            
            Console.WriteLine("Digite a quantidade de alunos: ");
            var quantidadeAlunos = Convert.ToInt32(Console.ReadLine());

            if (quantidadeAlunos > 0) 
            {
                for (int i = 0; i < quantidadeAlunos; i++)
                {
                    Alunos aluno = new Alunos();

                    Console.WriteLine("Digite o Nome do aluno: ");
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("\nDigite o nota do aluno: ");
                    aluno.Nota = Convert.ToDouble(Console.ReadLine());

                    alunos.Add(aluno);
                }
            }

            var maiorNota = alunos.Select(c => c.Nota).Max();
            Console.WriteLine($"O Aluno com maior nota é: {alunos.Where(x => x.Nota == maiorNota).Select(x => x.Nome).FirstOrDefault()} \n");
            Console.ReadKey();
        }
    }
}
