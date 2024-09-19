namespace PodeVotar.Test
{
    public class VotarTest
    {
        [Fact]
        public void TestPodeVotar10()
        {
            int idade = 10;
            string esperado = "Não pode votar!";

            string obtido = Votar.quemPodeVotar(idade);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void TestPodeVotar16()
        {
            int idade = 16;
            string esperado = "Voto opcional!";

            string obtido = Votar.quemPodeVotar(idade);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void TestPodeVotar18()
        {
            int idade = 18;
            string esperado = "Pode votar!";

            string obtido = Votar.quemPodeVotar(idade);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void TestPodeVotar70()
        {
            int idade = 69;
            string esperado = "Voto opcional!";

            string obtido = Votar.quemPodeVotar(idade);

            Assert.Equal(esperado, obtido);
        }

        [Fact]
        public void TestPodeVotar90()
        {
            int idade = 90;
            string esperado = "Voto opcional!";

            string obtido = Votar.quemPodeVotar(idade);

            Assert.Equal(esperado, obtido);
        }
    }
}