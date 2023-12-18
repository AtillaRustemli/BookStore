//-------------------------selected-refine----------------------
let refine_item = document.querySelectorAll(".refine-child-list");
let costFormSubmit = document.querySelector("#hidden-submit-button");

function selectedRefine(el) {
  let parentEl = el.parentNode;
  let allChilds = parentEl.getElementsByTagName("li");
  let checkBox = el.querySelector('input[type="radio"]');
  if (checkBox != null) {
    checkBox.checked = true;
    console.log("sagol");
    costForm.submit();
    costFormSubmit.click();
  }
  Array.from(allChilds).forEach((item) => {
    item.classList.remove("active-refine");
  });
  el.classList.add("active-refine");
}
console.log(costForm);
costForm.addEventListener("submit", (e) => {
  console.log("salam");
});
let typeOfBook = document.querySelector(".book-type");
function selectedBookType(el) {
  Array.from(typeOfBook.getElementsByTagName("li")).forEach((item) => {
    item.classList.remove("active-book-type");
  });
  el.classList.add("active-book-type");
}
//-------------------refine-----------------
let openRefine = document.querySelector(".refine-open-btn");
let refineClose = document.querySelector(".refine-cancel-btn");
let refine = document.querySelector(".refine");
openRefine.addEventListener("click", (e) => {
  e.preventDefault();
  e.stopPropagation();
  openRefine.style.display = "none";
  refine.style.display = "flex";
  refineClose.style.display = "block";
});
refineClose.addEventListener("click", (e) => {
  openRefine.style.display = "block";
  refine.style.display = "none";
  refineClose.style.display = "none";
});
