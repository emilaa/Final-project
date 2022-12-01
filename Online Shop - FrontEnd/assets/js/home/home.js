"use strict";
$(function () {
  $("#product-slider").owlCarousel({
    items: 4,
    itemsDestop: [1199, 2],
    itemsDestopSmall: [980, 2],
    itemsMoile: [700, 1],
    pagination: false,
    navigation: true,
    navigationText: ["", ""],
    autoPlay: true,
  });

  $("#product-slider-2").owlCarousel({
    items: 4,
    itemsDestop: [1199, 2],
    itemsDestopSmall: [980, 2],
    itemsMoile: [700, 1],
    pagination: false,
    navigation: true,
    navigationText: ["", ""],
    autoPlay: true,
  });
});
