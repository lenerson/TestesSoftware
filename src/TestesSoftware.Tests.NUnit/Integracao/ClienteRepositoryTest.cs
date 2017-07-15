using NUnit.Framework;
using TestesSoftware.Infra.Repository.Repositories;

namespace TestesSoftware.Tests
{
    [TestFixture]
    public sealed class ClienteRepositoryTest
    {
        [Test]
        public void ConsultarTodosClientes()
        {
            var clientes = ClienteRepository.All();

            Assert.True(clientes.Count >= 0);
        }
    }
}
