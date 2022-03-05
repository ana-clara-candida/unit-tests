using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTeste;

namespace TestProject1
{
    [TestClass]
    public class testMSTest
    {
        [TestMethod]
        public void SomardoisNumeros()
        {
            double num1 = 1;
            double num2 = 1;

            var resultado = Operacoes.Somar(num1, num2);

            Assert.AreEqual(2, resultado);
        }
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(1, 1, 3)]
        [DataRow(1, 2, 3)]
        public void SomarRow(double num1, double num2, double resultado)
        {
            var res = Operacoes.Somar(num1, num2);
            Assert.AreEqual(resultado, res);
        }
    }
}