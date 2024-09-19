namespace CalculadoraBhaskara
{
    public static class Calculadora
    {
        public static (double?, double?) Raizes(double n1, double n2, double n3)
        {
            double Delta = (n2 * n2) - (4 * n1 * n3);

            if (Delta < 0)
            {
                return (null, null);
            }

            double deltaRaiz = Math.Sqrt(Delta);
            double x1 = (-n2 + deltaRaiz) / (2 * n1);
            double x2 = (-n2 - deltaRaiz) / (2 * n1);

            return (x1, x2);
        }
    }
}
