"use strict";
$(function () {
  let scrollSection = document.getElementById("scroll-section");

  window.onscroll = function () {
    scrollFunction();
  };

  function scrollFunction() {
    if (
      document.body.scrollTop > 195 ||
      document.documentElement.scrollTop > 195
    ) {
      scrollSection.style.top = "0";
    } else {
      scrollSection.style.top = "-200px";
      $("div").removeClass("inActive");
    }
  }

  $(".filter-item").click(function () {
    const value = $(this).attr("data-filter");
    if (value == "all") {
      $(".post-box").show("1000");
    }
    else{
      $(".post-box").not("." + value).hide("1000");
      $(".post-box").filter("." + value).show("1000");
    }
  });

  $(".filter-item").click(function () {
    $(this).addClass("active-filter").siblings().removeClass("active-filter");
  });
});

const rangeInput = document.querySelectorAll(".range-input input"),
  priceInput = document.querySelectorAll(".input-price input"),
  progress = document.querySelector(".range .progress");

let priceGap = 50;

priceInput.forEach((input) => {
  input.addEventListener("input", (e) => {
    let minVal = parseInt(priceInput[0].value),
      maxVal = parseInt(priceInput[1].value);

    if (maxVal - minVal >= priceGap && maxVal <= 631) {
      if (e.target.className === "input-min") {
        rangeInput[0].value = minVal;
        progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
      } else {
        rangeInput[1].value = maxVal;
        progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
      }
    }
  });
});

rangeInput.forEach((input) => {
  input.addEventListener("input", (e) => {
    let minVal = parseInt(rangeInput[0].value),
      maxVal = parseInt(rangeInput[1].value);

    if (maxVal - minVal < priceGap) {
      if (e.target.className === "range-min") {
        rangeInput[0].value = maxVal - priceGap;
      } else {
        rangeInput[1].value = minVal + priceGap;
      }
    } else {
      priceInput[0].value = minVal;
      priceInput[1].value = maxVal;
      progress.style.left = (minVal / rangeInput[0].max) * 100 + "%";
      progress.style.right = 100 - (maxVal / rangeInput[1].max) * 100 + "%";
    }
  });
});

let addHeart = document.querySelectorAll("#shop-product .categories .fa-heart");

let products = [];

if (localStorage.getItem("products") != null) {
  products = JSON.parse(localStorage.getItem("products"));
}

addHeart.forEach((heartBtn) => {
  heartBtn.addEventListener("click", function (e) {
    e.preventDefault();

    let productImg =
      this.parentNode.parentNode.parentNode.parentNode.parentNode.firstElementChild.firstElementChild.getAttribute(
        "src"
      );
    let categoryName =
      this.parentNode.parentNode.parentNode.parentNode.nextElementSibling
        .firstElementChild.firstElementChild.innerText;
    let productName =
      this.parentNode.parentNode.parentNode.parentNode.nextElementSibling
        .firstElementChild.nextElementSibling.firstElementChild.innerText;
    let productPrice =
      this.parentNode.parentNode.parentNode.parentNode.nextElementSibling
        .lastElementChild.innerText;

    products.push({
      image: productImg,
      category: categoryName,
      name: productName,
      price: productPrice,
      count: 1,
    });

    localStorage.setItem("products", JSON.stringify(products));
  });
});
