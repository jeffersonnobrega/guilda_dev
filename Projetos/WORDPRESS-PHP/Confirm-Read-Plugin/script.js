jQuery(document).ready(function($) {
    $('.historicos-toggle').click(function() {
        $(this).next('.historicos-content').slideToggle();
    });
});
