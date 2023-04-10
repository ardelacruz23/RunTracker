// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

/* calendar js */
const leftBtn = document.querySelector(".left-btn");
const rightBtn = document.querySelector(".right-btn");
const monthYear = document.querySelector(".month-year span");
const daysOfWeek = document.querySelector(".days-of-week");
const calendar = document.querySelector(".calendar");

let date = new Date();
let currYear = date.getFullYear();
let currMonth = date.getMonth();

const months = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

function renderCalendar() {
    let firstDayofMonth = new Date(currYear, currMonth, 1).getDay();
    let lastDateofMonth = new Date(currYear, currMonth + 1, 0).getDate();
    let lastDayofMonth = new Date(currYear, currMonth, lastDateofMonth).getDay();
    let lastDateofLastMonth = new Date(currYear, currMonth, 0).getDate();

    let daysInCalendar = "";

    for (let i = 0; i < firstDayofMonth; i++) {
        daysInCalendar += `<td class="inactive">${lastDateofLastMonth - firstDayofMonth + i + 1}</td>`;
    }

    for (let i = 1; i <= lastDateofMonth; i++) {
        let isToday = i === date.getDate() && currMonth === new Date().getMonth() && currYear === new Date().getFullYear() ? "active" : "";
        daysInCalendar += `<td class="${isToday}">${i}</td>`;

        if ((i + firstDayofMonth - 1) % 7 === 6 || i === lastDateofMonth) {
            daysInCalendar = `<tr>${daysInCalendar}</tr>`;
        }
    }

    calendar.innerHTML = daysInCalendar;
}

renderCalendar();

leftBtn.addEventListener("click", () => {
    currMonth--;
    if (currMonth < 0) {
        currMonth = 11;
        currYear--;
    }
    monthYear.textContent = `${months[currMonth]} ${currYear}`;
    renderCalendar();
});

rightBtn.addEventListener("click", () => {
    currMonth++;
    if (currMonth > 11) {
        currMonth = 0;
        currYear++;
    }
    monthYear.textContent = `${months[currMonth]} ${currYear}`;
    renderCalendar();
});
/* end of calendar js */
