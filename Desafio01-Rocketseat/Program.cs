Console.Write("Digite seu primeiro nome: ");
string primeiroNome = Console.ReadLine();
Console.Write("Digite seu sobrenome: ");
string sobrenome = Console.ReadLine();

string nomeCompleto = primeiroNome + " " + sobrenome;

Console.WriteLine("");

Console.WriteLine($"Seu nome completo é: {nomeCompleto}");