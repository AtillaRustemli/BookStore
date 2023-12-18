//-------------------toggle-Content---------------------------

function toggleContent(selectedItem) {
  let listIems = document.getElementsByClassName("wish-list-item");
  Array.from(listIems).forEach((item) => {
    item.classList.remove("active");
  });
  selectedItem.classList.add("active");
}
//-------------------toggle-Content---------------------------
//---------------------submit-form----------------------------

function submitForm() {
  /*Burada istifade etdiyim list-de "form" tag-i yoxdur deye 
fetch-le formdata-ya append etdiyim datani backende gonderib responce aliram*/

  let formData = new FormData();

  let checkboxes = document.querySelectorAll('input[type="checkbox"]');
  checkboxes.forEach(function (checkbox) {
    if (checkbox.checked) {
      formData.append(checkbox.name, checkbox.value);
    }
  });

  fetch("http://localhost:5262/api/Account", {
    method: "POST",
    body: formData,
  })
    .then((response) => {
      if (!response.ok) {
        throw new Error("Network response was not ok");
      }
    })
    .catch((error) => {
      console.error("Error:", error);
    });

  for (var pair of formData.entries()) {
    console.log(pair[0] + ": " + pair[1]);
  }
  console.log("Form data:", formData);
}
//---------------------submit-form----------------------------
//---------------------select-all----------------------------

let selectSubmit = document.querySelector(".select-submit");

let checkboxInWhishList = document.getElementsByClassName(
  "checkbox-in-wish-list"
);
let allCheckbox = document.querySelectorAll('input[type="checkbox"]');
let selectAllBtn = document.querySelector(".select-all-btn-wish-list");

function selectall(elem) {
  Array.from(checkboxInWhishList).forEach((item) => {
    item.checked = elem.checked;
  });
  if (elem.checked) {
    selectSubmit.classList.add("select-submit-btn-open");
  } else {
    selectSubmit.classList.remove("select-submit-btn-open");
  }
}
function checkSelectAll() {
  let allCheckboxChecked = Array.from(checkboxInWhishList).every(function (
    item
  ) {
    return item.checked;
  });
  if (allCheckboxChecked) {
    selectAllBtn.checked = true;
  }
  Array.from(checkboxInWhishList).forEach((item) => {
    if (!item.checked) {
      selectAllBtn.checked = false;
    }
  });
  let isChecked = Array.from(allCheckbox).some((item) => {
    return item.checked;
  });
  console.log(isChecked);

  if (isChecked) {
    selectSubmit.classList.add("select-submit-btn-open");
  } else {
    selectSubmit.classList.remove("select-submit-btn-open");
  }
}

//----------------nav-list------------
let nav_list = document.getElementsByClassName("wish-list-nav-list-item");

function selectWishListNav(el) {
  Array.from(nav_list).forEach((item) => {
    item.classList.remove("wish-list-active");
  });
  el.classList.add("wish-list-active");
}

//--------------------------select-all---------------------------------
//---------------------select-submit-drawer----------------------------
let editDrawerBtn = document.querySelector(".edit");
let editDrawerBtnClose = document.querySelector(".cancel-edit-drawer");
let editDrawer = document.querySelector(".edit-drawer");
let bodyBg = document.querySelector("body");
let editDrawerCancelBtn = document.querySelector(".edit-drawer-cancel-btn");
let saveEditDrawerBtn = document.querySelector(".save");

saveEditDrawerBtn.addEventListener("click", (e) => {
  editDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
  location.reload();
});
editDrawerBtnClose.addEventListener("click", (e) => {
  e.preventDefault();
  editDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
});

editDrawer.addEventListener("click", (e) => {
  e.stopPropagation();
});
editDrawerBtn.addEventListener("click", (e) => {
  e.stopPropagation();
  editDrawer.style.display = "flex";
  bodyBg.classList.add("body-bg-black");
});
editDrawerCancelBtn.addEventListener("click", (e) => {
  editDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
});
document.addEventListener("click", (e) => {
  editDrawer.style.display = "none";
  deleteDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
});

//---------------------select-submit-drawer----------------------------
//---------------------delete-submit-drawer----------------------------

let deleteDrawerBtn = document.querySelector(".delete");
let deleteDrawerClose = document.querySelector(".delete-drawer-cancel-btn");
let deleteDrawer = document.querySelector(".asking-delete");
let deleteDrawerCancel = document.querySelector(".cancel-delete");
deleteDrawerBtn.addEventListener("click", (e) => {
  e.preventDefault();
  e.stopPropagation();
  deleteDrawer.style.display = "flex ";
  bodyBg.classList.add("body-bg-black");
});
deleteDrawer.addEventListener("click", (e) => {
  e.stopPropagation();
});
deleteDrawerCancel.addEventListener("click", (e) => {
  e.preventDefault();
  deleteDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
});
deleteDrawerClose.addEventListener("click", (e) => {
  e.preventDefault();
  deleteDrawer.style.display = "none";
  bodyBg.classList.remove("body-bg-black");
});
