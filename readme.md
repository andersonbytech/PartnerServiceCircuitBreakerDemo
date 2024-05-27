# PartnerServiceCircuitBreakerDemo

## Visão Geral do Projeto

O projeto **PartnerServiceCircuitBreakerDemo** demonstra a implementação do padrão Circuit Breaker em uma arquitetura de microsserviços usando .NET 6 e Polly. Este projeto é composto por dois subprojetos:

1. **PartnerApi** - Uma API de serviço parceiro simulada.
2. **CircuitBreakerClient** - Uma aplicação console que consome a PartnerApi usando um Circuit Breaker para garantir resiliência e confiabilidade.

## Estrutura do Projeto

- **PartnerApi**: Contém a implementação da API de serviço parceiro.
- **CircuitBreakerClient**: Contém a implementação do cliente console que chama a PartnerApi utilizando o padrão Circuit Breaker.

## Por que usar Circuit Breakers?

Em um ambiente de microsserviços, os serviços frequentemente dependem uns dos outros. Quando um serviço falha ou se torna não responsivo, pode causar uma reação em cadeia de falhas por todo o sistema. Um Circuit Breaker ajuda a mitigar esse risco por:
- Prevenir falhas em cascata, interrompendo as chamadas para um serviço que está falhando.
- Permitir que os serviços se recuperem sem serem sobrecarregados por uma enxurrada de requisições.
- Melhorar a resiliência e a confiabilidade geral do sistema.

## Benefícios desta Implementação

- **Resiliência**: Protege seus serviços de falhas e timeouts.
- **Eficiência**: Reduz a carga desnecessária em serviços falhando, permitindo que eles se recuperem mais rapidamente.
- **Experiência do Usuário**: Fornece feedback imediato e respostas alternativas durante períodos de inatividade do serviço, melhorando a experiência do usuário.

## Tech Stack

- **.NET 6**: A versão mais recente do .NET, oferecendo melhorias de desempenho e novos recursos.
- **Polly**: Uma robusta biblioteca .NET para resiliência e tratamento de falhas transitórias, permitindo políticas sofisticadas de retry e Circuit Breaker.

## Como Executar o Projeto

### Pré-requisitos

- .NET 6 SDK
- Visual Studio ou qualquer IDE de sua preferência

### Passo a Passo

1. **Clone o repositório:**
   ```sh
   git clone https://github.com/seu-usuario/PartnerServiceCircuitBreakerDemo.git
   cd PartnerServiceCircuitBreakerDemo
2. **Abra a solução no Visual Studio:**
	```sh
	code .
