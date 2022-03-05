using ProjetoTeste;
using Xunit;

namespace TesteXUnit
{
    public class testXUnit
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            double num1 = 1;
            double num2 = 1;
            var resultado = Operacoes.Somar(num1, num2);
            Assert.Equal(2, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(1, 1, 3)]
        [InlineData(1, 2, 3)]
        public void SomarLista(double num1, double num2, double resultado)
        {
            var res = Operacoes.Somar(num1, num2);
            Assert.Equal(resultado, res);
        }
    }   
}