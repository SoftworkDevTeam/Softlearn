/* =================================
------------------------------------
	SoftLearn - Education Template
	Version: 1.0
 ------------------------------------ 
 ====================================*/


'use strict';


$(window).on('load', function() {
	/*------------------
		Preloder
	--------------------*/
	$(".loader").fadeOut(); 
	$("#preloder").delay(400).fadeOut("slow");


	/*------------------
			Badge
		--------------------*/
	// $("#badgevisibility").hide();
	$(".clickme").click(function() {
	$("#badgevisibility").fadeToggle(300);
	});


	/*------------------
		Gallery item
	--------------------*/
	if($('.course-items-area').length > 0 ) {
		var containerEl = document.querySelector('.course-items-area');
		// var mixer = mixitup(containerEl);
		var mixer = mixitup(containerEl, {
			selectors: {
				// target: '[data-ref~="mixitup-target"]',
				control: '[data-mixitup-control]'
			}
		});
	}

});

(function($) {

	/*------------------
		Navigation
	--------------------*/
	$('.nav-switch').on('click', function(event) {
		$('.main-menu').slideToggle(400);
		event.preventDefault();
	});

	// $(".nav-tabs li.nav-item").click(function() {
	// 	$(".nav-tabs li.nav-item").removeClass('active');
	//   });


	/*------------------
		Background Set
	--------------------*/
	$('.set-bg').each(function() {
		var bg = $(this).data('setbg');
		$(this).css('background-image', 'url(' + bg + ')');
	});


	/*------------------
		Realated courses
	--------------------*/
    $('.rc-slider').owlCarousel({
		autoplay:true,
		loop: true,
		nav:true,
		dots: false,
		margin: 30,
		navText: ['', '<i class="fa fa-angle-right"></i>'],
		responsive:{
			0:{
				items:1
			},
			576:{
				items:2
			},
			990:{
				items:3
			},
			1200:{
				items:4
			}
		}
	});


    /*------------------
		Accordions
	--------------------*/
	$(document).ready(function(){
		// Add minus icon for collapse element which is open by default
		$(".collapse.show").each(function(){
		  $(this).prev(".card-header").find(".fa").addClass("fa-minus").removeClass("fa-plus");
		});
		// Toggle plus minus icon on show hide of collapse element
		$(".collapse").on('show.bs.collapse', function(){
		  $(this).prev(".card-header").find(".fa").removeClass("fa-plus").addClass("fa-minus");
		}).on('hide.bs.collapse', function(){
		  $(this).prev(".card-header").find(".fa").removeClass("fa-minus").addClass("fa-plus");
		});
	  });

	/*------------------
		Circle progress
	--------------------*/
	$('.circle-progress').each(function() {
		var cpvalue = $(this).data("cpvalue");
		var cpcolor = $(this).data("cpcolor");
		var cptitle = $(this).data("cptitle");
		var cpid 	= $(this).data("cpid");

		$(this).append('<div class="'+ cpid +'"></div><div class="progress-info"><h2>'+ cpvalue +'%</h2><p>'+ cptitle +'</p></div>');

		if (cpvalue < 100) {

			$('.' + cpid).circleProgress({
				value: '0.' + cpvalue,
				size: 176,
				thickness: 9,
				fill: cpcolor,
				emptyFill: "rgba(0, 0, 0, 0)"
			});
		} else {
			$('.' + cpid).circleProgress({
				value: 1,
				size: 176,
				thickness: 9,
				fill: cpcolor,
				emptyFill: "rgba(0, 0, 0, 0)"
			});
		}

	});


	/*------------------
			Back to top
		--------------------*/
		/*Scroll to top when arrow up clicked BEGIN*/
		$(window).scroll(function() {
			var height = $(window).scrollTop();
			if (height > 100) {
				$('#myBtn').fadeIn();
			} else {
				$('#myBtn').fadeOut();
			}
		});
		$(document).ready(function() {
			$("#myBtn").click(function(event) {
				event.preventDefault();
				$("html, body").animate({ scrollTop: 0 }, "slow");
				return false;
			});

		});
		/*Scroll to top when arrow up clicked END*/


})(jQuery);

