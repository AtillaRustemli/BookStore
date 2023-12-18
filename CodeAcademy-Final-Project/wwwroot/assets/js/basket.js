let targetSection = document.querySelector(".basket-cart");
let totalCount = document.querySelector(".total-count-fixed");
function startFunction() {
  console.log("salam");
  totalCount.classList.add("foxed-p-for-total-count");
}

function endFunction() {
  console.log("Leaving the section");
  targetSection.style.background = "white";
  totalCount.classList.remove("foxed-p-for-total-count");
}

window.addEventListener("scroll", () => {
  let sectionRect = targetSection.getBoundingClientRect();
  let totalCountRect = targetSection.getBoundingClientRect();
  console.log(totalCountRect.bottom);
  console.log(sectionRect.bottom);
  console.log(sectionRect.top);
  if (sectionRect.top <= 0 || totalCountRect.bottom == window.innerHeight) {
    startFunction();
  } else {
    endFunction();
  }
});
