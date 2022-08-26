let menu = document.querySelector("#menu-btn");
let navbar = document.querySelector(".header .nav");

menu.addEventListener('click', () => {
    menu.classList.toggle('fa-times');

});
let menu = document.querySelector("#menu-btn");
let navbar = document.querySelector(".header .nav");
let header = document.querySelector(".header");
let message = document.querySelector(".message");
setTimeout(() => {
    message.style.display = "none";
}, 2000)
menu.addEventListener('click', () => {

    menu.classList.toggle('fa-times');
    navbar.classList.toggle('active');

});
window.onscroll = () => {
    menu.classList.remove("fa-times");
    navbar.classList.remove("active");
    if (window.scrollY > 0) {
        header.classList.add('active');
        document.getElementById("top").style.display = "block";
    } else {
        header.classList.remove("active");
        document.getElementById("top").style.display = "none";
    }
};