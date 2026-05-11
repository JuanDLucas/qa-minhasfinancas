# Falha ao executar testes de integração com EF Core InMemory

## Como reproduzir

Executar:

```bash
dotnet test
```

com testes de integração utilizando `Microsoft.EntityFrameworkCore.InMemory`.

## Resultado esperado

Os testes de integração deveriam executar normalmente utilizando banco em memória.

## Resultado atual

O teste falha com erro:

```text
System.MissingMethodException
```

relacionado ao Entity Framework Core.

## Impacto

Os testes de integração ficam bloqueados devido a incompatibilidade/configuração de versões do EF Core no ambiente atual.