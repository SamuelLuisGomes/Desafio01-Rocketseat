namespace Desafio01_Rocketseat
{
    public class ValidacaoPlaca
    {
        public string Validacao(string placa)
        {
            string placaFinal = LimpandoPlaca(placa);

            if (!placaFinal.Contains("Falso"))
            {
                string letras = placaFinal.Substring(0, 3);
                string numeros = placaFinal.Substring(3, 4);

                if (letras.All(char.IsLetter) && int.TryParse(numeros, out _))
                {
                    return "Verdadeiro";
                }
                else
                {
                    return "Falso";
                }
            }
            return "Falso";

        }
        public string LimpandoPlaca(string txt)
        {
            string placa = txt.Trim();
            if (placa.Contains('-'))
            {
                placa = txt.Replace("-", "");
            }
            if (placa.Length < 7 || placa.Length > 7)
            {
                return "Falso";
            }
            return placa;
        }
    }
}
