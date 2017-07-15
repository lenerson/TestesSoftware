using TestesSoftware.Domain.Models;
using Xunit;

namespace TestesSoftware.Tests.xUnit.Unidade
{
    public sealed class ClienteTest
    {
        [Fact]
        public void CriarCliente()
        {
            var cliente = Cliente.Factory.Criar(1, "Lenerson", "V. Nunes", "lenerson.nunes@gmail.com");

            Assert.Equal(1, cliente.Id);
            Assert.Equal("Lenerson", cliente.Nome);
            Assert.Equal("V. Nunes", cliente.Sobrenome);
            Assert.Equal("lenerson.nunes@gmail.com", cliente.Email);
            Assert.Equal("Lenerson V. Nunes", cliente.NomeCompleto);
        }
    }
}
