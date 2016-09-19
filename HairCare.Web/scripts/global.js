$(function () {

    //initHairTypeSelector();    
 
});

function initHairTypeSelector() {
    var $container = $('#container');
    $checkboxes = $('#filters input');

    $container.isotope({
        itemSelector: '.item',
        masonry: {
            columnWidth: 100
        }
    });

    $checkboxes.change(function () {
        var filters = [];

        $checkboxes.filter(':checked').each(function () {
            filters.push(this.value);
        });

        filters = filters.join(', ');

        if (filters !== '*') {
            // include corner-stamp in filter
            // so it never gets filtered out
            filters = filters + ', .stamp'
        }

        $container.isotope({ filter: filters });
    });

    $("#reset").click(function () {
        $("#container").isotope({
            filter: '*'
        });
    });

    $(".rating input:radio").attr("checked", false);
    $('.rating input').click(function () {
        $(".rating span").removeClass('checked');
        $(this).parent().addClass('checked');
    });

    $('input:radio').change(function () {
        var userRating = this.value;
        alert(userRating);
    });

    $("input:checkbox").on('click', function () {

        var $box = $(this);
        if ($box.is(":checked")) {

            var group = "input:checkbox[name='" + $box.attr("name") + "']";

            $(group).prop("checked", false);
            $box.prop("checked", true);
        } else {
            $box.prop("checked", false);
        }
    });

}