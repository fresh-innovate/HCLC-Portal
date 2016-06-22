HACKNEY = {};
 
HACKNEY.init = (function(){
        $(function () {
            $('[data-toggle="tooltip"]').tooltip();
            
            $(".btn-switch-language").on("click", toggleLanguageSwitch)
            
        });
        
        function toggleLanguageSwitch(e)
        {
            e.preventDefault
            if ($('#language-switch').css('marginTop') == '0px') {
                $('#language-switch').animate({ marginTop: '-337px' }, 1000);
            }
            else
            {
                $('#language-switch').animate({ marginTop: '0px' }, 1000);
            }
        }
}());

HACKNEY.init;