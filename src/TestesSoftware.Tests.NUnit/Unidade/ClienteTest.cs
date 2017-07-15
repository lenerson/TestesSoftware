using NUnit.Framework;
using TestesSoftware.Domain.Models;

namespace TestesSoftware.Tests.NUnit.Unidade
{
    [TestFixture]
    public sealed class ClienteTest
    {
        [Test]
        public void CriarCliente()
        {
            var cliente = Cliente.Factory.Criar(1, "Lenerson", "V. Nunes", "lenerson.nunes@gmail.com");

            Assert.AreEqual(1, cliente.Id);
            Assert.AreEqual("Lenerson", cliente.Nome);
            Assert.AreEqual("V. Nunes", cliente.Sobrenome);
            Assert.AreEqual("lenerson.nunes@gmail.com", cliente.Email);
            Assert.AreEqual("Lenerson V. Nunes", cliente.NomeCompleto);
        }
    }
}
