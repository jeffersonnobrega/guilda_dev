# 📚 Principais Métodos LINQ no C#

## 🔎 1. `Where`

Filtra elementos com base em uma condição.

```csharp
var livrosDisponiveis = livros.Where(l => l.Disponivel).ToList();
```

---

## ✅ 2. `Any`

Verifica se existe **ao menos um** item que atenda à condição (ou se a lista tem algo).

```csharp
if (livros.Any(l => l.Emprestado)) { ... }
```

---

## 🔄 3. `Select`

Projeta ou transforma os elementos.

```csharp
var titulos = livros.Select(l => l.Titulo).ToList();
```

---

## 🔢 4. `Count`

Conta os itens da coleção (ou que atendem a uma condição).

```csharp
int total = livros.Count(l => l.Disponivel);
```

---

## 🧪 5. `First` / `FirstOrDefault`

Pega o primeiro elemento (ou `null`/`default` se não houver com `FirstOrDefault`).

```csharp
var primeiroLivro = livros.FirstOrDefault(l => l.Ano == 2020);
```

---

## 🧹 6. `Distinct`

Remove itens duplicados.

```csharp
var autoresUnicos = livros.Select(l => l.Autor).Distinct().ToList();
```

---

## ➕ 7. `AddRange`

Adiciona uma lista de itens a outra.

```csharp
listaCompleta.AddRange(novosLivros);
```

---

## 🧰 8. `OfType<T>()`

Filtra elementos por tipo em listas polimórficas.

```csharp
var livrosRaros = livros.OfType<LivroRaro>().ToList();
```

---

## ❌ 9. `Except`

Remove da lista principal os itens que existem na outra lista.

```csharp
var disponiveis = todos.Except(emprestados).ToList();
```

---

## 🔤 10. `OrderBy` / `OrderByDescending`

Ordena os itens.

```csharp
var ordenados = livros.OrderBy(l => l.Ano).ToList();
```

---

## 🧭 11. `All`

Verifica se **todos os elementos** satisfazem uma condição.

```csharp
bool todosDisponiveis = livros.All(l => l.Disponivel);
```

---

## 🧠 Dica Extra: Combinação fluente

Você pode encadear métodos:

```csharp
var titulosOrdenados = livros
    .Where(l => l.Disponivel)
    .OrderBy(l => l.Titulo)
    .Select(l => l.Titulo)
    .ToList();
```
