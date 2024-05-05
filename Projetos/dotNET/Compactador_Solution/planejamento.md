## Definição do Objetivo:

- Criar um programa que monitora uma pasta específica.
- Compactar todos os arquivos nessa pasta em intervalos regulares.

## Especificação de Requisitos:

- O programa deve ser capaz de identificar quando novos arquivos são adicionados à pasta.
- Deve compactar todos os arquivos na pasta em um arquivo compactado.
- Deve realizar essa operação a cada minuto.

## Arquitetura do Programa:

### Monitoramento da Pasta:

- Utilizará uma biblioteca ou módulo para monitorar mudanças na pasta.
- Verificará periodicamente (a cada minuto) se há novos arquivos na pasta.

### Compactação dos Arquivos:

- Utilizará uma biblioteca ou módulo para compactar os arquivos.
- Criará um arquivo compactado que contenha todos os arquivos da pasta.

### Agendamento:

- Usará uma ferramenta ou módulo para agendar a execução do processo de monitoramento e compactação a cada minuto.

## Fluxo de Funcionamento:

- O programa será iniciado e começará a monitorar a pasta especificada.
- A cada minuto, verificará se há novos arquivos na pasta.
- Se houver novos arquivos, os compactará em um arquivo único.
- O programa continuará a executar esse ciclo de monitoramento e compactação a cada minuto.

## Testes:

- Testes de unidade para cada componente do programa.
- Testes de integração para garantir que os componentes funcionem juntos corretamente.
- Testes de estresse para verificar o desempenho do programa sob carga pesada.

## Implantação:

- Preparar o programa para implantação em um ambiente de produção.
- Configurar logs e monitoramento para acompanhar o desempenho e detectar problemas.

## Manutenção:

- Monitorar o programa em produção para garantir que continue funcionando conforme o esperado.
- Realizar atualizações e correções conforme necessário.
