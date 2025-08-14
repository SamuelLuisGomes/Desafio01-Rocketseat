using System.Globalization;
using Desafio01_Rocketseat;

Console.WriteLine("Data atual:");
DateTime data = DateTime.UtcNow;

var dataLocal = data.ToLocalTime();
CultureInfo culturaBrasileira = new CultureInfo("pt-BR");


Console.WriteLine($"Formato completo: {culturaBrasileira.DateTimeFormat.GetDayName(dataLocal.DayOfWeek)},{dataLocal.Day}, {dataLocal.Month}, {dataLocal.Year}, {dataLocal.Hour},{dataLocal.Minute},{dataLocal.Second}");
Console.WriteLine($"Apenas data: {dataLocal.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Apenas a hora: {dataLocal.Hour}:{dataLocal.Minute}");
Console.WriteLine($"Data com mês por extenso: {data.ToString("dd/MMMM/yyyy")}");








