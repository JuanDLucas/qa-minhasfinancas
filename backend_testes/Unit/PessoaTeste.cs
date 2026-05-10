using FluentAssertions;
using MinhasFinancas.Domain.Entities;
using Xunit;

namespace backend_testes.Unit;

public class PessoaTests
{
    [Fact]
    public void Pessoa_Maior_De_Idade_Deve_Retornar_True()
    {
        // Arrange
        var pessoa = new Pessoa
        {
            DataNascimento = DateTime.Now.AddYears(-20)
        };

        // Act
        var resultado = pessoa.EhMaiorDeIdade();

        // Assert
        resultado.Should().BeTrue();
    }

    [Fact]
    public void Pessoa_Menor_De_Idade_Deve_Retornar_False()
    {
        // Arrange
        var pessoa = new Pessoa
        {
            DataNascimento = DateTime.Now.AddYears(-15)
        };

        // Act
        var resultado = pessoa.EhMaiorDeIdade();

        // Assert
        resultado.Should().BeFalse();
    }
}