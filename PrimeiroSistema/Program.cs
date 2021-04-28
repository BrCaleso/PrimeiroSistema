using System;

namespace PrimeiroSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno [5];
            string opcaousuario = ObterOpcaoUsuario();

            while (opcaousuario.ToUpper() != "X")
            {
                switch (opcaousuario)
                {
                    case "1":
                        //TODO: adicionar aluno
                        Console.Write("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");

                        aluno.Nota = decimal.Parse(Console.ReadLine());
                        // 10:42
                        break;

                    case "2":
                        //TODO: listar alunos
                        break;

                    case "3":
                        //TODO: calcular media geral
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaousuario = ObterOpcaoUsuario();
            }
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaousuario = Console.ReadLine();
            return opcaousuario;
        }
    }
}
