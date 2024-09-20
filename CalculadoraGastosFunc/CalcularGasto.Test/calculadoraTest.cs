using CalculadoraGastosFunc.Models;

namespace CalcularGasto.Test
{
    public class calculadoraTest
    {
        [Fact]
        public void CalculadoraCTotal_Retornar()
        {
            // Arrange
            var funcionario = new Funcionario
            {
                Nome = "Eduardo",
                SalarioBase = 2000,
                Desconto = 500,
                Beneficio = 800
            };

            // Act
            var resultado = funcionario.CalcularCustoTotal();

            // Assert
            Assert.Equal(2300, resultado);
        }
    }
}