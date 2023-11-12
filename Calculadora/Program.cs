using Calculadora.Services;

CalculadoraImp calc = new CalculadoraImp();

calc.Somar(1,2);
calc.Subtrair(12,5);
Thread.Sleep(5000);
calc.Multiplicar(3,6);
calc.Dividir(42,7);

foreach (var item in calc.Historico())
{
    Console.WriteLine(item);
}


