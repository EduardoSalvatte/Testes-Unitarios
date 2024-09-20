namespace CalcularSalario.Test
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularCustoTotal_DeveRetornarCustoCorreto()
        {
            // Arrange
            var funcionario = new Funcionario
            {
                Nome = "Edu",
                SalarioBase = 3000,
                Desconto = 500,
                Beneficio = 700
            };

            // Act
            var resultado = funcionario.CalcularCustoTotal();

            // Assert
            Assert.Equal(3200, resultado);
        }
    }
}