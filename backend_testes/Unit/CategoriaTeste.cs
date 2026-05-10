using FluentAssertions;
using MinhasFinancas.Domain.Entities;
using Xunit;

namespace backend_testes.Unit;

public class CategoriaTests
{
    [Fact]
    public void Categoria_Despesa_Deve_Permitir_Apenas_Despesa()
    {
        // Arrange
        var categoria = new Categoria
        {
            Finalidade = Categoria.EFinalidade.Despesa
        };

        // Act
        var permiteDespesa = categoria.PermiteTipo(Transacao.ETipo.Despesa);
        var permiteReceita = categoria.PermiteTipo(Transacao.ETipo.Receita);

        // Assert
        permiteDespesa.Should().BeTrue();
        permiteReceita.Should().BeFalse();
    }

    [Fact]
    public void Categoria_Receita_Deve_Permitir_Apenas_Receita()
    {
        // Arrange
        var categoria = new Categoria
        {
            Finalidade = Categoria.EFinalidade.Receita
        };

        // Act
        var permiteReceita = categoria.PermiteTipo(Transacao.ETipo.Receita);
        var permiteDespesa = categoria.PermiteTipo(Transacao.ETipo.Despesa);

        // Assert
        permiteReceita.Should().BeTrue();
        permiteDespesa.Should().BeFalse();
    }

    [Fact]
    public void Categoria_Ambas_Deve_Permitir_Todos_Tipos()
    {
        // Arrange
        var categoria = new Categoria
        {
            Finalidade = Categoria.EFinalidade.Ambas
        };

        // Act
        var permiteReceita = categoria.PermiteTipo(Transacao.ETipo.Receita);
        var permiteDespesa = categoria.PermiteTipo(Transacao.ETipo.Despesa);

        // Assert
        permiteReceita.Should().BeTrue();
        permiteDespesa.Should().BeTrue();
    }
}