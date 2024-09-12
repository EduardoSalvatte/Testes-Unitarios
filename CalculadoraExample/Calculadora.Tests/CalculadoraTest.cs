using Xunit;

namespace Calculadora.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void Somar()
        {
            Assert.Equal(4, CalculadoraExample.Calculadora.Somar(2, 2));
        }

        [Fact]
        public void Subtrair()
        {
            Assert.Equal(4, CalculadoraExample.Calculadora.Subtrair(6, 2));
        }

        [Fact]
        public void Multiplicar()
        {
            Assert.Equal(10, CalculadoraExample.Calculadora.Multiplicar(5, 2));
        }

        [Fact]
        public void Dividir()
        {
            Assert.Equal(5, CalculadoraExample.Calculadora.Dividir(15, 3));
        }
    }
}