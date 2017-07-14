namespace TestesSoftware.Domain.Models
{
    public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Email { get; private set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";

        public static class Factory
        {
            public static Cliente CriarNovo(int id, string nome, string sobrenome, string email)
            {
                return new Cliente
                {
                    Id = id,
                    Nome = nome,
                    Sobrenome = sobrenome,
                    Email = email
                };
            }
        }
    }
}
