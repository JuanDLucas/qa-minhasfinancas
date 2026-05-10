// using FluentAssertions;
// using MinhasFinancas.Domain.Entities;
// using Xunit;

// namespace backend_testes.Unit;

// public class TransacaoTests
// {
//     [Fact]
//     public void Transacao_Receita_Com_Categoria_Despesa_Deve_Lancar_Erro()
//     {
//         // Arrange
//         var categoria = new Categoria
//         {
//             Finalidade = Categoria.EFinalidade.Despesa
//         };

//         var transacao = new Transacao
//         {
//             Tipo = Transacao.ETipo.Receita
//         };

//         // Act
//         Action act = () => transacao.Categoria = categoria;

//         // Assert
//         act.Should().Throw<InvalidOperationException>();
//     }

//     [Fact]
//     public void Transacao_Despesa_Com_Categoria_Despesa_Deve_Passar()
//     {
//         // Arrange
//         var categoria = new Categoria
//         {
//             Finalidade = Categoria.EFinalidade.Despesa
//         };

//         var transacao = new Transacao
//         {
//             Tipo = Transacao.ETipo.Despesa
//         };

//         // Act
//         Action act = () => transacao.Categoria = categoria;

//         // Assert
//         act.Should().NotThrow();
//     }
// }