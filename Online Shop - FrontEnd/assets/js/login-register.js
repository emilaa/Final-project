let area = document.querySelector("#login-register .col-12");
let click = document.querySelectorAll(".login-form a");

function toggleForm() {
  area.classList.toggle("active");
}

click.addEventListener("click", toggleForm())
