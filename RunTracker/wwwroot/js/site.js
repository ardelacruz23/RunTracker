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
    let firstDayOfMonth = new Date(currYear, currMonth, 1).getDay();
    let lastDateOfMonth = new Date(currYear, currMonth + 1, 0).getDate();
    let lastDayOfMonth = new Date(currYear, currMonth, lastDateOfMonth).getDay();
    let lastDateOfLastMonth = new Date(currYear, currMonth, 0).getDate();

    let daysInCalendar = "";

    for (let i = 0; i < firstDayOfMonth; i++) {
        daysInCalendar += `<td class="inactive">${lastDateOfLastMonth - firstDayOfMonth + i + 1}</td>`;
    }

    for (let i = 1; i <= lastDateOfMonth; i++) {
        let isToday = i === date.getDate() && currMonth === new Date().getMonth() && currYear === new Date().getFullYear() ? "active" : "";
        let hasData = localStorage.getItem(`${currYear}-${currMonth + 1}-${i}`) ? "has-data" : "";
        daysInCalendar += `<td class="${isToday} ${hasData}" data-date="${i}">${i}<span class="dot"></span></td>`;

        if ((i + firstDayOfMonth - 1) % 7 === 6 || i === lastDateOfMonth) {
            daysInCalendar = `<tr>${daysInCalendar}</tr>`;
        }
    }

    calendar.innerHTML = daysInCalendar;

    // Add event listener to each td element
    const tdElements = document.querySelectorAll(".calendar td");
    tdElements.forEach(td => {
        td.addEventListener("click", () => {
            // Get the date of the clicked cell
            const clickedDate = td.getAttribute("data-date");

            // Navigate to a specific page using the clicked date
            window.location.href = `https://localhost:7147/AddRun/AddRun?date=${clickedDate}`;
        });
    });
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

// select all the day cells
const dayCells = document.querySelectorAll(".calendar td");

// loop through each day cell and add a click listener
dayCells.forEach((cell) => {
    cell.addEventListener("click", () => {
        // get the day value from the cell
        const day = cell.textContent.trim();

        // build the URL for the DayView page
        const url = `/DayView?day=${day}&month=${currMonth + 1}&year=${currYear}`;

        // redirect the user to the DayView page
        window.location.href = url;
    });
});
/* end of calendar js */ 
