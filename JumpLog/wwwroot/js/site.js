// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const soldiers = [
    {
        lastName: "Morales",
        firstName: "Josh",
        rank: "SPC",
        dodId: "12345678",
        ssn: "12345678",
        company: "C",
        platoon: "1",
        dateArrived: "3/27/2021"
    },
    {
        lastName: "Dorsey",
        firstName: "Joe",
        rank: "SPC",
        dodId: "87654321",
        ssn: "87654321",
        company: "C",
        platoon: "3",
        dateArrived: "3/28/2021"
    }
]

const addSoldierButton = document.querySelector("#add-soldier-submit")
const lastNameInput = document.querySelector("#last-name")
const firstNameInput = document.querySelector("#first-name")
const rankInput = document.querySelector("#rank")
const dodIdInput = document.querySelector("#dod-id")
const ssnInput = document.querySelector("#ssn")
const companyInput = document.querySelector("#company")
const platoonInput = document.querySelector("#platoon")
const dateArrivedInput = document.querySelector("#date-arrived")

addSoldierButton.addEventListener("click", addSoldier)

function addSoldier(e) {
    e.preventDefault();

    let soldier = {
        lastName: lastNameInput.value,
        firstName: firstNameInput.value,
        rank: rankInput.value,
        dodId: dodIdInput.value,
        ssn: ssnInput.value,
        company: companyInput.value,
        platoon: platoonInput.value,
        dateArrived: dateArrivedInput.value
    }
    soldiers.push(soldier)
    console.log(soldier)
}
