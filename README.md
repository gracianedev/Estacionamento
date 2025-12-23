# 🚗 Sistema de Gerenciamento de Estacionamento

Este projeto foi desenvolvido como parte do desafio prático da **Formação .NET Developer da DIO**. O objetivo é gerenciar veículos em um estacionamento, controlando entradas, saídas e cálculos de valores devidos. Este é o meu primeiro projeto trabalhando com C#.

---

## 🛠️ Tecnologias e Ferramentas
* **Linguagem:** C#
* **Plataforma:** .NET 10
* **Ambiente de Desenvolvimento:** VS Code (macOS)

---

## 🚀 Funcionalidades
- **Entrada de Veículo:** Adiciona um veículo à garagem validando a capacidade máxima (lotação).
- **Saída de Veículo:** Localiza o veículo pela placa, registra o horário de saída e calcula o valor a pagar.
- **Cálculo de Tarifas Inteligente:** - Cobrança por hora para permanências curtas.
  - Conversão automática para diária após um determinado período.
- **Listagem de Vagas:** Exibe a ocupação atual e a disponibilidade de vagas em tempo real.

---

## 🧠 Conceitos Aplicados
Este projeto foi fundamental para consolidar os seguintes pilares da programação:
1.  **POO (Programação Orientada a Objetos):** Separação de responsabilidades entre as classes `Veiculo` e `Garagem`.
2.  **Manipulação de Coleções:** Uso de `Dictionary<string, Veiculo>` para busca otimizada (O(1)) através da placa.
3.  **Gestão de Data e Tempo:** Uso de `DateTime` e `TimeSpan` para cálculos precisos de intervalo de permanência.

---

## 💻 Como Executar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/gracianedev/Estacionamento.git
2. Entre na pasta do projeto:   
    ```bash
    cd Estacionamento
3. Execute o comando:   
    ```bash 
    dotnet run