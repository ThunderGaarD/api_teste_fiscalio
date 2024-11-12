namespace api_teste_fiscalio.Services
{
    public class NumberToTextService
    {
        public string ConvertNumberToText(long number)
        {
            if (number == 0) // Se o número passado no EndPoint for igual a "0", retorna o texto "Zero"
                return "zero";
            else if (number >= 1000) // Tratar se algum engraçadinho inserir maior que 1000
            {
                return "Número inserido maior que 1000";
            } 
            
            string[] unidades = new string[] { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
            string[] dezenas = new string[] { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
            string[] centenas = new string[] { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

            string texto = "";

            // Verifica a parte das Centenas
            if (number >= 100)
            {
                int centena = (int)(number / 100);
                number %= 100; // Remove a parte das centenas
                if (centena > 1)
                    texto += centenas[centena] + " ";
                else if (centena == 1)
                    texto += "cento ";
            }

            // Verifica a parte das Dezenas
            if (number >= 20)
            {
                int dezena = (int)(number / 10);
                number %= 10;
                texto += dezenas[dezena] + " ";
            }
            // números Entre 10 a 19
            else if (number >= 10)
            {
                texto += unidades[(int)number];
                return texto.Trim();
            }

            // Verifica a parte das unidades
            if (number > 0)
            {
                texto += unidades[(int)number];
            }

            return texto.Trim(); // remover os espaços em branco
        }
    }
}
