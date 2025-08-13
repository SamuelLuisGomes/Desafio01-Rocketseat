using System.Globalization;
using Desafio01_Rocketseat;

Console.WriteLine("Operações Matemáticas");
Console.WriteLine("===============================");

Console.Write("Digite o primeiro número: ");
double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite o segundo número: ");
double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("");


    double soma = OperacoesMatematicas.Soma(num1: n1, num2: n2);
    double subtracao = OperacoesMatematicas.Subtracao(num1: n1, num2: n2);
    double multiplicacao = OperacoesMatematicas.Multiplicacao(num1: n1, num2: n2);
    double divisao = OperacoesMatematicas.Divisao(num1: n1, num2: n2);
    double media = OperacoesMatematicas.Media(num1: n1, num2: n2);


    Console.WriteLine($"A soma dos valores é: {soma}");
    Console.WriteLine($"A subtração dos valores é: {subtracao}");
    Console.WriteLine($"A multiplicação dos valores é: {multiplicacao}");
    Console.WriteLine($"A divisão dos valores é: {divisao}");
    Console.WriteLine($"A média dos valores é: {media}");







