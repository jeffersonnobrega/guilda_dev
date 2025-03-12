# FinancialAPI

## ✨ Visão Geral

FinancialAPI é uma API RESTful para controle de despesas, permitindo que usuários registrem, consultem, atualizem e excluam gastos.

## 🔢 Tecnologias Utilizadas

 - .NET 8

 - ASP.NET Core Web API

 - Entity Framework Core

 - Banco de dados InMemory (para desenvolvimento)

 - Docker

 - Azure (para deploy)

 - GitHub Actions (para CI/CD)

## 📙 Requisitos do Projeto

### 1. Requisitos de Negócio

✅ Registro de despesas com descrição, valor e data.

✅ Consulta de todas as despesas.

✅ Consulta de uma despesa específica pelo ID.

✅ Atualização de uma despesa existente.

✅ Exclusão de uma despesa.

✅ Disponibilidade 24/7 e tempo de resposta rápido.

✅ Deploy no Azure com escalabilidade.

✅ Uso de Docker para containerização.

✅ CI/CD automatizado com GitHub Actions.

### 2. Requisitos Funcionais

 - CRUD completo para despesas (Create, Read, Update, Delete).

- Endpoints RESTful seguindo boas práticas.

- Uso do Entity Framework Core.

- Retorno de dados no formato JSON.

- Tratamento de erros e mensagens amigáveis.

### 3. Requisitos Não Funcionais

- Escalabilidade: API preparada para aumento de demanda.

- Performance: Tempo de resposta inferior a 1 segundo.

- Segurança: Proteção contra SQL Injection e exposição desnecessária de dados.

- Logs: Registro de logs para monitoramento.

- Deploy automatizado com Docker + GitHub Actions.

- Monitoramento via Azure.

## 🔍 Endpoints

| Método  | Endpoint             | Descrição                             |
|---------|----------------------|---------------------------------------|
| `GET`   | `/api/expenses`      | Retorna todas as despesas cadastradas |
| `GET`   | `/api/expenses/{id}` | Retorna uma despesa específica pelo ID |
| `POST`  | `/api/expenses`      | Adiciona uma nova despesa             |
| `PUT`   | `/api/expenses/{id}` | Atualiza uma despesa existente        |
| `DELETE` | `/api/expenses/{id}` | Exclui uma despesa                    |


## 🌍 Como Executar Localmente

Clone o repositório:

```bash
git clone https://github.com/seu-usuario/FinancialAPI.git
cd FinancialAPI
```

Instale as dependências:
```
dotnet restore
```
Execute o projeto:
```
dotnet run
```
A API estará acessível em http://localhost:5000 ou https://localhost:5001
---

## 🛠️ Como Executar com Docker

Construa a imagem Docker:
```
docker build -t financial-api .
```
Rode o container:
```
docker run -p 5000:5000 financial-api
```
A API estará rodando em http://localhost:5000
---
## 🚀 Deploy no Azure

Faça login no Azure:
```
az login
```
Crie um grupo de recursos:
```
az group create --name FinancialAPIGroup --location eastus
```
Crie um contêiner no Azure:
```
az container create --resource-group FinancialAPIGroup --name financialapi --image seu-usuario/financial-api --dns-name-label financialapi --ports 80
```
Acesse a API em http://financialapi.eastus.azurecontainer.io
---
🔄 CI/CD com GitHub Actions

O repositório está configurado para CI/CD utilizando GitHub Actions, garantindo deploy automático a cada push na branch main.

## ✨ Contribuição

Fique à vontade para contribuir com melhorias e novas funcionalidades! Para isso:

1. Faça um fork do repositório.

2. Crie uma branch para sua feature:
 ```
git checkout -b minha-nova-feature
 ```
3. Commit suas mudanças:
 ```
git commit -m "Adiciona nova funcionalidade X"
 ```
4. Envie seu código:
 ```
git push origin minha-nova-feature
 ```
5. Abra um Pull Request.

👨‍💻 Autor

Desenvolvido por **Jefferson Nóbrega**.

🛡️ Licença

Este projeto está licenciado sob a MIT License. Consulte o arquivo LICENSE para mais detalhes.
