📚 Principais Métodos LINQ no C#
🔎 1. Where
Filtra elementos com base em uma condição.

csharp
Copiar
Editar
var livrosDisponiveis = livros.Where(l => l.Disponivel).ToList();
✅ 2. Any
Verifica se existe ao menos um item que atenda à condição (ou se a lista tem algo).

csharp
Copiar
Editar
if (livros.Any(l => l.Emprestado)) { ... }
🔄 3. Select
Projeta ou transforma os elementos.

csharp
Copiar
Editar
var titulos = livros.Select(l => l.Titulo).ToList();
🔢 4. Count
Conta os itens da coleção (ou que atendem a uma condição).

csharp
Copiar
Editar
int total = livros.Count(l => l.Disponivel);
🧪 5. First / FirstOrDefault
Pega o primeiro elemento (ou null/default se não houver com FirstOrDefault).

csharp
Copiar
Editar
var primeiroLivro = livros.FirstOrDefault(l => l.Ano == 2020);
🧹 6. Distinct
Remove itens duplicados.

csharp
Copiar
Editar
var autoresUnicos = livros.Select(l => l.Autor).Distinct().ToList();
➕ 7. AddRange
Adiciona uma lista de itens a outra.

csharp
Copiar
Editar
listaCompleta.AddRange(novosLivros);
🧰 8. OfType<T>()
Filtra elementos por tipo em listas polimórficas.

csharp
Copiar
Editar
var livrosRaros = livros.OfType<LivroRaro>().ToList();
❌ 9. Except
Remove da lista principal os itens que existem na outra lista.

csharp
Copiar
Editar
var disponiveis = todos.Except(emprestados).ToList();
🔤 10. OrderBy / OrderByDescending
Ordena os itens.

csharp
Copiar
Editar
var ordenados = livros.OrderBy(l => l.Ano).ToList();
🧭 11. All
Verifica se todos os elementos satisfazem uma condição.

csharp
Copiar
Editar
bool todosDisponiveis = livros.All(l => l.Disponivel);
🧠 Dica Extra: Combinação fluente
Você pode encadear métodos:

csharp
Copiar
Editar
var titulosOrdenados = livros
    .Where(l => l.Disponivel)
    .OrderBy(l => l.Titulo)
    .Select(l => l.Titulo)
    .ToList();
