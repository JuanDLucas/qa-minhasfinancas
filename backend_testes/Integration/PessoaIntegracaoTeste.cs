using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using MinhasFinancas.Domain.Entities;
using MinhasFinancas.Infrastructure.Data;
using Xunit;

namespace backend_testes.Integration;

public class PessoaIntegracaoTests
{
    [Fact]
    public async Task Deve_Salvar_Pessoa_No_Banco_Em_Memoria()
    {
        // Arrange
        var options = new DbContextOptionsBuilder<MinhasFinancasDbContext>()
            .UseInMemoryDatabase(databaseName: "TesteDb")
            .Options;

        using var context = new MinhasFinancasDbContext(options);

        var pessoa = new Pessoa
        {
            Nome = "Juan",
            DataNascimento = DateTime.Now.AddYears(-20)
        };

        // Act
        context.Pessoas.Add(pessoa);
        await context.SaveChangesAsync();

        var pessoaSalva = await context.Pessoas.FirstOrDefaultAsync();

        // Assert
        pessoaSalva.Should().NotBeNull();
        pessoaSalva!.Nome.Should().Be("Juan");
    }
}