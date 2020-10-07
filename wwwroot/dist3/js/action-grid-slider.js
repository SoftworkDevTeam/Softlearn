$(document).ready(function(){
    // $('.ct-box-slider').slick({
    //   autoplay: false,
    //   autoplaySpeed: 4000,
    //   arrows: false,
    // });
    // $('#ct-js-box-slider--prev').on('click', function() {
    //   $('.ct-js-box-slider').slick('slickPrev');
    // });
    // $('#ct-js-box-slider--next').on('click', function() {
    //   $('.ct-js-box-slider').slick('slickNext');
    // });

    $('.slick-slider').each(function(key, item) {

      var sliderIdName = 'slider' + key;
      var sliderPrevNavIdName = 'sliderPrevNav' + key;
      var sliderNextNavIdName = 'sliderNextNav' + key;
      // var sliderBoxName = 'sliderBoxName' + key;
    
      // this.id = sliderIdName;
      $('.ct-box-slider')[key].id = sliderIdName;
      $('.ct-js-box-slider--prev')[key].id = sliderPrevNavIdName;
      $('.ct-js-box-slider--next')[key].id = sliderNextNavIdName;
      // $('.ct-js-box-slider')[key].id = sliderBoxName;
    
      var sliderId = '#' + sliderIdName;
      var sliderPrevNavId = '#' + sliderPrevNavIdName;
      var sliderNextNavId = '#' + sliderNextNavIdName;
      // var sliderBox = '#' + sliderBoxName;
    
      $(sliderId).slick({
        autoplay: false,
        autoplaySpeed: 4000,
        arrows: false,
      });
    
      $(sliderPrevNavId).on('click', function() {
          $(sliderId).slick('slickPrev');
      });
      $(sliderNextNavId).on('click', function() {
        $(sliderId).slick('slickNext');
      });
    });


    // $('.slider-for').each(function(key, item) {

    //   var sliderIdName = 'slider' + key;
    //   var sliderNavIdName = 'sliderNav' + key;
    
    //   this.id = sliderIdName;
    //   $('.slider-nav')[key].id = sliderNavIdName;
    
    //   var sliderId = '#' + sliderIdName;
    //   var sliderNavId = '#' + sliderNavIdName;
    
    //   $(sliderId).slick({
    //     slidesToShow: 1,
    //     slidesToScroll: 1,
    //     arrows: false,
    //     fade: true,
    //     asNavFor: sliderNavId
    //   });
    
    //   $(sliderNavId).slick({
    //     slidesToShow: 4,
    //     slidesToScroll: 1,
    //     asNavFor: sliderId,
    //     dots: true,
    //     arrows: true,
    //     centerMode: false,
    //     focusOnSelect: true
    //   });
    
    // });


  });