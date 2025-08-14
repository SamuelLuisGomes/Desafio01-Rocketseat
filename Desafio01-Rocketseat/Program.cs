using Desafio01_Rocketseat;

Console.Write("Digite a placa de um veículo: ");
string placa = Console.ReadLine();

ValidacaoPlaca validaPlaca = new ValidacaoPlaca();
Console.WriteLine("");
Console.WriteLine($"a placa {placa} é {validaPlaca.Validacao(placa)}");








