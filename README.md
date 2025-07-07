# ConsultaCepAPI

## Visão Geral

A ConsultaCepAPI é uma API REST desenvolvida em .NET 8 para consulta de endereços a partir de CEPs, utilizando a integração com o serviço ViaCEP. O projeto segue a arquitetura hexagonal (Ports and Adapters), promovendo desacoplamento, testabilidade e facilidade de manutenção.

## Arquitetura Hexagonal

A arquitetura hexagonal, também conhecida como Ports and Adapters, organiza o sistema em torno do domínio central (core) e separa as dependências externas (como APIs, bancos de dados, interfaces de usuário) por meio de portas (interfaces) e adaptadores (implementações concretas).

- **Domínio (Core):** Contém as regras de negócio e interfaces (ports).
- **Adapters:** Implementações concretas das interfaces, como integração com o ViaCEP.
- **Endpoints:** Pontos de entrada da aplicação (controllers/minimal APIs).
- **Services:** Camada de aplicação, orquestra as regras de negócio e integrações.

### Vantagens
- Facilita testes unitários e de integração.
- Permite trocar facilmente implementações externas.
- Mantém o domínio isolado de detalhes de infraestrutura.

## Endpoints Disponíveis

- `GET /cep/{cep}`: Consulta endereço pelo CEP.
- `GET /cep?estado={estado}&cidade={cidade}&logradouro={logradouro}`: Consulta endereços por estado, cidade e logradouro.

## Passo a Passo para Setup

1. **Pré-requisitos**
   - [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado
   - Visual Studio 2022 ou superior (opcional, mas recomendado)

2. **Clonar o repositório**
3. **Restaurar dependências**
4. **Executar a aplicação**
5. **Acessar a documentação Swagger**
   - Com a aplicação rodando, acesse: [https://localhost:5001/swagger](https://localhost:5001/swagger) (ou a porta configurada)

6. **Testar os endpoints**
   - Utilize o Swagger UI ou ferramentas como Postman/Insomnia para testar as rotas.

## Observações

- A API utiliza CORS liberado para facilitar o desenvolvimento.
- O projeto está preparado para ser facilmente estendido com outros provedores de CEP, bastando implementar as interfaces adequadas.

---

**Dúvidas ou sugestões?** Abra uma issue no repositório.
