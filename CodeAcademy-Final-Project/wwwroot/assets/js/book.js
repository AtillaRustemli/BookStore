//------------------new-releases-----------------------
try {
  $(document).ready(function () {
    $(".new-releases-books").slick({
      dots: true,
      infinite: false,
      speed: 300,
      slidesToShow: 7,
      slidesToScroll: 6,
      prevArrow:
        ' <span class="priv-arrow"><i class="fa-solid fa-angle-left" style="color: #000000;"></i></span>',
      nextArrow:
        '<span class="next-arrow"><i class="fa-solid fa-angle-right" style="color: #000000;"></i></span>',
      responsive: [
        {
          breakpoint: 1024,
          settings: {
            slidesToShow: 5,
            slidesToScroll: 4,
            infinite: true,
            dots: true,
          },
        },
        {
          breakpoint: 600,
          settings: {
            slidesToShow: 2,
            slidesToScroll: 2,
          },
        },
        {
          breakpoint: 480,
          settings: {
            slidesToShow: 1,
            slidesToScroll: 1,
          },
        },
      ],
    });
  });
} catch (error) {
  console.log("An error occurred:", error.message);
}

//------------------new-releases-----------------------
//---------------------drawer--------------------------

let body = document.querySelector("body");
let drawer = document.querySelector(".drawer");
let drawerOpenBtn = document.getElementsByClassName("drawer-open-btn");
let drawerCloseBtn = document.querySelector(".drawer-cancel-btn");
Array.from(drawerOpenBtn).forEach((btn) => {
  btn.addEventListener("click", (e) => {
    e.preventDefault();
    e.stopPropagation();
    drawer.classList.add("drawer-open");
    body.classList.add("body-bg-black");
  });
});
drawerCloseBtn.addEventListener("click", (e) => {
  e.preventDefault;
  e.stopPropagation;
  drawer.classList.remove("drawer-open");
  body.classList.remove("body-bg-black");
});
drawer.addEventListener("click", (e) => {
  e.stopPropagation();
});
document.addEventListener("click", (e) => {
  drawer.classList.remove("drawer-open");
  body.classList.remove("body-bg-black");
});
//---------------------drawer--------------------------
//------------------trending-now-----------------------
let trending_now_first_child = document.querySelector(
  "#trending-now-first-child"
);
let trending_now_books = document.getElementsByClassName("trending-now-books");
Array.from(trending_now_books).forEach((book) => {
  book.style.height = `${trending_now_first_child.clientHeight}px`;
});
window.addEventListener("resize", function () {
  location.reload();
});
//-----------------------trending-now---------------------------
//---------------------Header-in-sroll--------------------------
window.addEventListener("scroll", function () {
  let currentHeight = document.documentElement.scrollTop;
  let headerHeight =
    document.querySelector(".nav").clientHeight +
    document.querySelector("header").clientHeight;

  let header_in_scroll = document.querySelector(".header-in-scroll");
  if (currentHeight >= headerHeight) {
    header_in_scroll.classList.add("header-visible");
  } else {
    header_in_scroll.classList.remove("header-visible");
  }
});
let heights = document.getElementsByTagName("section");
let count = 0;
Array.from(heights).forEach((h) => {
  count += h.clientHeight;
});

//---------------------Header-in-sroll--------------------------
//------------------------Promotions----------------------------

let promotion_item = document.getElementsByClassName("promotions-inner-item");

Array.from(promotion_item).forEach((e) => {
  e.style.height;
});
let pageHeight = Math.max(
  document.body.scrollHeight,
  document.documentElement.scrollHeight
);

console.log("Page height:", pageHeight);
