using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Listas
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Salario(double aumento)
        {
            Salary += Salary * aumento / 100;
        }

        public override string ToString()
        {
            return Id + ", " + Name + " , " + Salary.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
