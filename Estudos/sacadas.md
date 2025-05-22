# 📚 Sacadas de C# - BibliotecaApp

Este arquivo reúne conceitos fundamentais aprendidos nas Sessões 1, 2 e 3 do projeto `BibliotecaApp`, com explicações simples para consulta rápida e fixação.

---

## 🧱 Sessão 1 e 2 - Fundamentos, Herança e Polimorfismo

| Conceito           | Sacada / Explicação simples                                                                |
| ------------------ | ------------------------------------------------------------------------------------------ |
| **Classe**         | É como um **molde** de um objeto. Ex: A classe `Livro` é o molde para criar vários livros. |
| **Objeto**         | É o que você **cria** a partir da classe. Ex: `new Livro(...)`.                            |
| **Construtor**     | É o **nascimento** do objeto — define seus valores iniciais.                               |
| **Propriedade**    | É uma **característica** do objeto. Ex: `Titulo`, `Autor`, `Ano`.                          |
| **Método**         | É uma **ação** que o objeto pode fazer. Ex: `Emprestar()`, `Devolver()`.                   |
| **Encapsulamento** | Esconde detalhes e protege o objeto. Usa `private`, `public`, `get`, `set`.                |
| **Herança**        | É **reaproveitar código** de uma classe base. Ex: `LivroDigital` herda de `Livro`.         |
| **Polimorfismo**   | Um mesmo método pode se **comportar diferente** em classes diferentes.                     |
| **virtual**        | Diz: "_esse método pode ser reescrito nas classes filhas_".                                |
| **override**       | Diz: "_estou reescrevendo esse método herdado da classe base_".                            |
| **base**           | Acessa algo da **classe mãe**. Ex: construtor ou método.                                   |

---

## 🔍 Sessão 3 - LINQ

| Conceito           | Sacada / Explicação simples                                   |
| ------------------ | ------------------------------------------------------------- |
| **LINQ**           | É o **"SQL do C#"**, mas direto na linguagem.                 |
| **Where**          | Filtra. Só entra quem passa na condição.                      |
| **FirstOrDefault** | Pega o primeiro item que bate com a condição (ou `null`).     |
| **OrderBy**        | Ordena uma coleção.                                           |
| **Count**          | Conta itens que batem com uma condição.                       |
| **Select**         | Transforma uma lista em outra coisa (ex: pega só os títulos). |
| **Lambda**         | `l => l.Titulo == "1984"` → forma curta de criar uma função.  |

## 🔍 Sessão 4

## 💡 Sacada: `Any()` é perfeito para verificações rápidas

Use `.Any()` quando quiser saber **se uma lista tem elementos**, sem precisar contar tudo com `.Count()` ou iterar manualmente.

### Vantagem:

Mais **performático** e **legível** que fazer:

````csharp
if (lista.Count > 0) { ... }

---

**Sacada: Usando `OfType<T>()` para trabalhar com herança**

Quando você tem uma lista com objetos de uma classe base (ex: `Livro`) e deseja manipular apenas os objetos de uma subclasse (ex: `LivroRaro`), use o método LINQ `OfType<LivroRaro>()`.

Ele permite filtrar apenas os elementos que realmente são daquela subclasse, sem precisar fazer cast manual ou verificar com `is`.

### Exemplo prático:
```csharp
var rarosRuins = livros
    .OfType<LivroRaro>()
    .Where(l => l.EstadoConservacao == "ruim")
    .ToList();

## 🧠 Atalhos mentais

- 🧱 **Classe = planta baixa de uma casa**
- 🏠 **Objeto = casa construída com essa planta**
- 🛠️ **Métodos = funcionalidades da casa** (abrir porta, acender luz)
- 🔒 **Encapsulamento = trancar cômodos que não devem ser acessados diretamente**
- 👨‍👩‍👧‍👦 **Herança = uma casa nova que já vem com os mesmos cômodos da casa antiga, mas você pode mudar o que quiser**
- 🧬 **Polimorfismo = duas casas com a mesma planta, mas uma tem garagem e a outra não — o mesmo método se comporta diferente**

---



**Atualizado por:** Jefferson Nóbrega
**Projeto:** BibliotecaApp
````
