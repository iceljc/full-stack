function addition() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;

    try {
        let num_a = parseFloat(a);
        let num_b = parseFloat(b);
        if (isNaN(num_a) || isNaN(num_b)) {
            throw new Error("Please input a number.");
        }
        let c = num_a + num_b;
        document.querySelector("#txtResult").value = c;
    } catch (e) {
        alert(e.message);
        document.querySelector("#txtResult").value = "";
    }

    
}

function subtraction() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    
    try {
        let num_a = parseFloat(a);
        let num_b = parseFloat(b);
        if (isNaN(num_a) || isNaN(num_b)) {
            throw new Error("Please input a number.");
        }
        let c = num_a - num_b;
        document.querySelector("#txtResult").value = c;
    } catch (e) {
        alert(e.message);
        document.querySelector("#txtResult").value = "";
    }
}

function multiplication() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;

    try {
        let num_a = parseFloat(a);
        let num_b = parseFloat(b);
        if (isNaN(num_a) || isNaN(num_b)) {
            throw new Error("Please input a number.");
        }
        let c = num_a * num_b;
        document.querySelector("#txtResult").value = c;
    } catch (e) {
        alert(e.message);
        document.querySelector("#txtResult").value = "";
    }
}


function division() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    
    try {
        let num_a = parseFloat(a);
        let num_b = parseFloat(b);
        if (isNaN(num_a) || isNaN(num_b)) {
            throw new Error("Please input a number.");
        }

        if (num_b == 0) {
            throw new Error("Zero division.");
        }

        let c = num_a / num_b;
        document.querySelector("#txtResult").value = c;
    } catch (e) {
        alert(e.message);
        document.querySelector("#txtResult").value = "";
    }
}


function arithematic(callback) {
    callback();
}


function calculation() {
    let operation = document.querySelector("#drpOptions").value;

    if (operation == "addition") {
        arithematic(addition);
    } else if (operation == "subtraction") {
        arithematic(subtraction);
    } else if (operation == "multiplication") {
        arithematic(multiplication);
    } else if (operation == "division") {
        arithematic(division);
    } else {
        document.querySelector("#txtResult").value = "no value";
    }
        

}

function countChars() {
    let a = document.querySelector("#txtAreaMsg").value.length;
    document.querySelector("#lblmsg").innerText = a + "/10";
}