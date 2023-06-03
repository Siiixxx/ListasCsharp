using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio_Listas;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quantos funcionários vão ser cadastrados? ");
        int n = int.Parse(Console.ReadLine());
        List<Funcionario> lstfuncionario = new List<Funcionario>();

        for(int i = 1; i <=n; i++)
        {
            Console.WriteLine("Funcionário #" + i + ":");
            Console.Write("ID:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome:");
            string name = Console.ReadLine();
            Console.Write("Digite o salário:");
            double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            lstfuncionario.Add(new Funcionario(id, name, salario));
            Console.WriteLine();
        }

        Console.WriteLine("Entre com o número do ID:");
        int PID = int.Parse(Console.ReadLine());

        Funcionario funcionario = lstfuncionario.Find(X => X.Id == PID);
        if(funcionario != null)
        {
            Console.Write("Entre com a porcentagem: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.Salario(porcentagem);
        }
        else
        {
            Console.WriteLine("Id de funcionário não exister");
        }
        Console.WriteLine();
        Console.WriteLine("Atualizado lista de funcionários");
        foreach(Funcionario obj in lstfuncionario)
        {
            Console.WriteLine(obj);
        }


    }
}