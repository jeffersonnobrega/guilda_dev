<?php
/*
Plugin Name: Confirm-Read
Plugin URI: 
Description: Este plugin exibe informações sobre o autor e o editor ao final de cada postagem e mostra "editado" se a postagem tiver sido editada, mas apenas para administradores. Inclui um botão "Confirmar leitura" para todos os usuários.
Version: 1.0
Author: Jefferson Nóbrega - GENOV
Author URI: 
License: GPL2
*/

function meu_plugin_enqueue_styles() {
    wp_enqueue_style('meu-plugin-styles', plugins_url('read-confirm-style.css', __FILE__));
}
add_action('wp_enqueue_scripts', 'meu_plugin_enqueue_styles');

// Função para adicionar informações ao final do conteúdo da postagem
function meu_plugin_adicionar_informacoes($content) {
    if (is_single() && in_the_loop() && is_main_query()) { // Verifica se é uma postagem na query principal
        global $post;
        $current_user = wp_get_current_user();

        if ($post) {
            // Obter o autor da publicação e a data/hora
            $autor_id = $post->post_author;
            $autor_info = get_userdata($autor_id);
            $data_publicacao = get_the_date('d/m/Y H:i', $post);

            $informacoes = "<h3>Registro de alterações</h3>";
            $informacoes .= "<p>Publicado por " . esc_html($autor_info->display_name) . " em " . esc_html($data_publicacao) . "</p>";

            // Obter o último editor (se a postagem foi editada)
            $ultima_edicao_id = get_post_meta($post->ID, '_edit_last', true);
            if ($ultima_edicao_id) {
                $editor_info = get_userdata($ultima_edicao_id);
                $data_edicao = get_the_modified_date('d/m/Y H:i', $post);

                $informacoes .= "<p>Editado por " . esc_html($editor_info->display_name) . " em " . esc_html($data_edicao) . "</p>";

                
            }

            // Adicionar botão "Confirmar leitura" ou "Lido"
            $estado_atual = get_user_meta($current_user->ID, '_confirmar_leitura_' . $post->ID, true);
            $botao_texto = $estado_atual === 'lido' ? 'Lido' : 'Confirmar leitura';

            // Adicionar formulário com botão "Confirmar leitura" ou "Lido" e "Resetar Leitura"
            $informacoes .= "<form method='post' style='display:inline-block;'>";
            $informacoes .= "<input type='hidden' name='post_id' value='" . esc_attr($post->ID) . "' />";
            $informacoes .= "<input type='hidden' name='estado_atual' value='" . esc_attr($estado_atual) . "' />";
            if ($estado_atual !== 'lido') { // Mostrar botão apenas se o estado não for 'lido'
                $informacoes .= "<input type='submit' name='confirmar_leitura' value='" . esc_attr($botao_texto) . "' />";
            }
            $informacoes .= wp_nonce_field('confirmar_leitura_nonce', 'confirmar_leitura_nonce', true, false);
            $informacoes .= "</form>";

            if (current_user_can('administrator')) {
                $informacoes .= "<form method='post' style='display:inline-block; margin-left: 10px;'>";
                $informacoes .= "<input type='hidden' name='post_id' value='" . esc_attr($post->ID) . "' />";
                $informacoes .= wp_nonce_field('resetar_leitura_nonce', 'resetar_leitura_nonce', true, false);
                $informacoes .= "<input type='submit' name='resetar_leitura' value='Resetar Confirmação de Leitura' />";
                $informacoes .= "</form>";
            }

            // Adicionar as informações ao final do conteúdo
            $content .= $informacoes;
        }
    }
    return $content;
}
add_filter('the_content', 'meu_plugin_adicionar_informacoes');

