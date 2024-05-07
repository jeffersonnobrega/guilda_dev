# Compactador Solution

Este é um programa que monitora uma pasta de origem, compacta seus arquivos e move os arquivos compactados para uma pasta de destino.

## Funcionamento

O programa executa em um loop infinito, verificando a pasta de origem a cada minuto. 

Se houver arquivos na pasta de origem e pelo menos um minuto se passou desde a última compactação, um novo arquivo ZIP será criado a partir dos arquivos da pasta de origem. Os arquivos de origem serão excluídos após a compactação bem-sucedida. O programa utiliza threads para permitir que outras tarefas sejam executadas enquanto a monitoração acontece.

## Uso

Para utilizar o programa, basta executar o arquivo executável. Certifique-se de configurar os diretórios de origem e destino de acordo com suas necessidades no código-fonte antes de compilar o programa.

## Código-fonte

O código-fonte consiste em uma classe `Compactador` com um método `Main` para iniciar o programa e um método `Monitorar` para monitorar a pasta de origem e executar a compactação. Há também um método `ObterUltimaModificacao` para obter a data da última modificação dos arquivos na pasta de origem.

## Dependências

O programa utiliza as bibliotecas padrão do .NET para manipulação de arquivos e compactação.

## Contribuição

Se você deseja contribuir com melhorias para este programa, sinta-se à vontade para enviar um pull request ou abrir uma issue no repositório do projeto.

