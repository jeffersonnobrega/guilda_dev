
# 📚 BibliotecaApp

> Sistema pessoal de catalogação e gerenciamento de livros físicos, com funcionalidades de avaliação, categorização e controle de empréstimos.

---

## 🧠 Objetivo do Projeto

Criar um aplicativo local em .NET que permita catalogar uma biblioteca pessoal de livros físicos com os seguintes objetivos:
- Aplicar conceitos de **POO** (herança, encapsulamento, polimorfismo)
- Praticar **arquitetura limpa**
- Implementar funcionalidades úteis como: avaliação, organização por categorias, controle de disponibilidade
- Facilitar futuras extensões como persistência com JSON, integração com IA, ou API REST.

---

## 🚀 Funcionalidades Atuais

- ✅ Cadastro de livros com avaliação em estrelas
- ✅ Subclasses de livros: `LivroDidatico`, `LivroFiccao`, `LivroRaro`
- ✅ Controle de disponibilidade e empréstimos
- ✅ Método de exibição da nota como estrelas (★☆☆☆☆)

---

## 🧱 Estrutura do Projeto

```
BibliotecaApp/
│
├── Models/
│   ├── Livro.cs
│   ├── LivroDidatico.cs
│   ├── LivroFiccao.cs
│   └── LivroRaro.cs
│
├── Program.cs
└── README.md
```

---

## ✅ Boas Práticas Adotadas

- ✅ Uso de **`Math.Clamp()`** para garantir que a nota esteja no intervalo válido
- ✅ **Constantes** como `NotaMaxima` centralizadas na classe
- ✅ **Encapsulamento** dos métodos internos como `TornarIndisponivel()`
- ✅ **Herança** com subclasses que herdam de `Livro`
- ✅ **Mensagens de commit descritivas** no formato: `tipo: descrição` (`feat:`, `refactor:`, `fix:`, etc.)

---

## 📋 Requisitos Futuros

- [ ] Persistência de dados em `.json` local
- [ ] Sistema de avaliação de coleção (ex: livros por autor, trilogias incompletas)
- [ ] Interface de texto com menus organizados
- [ ] API REST com .NET WebAPI (fase posterior)
- [ ] Integração com AI para busca de sinopse e ISBN
- [ ] Identificação de livros ausentes em trilogias/séries

---

## 🗂️ Kanban de Progresso

| To Do | Doing | Done |
|------|-------|------|
| Separar lógica de empréstimo em `ServicoDeEmprestimo` | — | Criar `Livro`, `LivroDidatico`, `LivroFiccao`, `LivroRaro` |
| Criar persistência com `.json` local | — | Implementar `ObterNotaEmEstrelas()` |
| Organizar interface textual com menus claros | — | Refatorar pasta `Models/` |
| Criar README completo e Kanban | — | Validar nota com `Math.Clamp()` |
| Criar testes com `xUnit` | — | Uso de mensagens de commit descritivas |
| Criar enum para gêneros de livros | — | Uso de `const` para `NotaMaxima` |
| Interface gráfica futura (WinForms/WPF) | — | — |

---

## 🧪 Como Executar Localmente

1. Clone o repositório:
```bash
git clone https://github.com/jeffersonnobrega/guilda_dev
```

2. Acesse a pasta do projeto:
```bash
cd guilda_dev/Projetos/BibliotecaApp
```

3. Compile e execute:
```bash
dotnet build
dotnet run
```

---

## 📌 Requisitos

- [.NET SDK 8.0+](https://dotnet.microsoft.com/en-us/download)
- Editor como [Visual Studio Code](https://code.visualstudio.com/) ou [Rider](https://www.jetbrains.com/rider/)

---

## 🧠 Autor

Jefferson Nóbrega — Desenvolvedor Jr com foco em aprendizado prático, arquitetura de software e paixão por soluções organizadas e evolutivas.

---
