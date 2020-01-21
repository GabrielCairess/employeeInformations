using System;
using System.Globalization;

namespace EmployeeInformations
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();

            Console.WriteLine("Digite os dados do funcionario: ");
            Console.Write("Nome:");
            e.Name = Console.ReadLine();
            Console.Write("Salario: ");
            e.Wage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            e.Duty = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: {0}, $ {1}", e.Name.ToString(), e.FreeWage().ToString());

            Console.WriteLine("Digite a porcentagem para aumentar o salario: ");
            double percentual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados Atualizados: {0}, $ {1}", e.Name, e.IncreaseWage(percentual));
        }
    }
}
