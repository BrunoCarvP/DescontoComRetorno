// See https://aka.ms/new-console-template for more information
using DescontoComRetorno;

Console.Write("Entre com um número: ");
double valor = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o desconto: ");
double desconto = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double resultado;


CalculoDesconto valor_desconto = new CalculoDesconto();

resultado = valor_desconto.Calculo(valor, desconto);
Console.WriteLine($"Com o valor de {valor:C2} e aplicando o desconto de {desconto:F1}% o valor final fica em {resultado:C2}");

