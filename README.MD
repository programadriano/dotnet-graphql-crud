# Projeto GraphQL Stock

Este projeto implementa uma API GraphQL simples para gerenciar informações sobre ações (stocks) usando o framework .NET e a biblioteca HotChocolate.AspNetCore.

## Funcionalidades

* Consultar a lista de ações disponíveis
* Adicionar uma nova ação
* Atualizar uma ação existente
* Remover uma ação

## Requisitos

.NET 6.0 ou superior

## Como executar

* Clone o repositório para sua máquina local
* Navegue até a pasta do projeto via linha de comando
* Execute o comando dotnet run para iniciar a aplicação
* Abra o GraphQL Playground no seu navegador em http://localhost:5000/graphql

## Exemplos de consulta e mutation

### Consulta

Para obter a lista de ações disponíveis, use a seguinte consulta:

```
{
  stocks{
    id,
    ticker,
    nome,
    precoAtual,
    volumeNegociado,
    dataUltimaAtualizacao
  }
}
```
Buscar por um ID
```
{
   byId (id:1) {
    id,
    ticker,
    nome,
    precoAtual,
    volumeNegociado,
    dataUltimaAtualizacao
   }
}
```

Adicionar:

```
mutation{
  addStock(input: {id:0,nome:"Microsoft Corporation",ticker : "MSFT",precoAtual : 200.0, volumeNegociado : 12000,dataUltimaAtualizacao : "2023-04-05"}) {
    id,ticker,nome,precoAtual,volumeNegociado,dataUltimaAtualizacao
  }
}
```

Atualizando registro:

```
mutation{
  updateStock(id :1,input: {id:1,nome:"Microsoft Corporations",ticker : "MSFT",precoAtual : 200.0, volumeNegociado : 12000,dataUltimaAtualizacao : "2023-04-05"}) {
    id,ticker,nome,precoAtual,volumeNegociado,dataUltimaAtualizacao
  }
}
```
Deletando registro: 

```
mutation{
  deleteStock(id:1)
}
```

