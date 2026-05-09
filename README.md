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
backend-tests/
frontend-tests/
e2e-tests/
docs/bugs/
```

- `backend-tests/`
  Testes backend com xUnit.

- `frontend-tests/`
  Testes frontend com Vitest.

- `e2e-tests/`
  Testes end-to-end com Playwright.

- `docs/bugs/`
  Documentação dos bugs encontrados.

---

# Estratégia de Testes

## Testes Unitários
Focados nas regras de negócio:
- menor de idade não pode ter receita
- validação de categorias
- cálculo de totais

## Testes de Integração
Focados na comunicação entre:
- API
- serviços
- banco de dados

## Testes End-to-End
Focados nos principais fluxos:
- cadastro de pessoas
- cadastro de categorias
- cadastro de transações

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

## Frontend

```bash
npm run test
```

## E2E

```bash
npx playwright test
```

---

# Justificativa

Os testes foram criados com foco nas principais regras de negócio informadas no desafio.