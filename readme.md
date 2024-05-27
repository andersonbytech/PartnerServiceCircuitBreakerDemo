# PartnerServiceCircuitBreakerDemo

## Vis�o Geral do Projeto

O projeto **PartnerServiceCircuitBreakerDemo** demonstra a implementa��o do padr�o Circuit Breaker em uma arquitetura de microsservi�os usando .NET 6 e Polly. Este projeto � composto por dois subprojetos:

1. **PartnerApi** - Uma API de servi�o parceiro simulada.
2. **CircuitBreakerClient** - Uma aplica��o console que consome a PartnerApi usando um Circuit Breaker para garantir resili�ncia e confiabilidade.

## Estrutura do Projeto

- **PartnerApi**: Cont�m a implementa��o da API de servi�o parceiro.
- **CircuitBreakerClient**: Cont�m a implementa��o do cliente console que chama a PartnerApi utilizando o padr�o Circuit Breaker.

## Por que usar Circuit Breakers?

Em um ambiente de microsservi�os, os servi�os frequentemente dependem uns dos outros. Quando um servi�o falha ou se torna n�o responsivo, pode causar uma rea��o em cadeia de falhas por todo o sistema. Um Circuit Breaker ajuda a mitigar esse risco por:
- Prevenir falhas em cascata, interrompendo as chamadas para um servi�o que est� falhando.
- Permitir que os servi�os se recuperem sem serem sobrecarregados por uma enxurrada de requisi��es.
- Melhorar a resili�ncia e a confiabilidade geral do sistema.

## Benef�cios desta Implementa��o

- **Resili�ncia**: Protege seus servi�os de falhas e timeouts.
- **Efici�ncia**: Reduz a carga desnecess�ria em servi�os falhando, permitindo que eles se recuperem mais rapidamente.
- **Experi�ncia do Usu�rio**: Fornece feedback imediato e respostas alternativas durante per�odos de inatividade do servi�o, melhorando a experi�ncia do usu�rio.

## Tech Stack

- **.NET 6**: A vers�o mais recente do .NET, oferecendo melhorias de desempenho e novos recursos.
- **Polly**: Uma robusta biblioteca .NET para resili�ncia e tratamento de falhas transit�rias, permitindo pol�ticas sofisticadas de retry e Circuit Breaker.

## Como Executar o Projeto

### Pr�-requisitos

- .NET 6 SDK
- Visual Studio ou qualquer IDE de sua prefer�ncia

### Passo a Passo

1. **Clone o reposit�rio:**
   ```sh
   git clone https://github.com/seu-usuario/PartnerServiceCircuitBreakerDemo.git
   cd PartnerServiceCircuitBreakerDemo
2. **Abra a solu��o no Visual Studio:**
	```sh
	code .
