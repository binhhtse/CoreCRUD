﻿
//$("#DateOfBirth").datepicker({
//    dateFormat: 'yy-mm-dd ',
//    maxDate: '0',
//    changeMonth: true,
//    changeYear: true
//});

$('#DateOfBirth').on('click', function () {
    //$("#DateOfBirth").remove();
    $(this).datepicker({
        dateFormat: 'yy-mm-dd ',
        maxDate: '0',
        changeMonth: true,
        changeYear: true
    });
});

$.validate({
    lang: 'en',
    modules: 'location, date, security, file',
    onModulesLoaded: function () {
        $('#country').suggestCountry();
    }
});


