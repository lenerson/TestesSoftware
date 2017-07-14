using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesSoftware.Infra.Repository.Repositories;

namespace TestesSoftware.Tests.MSTest.Integracao
{
    [TestClass]
    public sealed class ClienteRepositoryTest
    {
        [TestMethod]
        public void ConsultarTodosClientes()
        {
            var clientes = ClienteRepository.All();

            Assert.IsTrue(clientes.Count >= 0);
        }
    }
}
