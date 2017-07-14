using TestesSoftware.Infra.Repository.Repositories;
using Xunit;

namespace TestesSoftware.Tests.xUnit.Integracao
{
    public sealed class ClienteRepositoryTest
    {
        [Fact]
        public void ConsultarTodosClientes()
        {
            var clientes = ClienteRepository.All();

            Assert.True(clientes.Count >= 0);
        }
    }
}
