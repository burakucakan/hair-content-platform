var WD = {
    
    Init: function () {
        WD.PageEnterAnimate();
        WD.ProductsSlider();
        WD.NumberAnimate();
        setInterval(WD.AutoSlider, 10000);

    },
    PageEnterAnimate:function(){
        $('.videoArea h3').animate({
            'opacity': '1',
            'bottom': '133px'
        }, { duration: 700, easing: 'easeInQuint' });

        $('.videoArea a.playVideo').animate({
            'opacity': '1',
            'top': '133px'
        }, { duration: 700, easing: 'easeOutBounce' })
    },
    ProductsSlider: function () {
        $('.productsSlider ul li:first-child').css('z-index', '999');
        var _sliderLength = $('.productsSlider ul li').length - 1;
        $('.productsSlider').append('<div class="sliderPoints"></div>');
        for (var i = 0; i <= _sliderLength; i++) {
            $('.productsSlider .sliderPoints').append('<a href="javascript:void(0)">' + i + '</a>');
        }
        $('.productsSlider .sliderPoints a:first').addClass('active');
        $('.productsSlider>ul>li:first').addClass('active');
        $('.productsSlider .sliderPoints a').click(function () {
            clearInterval(WD.AutoSlider);
            var _index = $(this).index();
            $('.productsSlider .sliderPoints a').removeClass('active');
            $('.productsSlider .sliderPoints a:eq(' + _index + ')').addClass('active');
            $('.productsSlider>ul>li.active').animate({ opacity: '0' }, 500).css('z-index', '-1');
            $('.productsSlider>ul>li').removeClass('active');
            $('.productsSlider>ul>li:eq(' + _index + ')').addClass('active');
            $('.productsSlider>ul>li:eq(' + _index + ')').animate({ opacity: '1' }, 2000).css('z-index', '999');
        });
    },
    AutoSlider: function () {
        var _sliderLength = $('.productsSlider ul li').length - 1;
        var _index = $('.productsSlider .sliderPoints a.active').index() + 1;
        if (_index - 1 == _sliderLength) {
            _index = 0;
        }
        $('.productsSlider .sliderPoints a').removeClass('active');
        $('.productsSlider .sliderPoints a:eq(' + _index + ')').addClass('active');
        $('.productsSlider>ul>li.active').animate({ opacity: '0' }, 500).css('z-index', '-1');
        $('.productsSlider>ul>li').removeClass('active');
        $('.productsSlider>ul>li:eq(' + _index + ')').addClass('active');
        $('.productsSlider>ul>li:eq(' + _index + ')').animate({ opacity: '1' }, 2000).css('z-index', '999');

    },
    NumberAnimate: function () {
        var numberValue = $('.count').text();
        var instant = 0;
        if (numberValue >= 900) {
            var instant = 900;
        }
        var refreshId = setInterval(function () {
            instant += 1;
            $('.count').html(instant);
            if (instant >= numberValue) {
                clearInterval(refreshId);
            }
        }, 3);
    }

}


$(function () {
    WD.Init();
});