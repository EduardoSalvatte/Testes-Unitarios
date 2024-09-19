namespace Calculadora.Tests
{
    public class CalculadoraTeste
    {
        [Fact]
        public void RetornarDuasRaizes()
        {
            double n1 = 1, n2 = -3, n3 = 2;

            var result = CalculadoraBhaskara.Calculadora.Raizes(n1, n2, n3);

            Assert.Equal(2, result.Item1);
            Assert.Equal(1, result.Item2);
        }

        [Fact]
        public void RetornarNenhumaRaiz()
        {
            
            double n1 = 1, n2 = 2, n3 = 5;

            var result = CalculadoraBhaskara.Calculadora.Raizes(n1, n2, n3);

            Assert.Null(result.Item1);
            Assert.Null(result.Item2);
        }
    }
}