// Função para processar a confirmação de leitura
function meu_plugin_processar_confirmar_leitura() {
    if (isset($_POST['post_id']) && isset($_POST['confirmar_leitura_nonce'])) {
        if (wp_verify_nonce($_POST['confirmar_leitura_nonce'], 'confirmar_leitura_nonce')) {
            $post_id = intval($_POST['post_id']);
            $current_user = wp_get_current_user();
            $user_id = $current_user->ID;
            $estado_atual = sanitize_text_field($_POST['estado_atual']);

            if ($estado_atual !== 'lido') {
                // Atualizar estado de leitura do usuário
                update_user_meta($user_id, '_confirmar_leitura_' . $post_id, 'lido');

                // Adicionar ao histórico de leituras do post
                $leitura_infos = get_post_meta($post_id, '_mensagens_lidas', true);
                if (empty($leitura_infos)) {
                    $leitura_infos = array();
                }
                $leitura_infos[] = $current_user->display_name . ' - ' . current_time('mysql');
                update_post_meta($post_id, '_mensagens_lidas', $leitura_infos);
            }

            wp_redirect(get_permalink($post_id));
            exit;
        }
    }
}
add_action('init', 'meu_plugin_processar_confirmar_leitura');

// Função para processar o resetar leitura
function meu_plugin_processar_resetar_leitura() {
    if (isset($_POST['post_id']) && isset($_POST['resetar_leitura_nonce'])) {
        if (wp_verify_nonce($_POST['resetar_leitura_nonce'], 'resetar_leitura_nonce')) {
            $post_id = intval($_POST['post_id']);

            // Remover todas as entradas de confirmação de leitura
            $users = get_users();
            foreach ($users as $user) {
                delete_user_meta($user->ID, '_confirmar_leitura_' . $post_id);
            }

            wp_redirect(get_permalink($post_id));
            exit;
        }
    }
}
add_action('init', 'meu_plugin_processar_resetar_leitura');

// Função para exibir o histórico de leituras para administradores
function meu_plugin_exibir_historico_leituras($content) {
    if (is_single() && in_the_loop() && is_main_query() && current_user_can('administrator')) {
        global $post;

        if ($post) {
            // Verificar se o histórico já foi adicionado para evitar duplicação
            $historico_adicionado = false;

            // Adicionar o histórico de leituras apenas se ainda não foi adicionado
            if (!$historico_adicionado) {
                $leitura_infos = get_post_meta($post->ID, '_mensagens_lidas', true);

                if (!empty($leitura_infos)) {
                    $historico_html = '<h3>Histórico de Leituras</h3>';
                    $historico_html .= '<ul>';

                    foreach ($leitura_infos as $info) {
                        $historico_html .= '<li>' . esc_html($info) . '</li>';
                    }

                    $historico_html .= '</ul>';

                    $content .= $historico_html;
                    $historico_adicionado = true; // Marcamos como adicionado
                }
            }

            // Botão para resetar o histórico
            if ($historico_adicionado) {
                $content .= '<form method="post" class="resetar-historico-form">';
                $content .= '<input type="hidden" name="resetar_historico_post_id" value="' . esc_attr($post->ID) . '">';
                $content .= wp_nonce_field('resetar_historico_nonce', 'resetar_historico_nonce', true, false);
                $content .= '<button type="submit">Resetar Histórico</button>';
                $content .= '</form>';
            }
        }
    }
    return $content;
}
add_filter('the_content', 'meu_plugin_exibir_historico_leituras', 20);


// Função para processar a redefinição do histórico de leituras
function meu_plugin_processar_resetar_historico() {
    if (isset($_POST['resetar_historico_post_id']) && isset($_POST['resetar_historico_nonce'])) {
        if (wp_verify_nonce($_POST['resetar_historico_nonce'], 'resetar_historico_nonce')) {
            $post_id = intval($_POST['resetar_historico_post_id']);

            // Remover todas as entradas de confirmação de leitura
            delete_post_meta($post_id, '_mensagens_lidas');

            // Remover meta individual de usuários
            $users = get_users();
            foreach ($users as $user) {
                delete_user_meta($user->ID, '_confirmar_leitura_' . $post_id);
            }

            wp_redirect(get_permalink($post_id));
            exit;
        }
    }
}
add_action('init', 'meu_plugin_processar_resetar_historico');
?>
