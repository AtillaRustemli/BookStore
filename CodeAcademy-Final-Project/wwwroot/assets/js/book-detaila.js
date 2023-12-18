

try {
  $(document).ready(function () {
    console.log("salam");

    $(".scroller-book").slick({
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

//------------------slider-in-book-detail-----------------------
//---------------------drawer--------------------------

let wishLisDrawer = document.querySelector(".wish-list-drawer");
let wishLisCreateDrawer = document.querySelector(".wish-list-create-drawer");
let wishListDrawerOpenBtn = document.getElementsByClassName(
  "add-to-wish-list-btn"
);
let wishListCreateDrawerOpenBtn = document.getElementsByClassName(
  "wish-list-create-drawer-open-btn"
);
let wishListDrawerCloseBtn = document.querySelector(".cancel-btn");
let createDrawerCancelBtn = document.querySelector(".create-drawer-cancel-btn");
let createDrawerCancelBtnInForm = document.querySelector(".cancel-button");
Array.from(wishListDrawerOpenBtn).forEach((btn) => {
  btn.addEventListener("click", (e) => {
    e.preventDefault();
    e.stopPropagation();
    wishLisDrawer.classList.add("wish-list-drawer-open");
    body.classList.add("body-bg-white");
    console.log("Salam");
  });
});
wishListDrawerCloseBtn.addEventListener("click", (e) => {
  e.preventDefault;
  e.stopPropagation;
  wishLisDrawer.classList.remove("wish-list-drawer-open");
  body.classList.remove("body-bg-white");
});
wishLisDrawer.addEventListener("click", (e) => {
  e.stopPropagation();
});
document.addEventListener("click", (e) => {
  wishLisDrawer.classList.remove("wish-list-drawer-open");
  body.classList.remove("body-bg-white");
});
Array.from(wishListCreateDrawerOpenBtn).forEach((btn) => {
  btn.addEventListener("click", (e) => {
    e.preventDefault();
    e.stopPropagation();
    wishLisCreateDrawer.classList.add("wish-list-drawer-open");
    body.classList.add("body-bg-white");
    console.log("Salam");
  });
});
createDrawerCancelBtn.addEventListener("click", (e) => {
  e.preventDefault;
  e.stopPropagation;
  wishLisCreateDrawer.classList.remove("wish-list-drawer-open");

  wishLisDrawer.classList.remove("wish-list-drawer-open");
  body.classList.remove("body-bg-white");
});
createDrawerCancelBtnInForm.addEventListener("click", (e) => {
  e.preventDefault;
  e.stopPropagation;
  wishLisCreateDrawer.classList.remove("wish-list-drawer-open");

  wishLisDrawer.classList.remove("wish-list-drawer-open");
  body.classList.remove("body-bg-white");
});
wishLisCreateDrawer.addEventListener("click", (e) => {
  e.stopPropagation();
});
document.addEventListener("click", (e) => {
  wishLisCreateDrawer.classList.remove("wish-list-drawer-open");
  body.classList.remove("body-bg-white");
});
function selectAll() {
  Array.from(checknoxInWhishList).forEach((item) => {
    item.checked = true;
  });
}
//---------------------drawer--------------------------
