# API de Gerenciamento de Contatos

## Visão Geral
Este projeto é uma API de Gerenciamento de Contatos construída com ASP.NET Core e Entity Framework Core. Ela fornece uma API RESTful para gerenciar informações de contato, incluindo operações CRUD (Criar, Ler, Atualizar, Excluir). A API é projetada com princípios de arquitetura limpa, garantindo escalabilidade, manutenção e facilidade de integração.
## Funcionalidade
* Operações CRUD: Gerencie contatos de forma eficiente com endpoints para criar, ler, atualizar e excluir registros de contato.
* Entity Framework Core: Utiliza o EF Core para um acesso robusto e eficiente aos dados, garantindo uma interação perfeita com um banco de dados SQL Server.
* Integração com Swagger: Documentação de API gerada automaticamente com Swagger/OpenAPI, simplificando o teste e a exploração dos endpoints.
* Tratamento de Exceções: Tratamento abrangente de erros para gerenciar entradas de dados inválidas e outras exceções de forma graciosa.
* Programação Assíncrona: Utiliza async/await para operações não bloqueantes, melhorando o desempenho e a responsividade.

## Tecnologias Utilizadas
* ASP.NET Core: Framework para Web API
* Entity Framework Core: ORM para acesso a dados
* SQL Server: Sistema de gerenciamento de banco de dados
* Swagger/OpenAPI: Documentação de API
* C#: Linguagem de Programação

## Endpoints da API
* Criar Contato: POST /Contact/CreateContact
* Obter Contato por ID: GET /Contact/{id}
* Obter Todos os Contatos: GET /Contact/GetContacts
* Obter Contato por Nome: GET /Contact/GetContactByName
* Atualizar Contato: PUT /Contact/{id}
* Atualização Parcial do Contato: PATCH /Contact/UpdateContact
* Excluir Contato: DELETE /Contact/{id}

