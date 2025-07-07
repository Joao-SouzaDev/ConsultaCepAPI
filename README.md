# ConsultaCepAPI

## Vis�o Geral

A ConsultaCepAPI � uma API REST desenvolvida em .NET 8 para consulta de endere�os a partir de CEPs, utilizando a integra��o com o servi�o ViaCEP. O projeto segue a arquitetura hexagonal (Ports and Adapters), promovendo desacoplamento, testabilidade e facilidade de manuten��o.

## Arquitetura Hexagonal

A arquitetura hexagonal, tamb�m conhecida como Ports and Adapters, organiza o sistema em torno do dom�nio central (core) e separa as depend�ncias externas (como APIs, bancos de dados, interfaces de usu�rio) por meio de portas (interfaces) e adaptadores (implementa��es concretas).

- **Dom�nio (Core):** Cont�m as regras de neg�cio e interfaces (ports).
- **Adapters:** Implementa��es concretas das interfaces, como integra��o com o ViaCEP.
- **Endpoints:** Pontos de entrada da aplica��o (controllers/minimal APIs).
- **Services:** Camada de aplica��o, orquestra as regras de neg�cio e integra��es.

### Vantagens
- Facilita testes unit�rios e de integra��o.
- Permite trocar facilmente implementa��es externas.
- Mant�m o dom�nio isolado de detalhes de infraestrutura.

## Endpoints Dispon�veis

- `GET /cep/{cep}`: Consulta endere�o pelo CEP.
- `GET /cep?estado={estado}&cidade={cidade}&logradouro={logradouro}`: Consulta endere�os por estado, cidade e logradouro.

## Passo a Passo para Setup

1. **Pr�-requisitos**
   - [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado
   - Visual Studio 2022 ou superior (opcional, mas recomendado)

2. **Clonar o reposit�rio**
3. **Restaurar depend�ncias**
4. **Executar a aplica��o**
5. **Acessar a documenta��o Swagger**
   - Com a aplica��o rodando, acesse: [https://localhost:5001/swagger](https://localhost:5001/swagger) (ou a porta configurada)

6. **Testar os endpoints**
   - Utilize o Swagger UI ou ferramentas como Postman/Insomnia para testar as rotas.

## Observa��es

- A API utiliza CORS liberado para facilitar o desenvolvimento.
- O projeto est� preparado para ser facilmente estendido com outros provedores de CEP, bastando implementar as interfaces adequadas.

---

**D�vidas ou sugest�es?** Abra uma issue no reposit�rio.
