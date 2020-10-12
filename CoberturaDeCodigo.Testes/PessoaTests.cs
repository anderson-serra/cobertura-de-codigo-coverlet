using CoberturaDeCodigo.App;
using NUnit.Framework;

namespace CoberturaDeCodigo.Testes
{
    [TestFixture]
    public class PessoaTests
    {
        [Test]
        public void ToString_DeveGarantirQueNuncaRetorneNulo()
        {
            var pessoa = new Pessoa();
            var sut = pessoa.ToString();

            Assert.IsNotNull(sut);
        }

        [TestCase("Anderson", null, "Anderson")]
        [TestCase(null, "Serra", "Serra")]
        [TestCase("Anderson", "Serra", "Anderson Serra")]
        public void ToString_DeveGarantirQueNuncaRetorneNulo(string nome, string sobrenome, string esperado)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = nome;
            pessoa.Sobrenome = sobrenome;

            var resultado = pessoa.ToString();

            Assert.AreEqual(esperado, resultado);
        }
    }
}
