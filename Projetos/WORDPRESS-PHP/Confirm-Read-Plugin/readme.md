# Confirm Read Plugin

## Descrição

O plugin `Confirm Read` permite que todos os usuários confirmem a leitura de um post no WordPress. Além disso, ele exibe uma lista de 
confirmações de leitura visível apenas para administradores. O plugin também inclui informações de publicação e edição dos posts.

## Funcionalidades

- Adiciona um botão de confirmação de leitura a todos os posts.
- Permite que qualquer usuário confirme a leitura de um post.
- Exibe uma lista de confirmações de leitura apenas para administradores.
- Exibe informações de publicação e edição dos posts.
- Redefine a confirmação de leitura quando um post é editado.

## Instalação

1. Faça o upload do arquivo do plugin para o diretório `/wp-content/plugins/` ou instale o plugin diretamente pelo painel de plugins do WordPress.
2. Ative o plugin no menu 'Plugins' do WordPress.

## Uso

### Botão de Confirmação de Leitura

Após ativar o plugin, um botão de confirmação de leitura será exibido automaticamente em cada post. Os usuários podem clicar neste botão para confirmar que leram o post.

### Página de Administração

Os administradores podem visualizar a lista de confirmações de leitura na página de administração. Para acessar esta página, adicione `/wp-admin/admin.php?page=confirm-read-admin` ao URL do seu site WordPress.

### Shortcode

Use o shortcode `[confirm_read_list]` para exibir a lista de confirmações de leitura em qualquer página ou post. Este shortcode exibirá a lista apenas para administradores.
