import HttpService from '../services/httpService.js';

export class UserController {

    getUsers(url) {
        let http = new HttpService();
        http.get(url).then(data => {
            let tbody = document.querySelector("#tblUser");
            let length = data.length;
            tbody.innerHTML = "";

            for (let i = 0; i < length; i++) {
                let id = data[i].id;
                let name = data[i].name;
                let email = data[i].email;
                let address = data[i].address;
                let street = address.street + ", " + address.suite;
                let city = address.city;
                let phone = data[i].phone.split(" ")[0];
                let company = data[i].company.name;

                let tr = `<tr><td>${id}</td> <td>${name}</td> <td>${email}</td> <td>${phone}</td> <td>${street}</td> <td>${city}</td> <td>${company}</td></tr>`;
                tbody.innerHTML += tr;
            }

            let msg = document.querySelector(".info p")
            msg.innerText = "Loading successfully!";
            msg.style.color = 'green';
        }).catch(error => {
            let msg = document.querySelector(".info p")
            msg.innerText = error;
            msg.style.color = 'red';
        });
    }
}

