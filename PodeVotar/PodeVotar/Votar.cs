namespace PodeVotar
{
    public static class Votar
    {
        public static string quemPodeVotar(int idade)
        {
            if (idade <= 15)
            {
                return "Proibido votar!";
            }
            else if (idade >= 16 && idade <= 17)
            {
                return "Voto opcional!";
            }
            else if (idade >= 18 && idade < 70)
            {
                return "Pode votar!";
            }
            else
            {
                return "Voto opcional!";
            }
        }
    }
}
