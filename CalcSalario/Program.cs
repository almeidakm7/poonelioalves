using System.Globalization;

int func, horasTrab;
double valorHora, salario;

func = int.Parse(Console.ReadLine());
horasTrab = int.Parse(Console.ReadLine());
valorHora = double.Parse(Console.ReadLine());

salario = valorHora * horasTrab;

Console.WriteLine($"Number = {func}");
Console.WriteLine($"Salary = R$" + salario.ToString("F2", CultureInfo.InvariantCulture));