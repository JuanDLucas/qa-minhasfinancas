# QA Automation - Minhas Finanças

## Objetivo

Este repositório contém os testes automatizados do sistema Minhas Finanças.

Os testes foram divididos em:
- testes unitários
- testes de integração
- testes end-to-end

Seguindo as regras do desafio:
- não alterar o código da aplicação
- não subir o código original
- documentar bugs encontrados

---

# Estrutura do Projeto

```text
backend_testes/
e2e-testes/
docs/bugs/
```

- `backend_testes/`
  Testes backend utilizando xUnit.

- `e2e-testes/`
  Testes end-to-end utilizando Playwright.

- `docs/bugs/`
  Documentação dos bugs encontrados durante os testes e inspeções manuais.

---

# Estratégia de Testes

## Testes Unitários

Focados nas regras de negócio:
- menor de idade
- validação de categorias
- permissões de tipos de transação

## Testes de Integração

Focados na integração entre:
- Entity Framework Core
- persistência
- banco em memória

## Testes End-to-End

Focados nos principais fluxos:
- carregamento da aplicação
- navegação inicial
- validação da interface

---

# Bugs Encontrados

Os bugs encontrados estão documentados em:

```text
docs/bugs/
```

---

# Como Executar os Testes

## Backend

```bash
dotnet test
```

## E2E

```bash
npx playwright test
```

---

# Status Atual

- Testes unitários implementados e executando com sucesso
- Testes de integração parcialmente bloqueados devido a incompatibilidade do EF Core no ambiente atual
- Testes end-to-end implementados utilizando Playwright

---

# Justificativa

Os testes foram criados com foco nas principais regras de negócio informadas no desafio, priorizando:
- regras críticas
- organização da pirâmide de testes
- validação do comportamento da aplicação
- documentação dos problemas encontrados