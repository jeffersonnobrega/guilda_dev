# 📚 Sacadas de C# - BibliotecaApp

Este arquivo reúne conceitos fundamentais aprendidos nas Sessões 1, 2 e 3 do projeto `BibliotecaApp`, com explicações simples para consulta rápida e fixação.

---

## 🧱 Sessão 1 e 2 - Fundamentos, Herança e Polimorfismo

| Conceito           | Sacada / Explicação simples                                                                 |
|--------------------|---------------------------------------------------------------------------------------------|
| **Classe**         | É como um **molde** de um objeto. Ex: A classe `Livro` é o molde para criar vários livros. |
| **Objeto**         | É o que você **cria** a partir da classe. Ex: `new Livro(...)`.                            |
| **Construtor**     | É o **nascimento** do objeto — define seus valores iniciais.                               |
| **Propriedade**    | É uma **característica** do objeto. Ex: `Titulo`, `Autor`, `Ano`.                          |
| **Método**         | É uma **ação** que o objeto pode fazer. Ex: `Emprestar()`, `Devolver()`.                   |
| **Encapsulamento** | Esconde detalhes e protege o objeto. Usa `private`, `public`, `get`, `set`.                |
| **Herança**        | É **reaproveitar código** de uma classe base. Ex: `LivroFiccao` herda de `Livro`.          |
| **Polimorfismo**   | Um mesmo método pode se **comportar diferente** em classes diferentes.                     |
| **virtual**        | Diz: "*esse método pode ser reescrito nas classes filhas*".                                |
| **override**       | Diz: "*estou reescrevendo esse método herdado da classe base*".                           |
| **base**           | Acessa algo da **classe mãe**. Ex: construtor ou método.                                   |

---

## 🔍 Sessão 3 - LINQ

| Conceito           | Sacada / Explicação simples                                                           |
|--------------------|----------------------------------------------------------------------------------------|
| **LINQ**           | É o **"SQL do C#"**, mas direto na linguagem.                                          |
| **Where**          | Filtra. Só entra quem passa na condição.                                               |
| **FirstOrDefault** | Pega o primeiro item que bate com a condição (ou `null`).                              |
| **ToList()**       | Força a execução da consulta LINQ e transforma em uma lista de verdade.                |
| **Last()**         | Retorna o **último item** de uma lista ou coleção.                                     |
| **OrderBy**        | Ordena uma coleção.                                                                    |
| **Count**          | Conta itens que batem com uma condição.                                                |
| **Select**         | Transforma uma lista em outra coisa (ex: pega só os títulos).                          |
| **Lambda**         | `l => l.Titulo == "1984"` → forma curta de criar uma função.                           |

---

## 📌 Outras sacadas importantes

| Conceito                          | Sacada / Explicação simples                                                                 |
|----------------------------------|---------------------------------------------------------------------------------------------|
| **StringComparison.OrdinalIgnoreCase** | Faz comparação de strings **sem diferenciar maiúsculas e minúsculas**.               |        |
| **Equals + StringComparison**    | Comparar strings com segurança e sem se preocupar com letras maiúsculas/minúsculas.       |

---

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
