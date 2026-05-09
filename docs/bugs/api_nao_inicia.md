 # API não inicia

## O que aconteceu

Ao executar a API com `dotnet run`, a aplicação não inicia.

## Erro encontrado

```text
The property or navigation 'PessoaId' cannot be added...

## Como reproduzir

Entrar na pasta:

```bash
api/MinhasFinancas.API
```

Executar:

```bash
dotnet run
```

---

## Resultado esperado

A API deveria iniciar normalmente.

---

## Resultado atual

A aplicação encerra com erro do Entity Framework Core.

---

## Impacto

O frontend não consegue acessar a API e as funcionalidades ficam indisponíveis.