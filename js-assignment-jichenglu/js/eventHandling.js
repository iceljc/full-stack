function addition() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    let c = parseFloat(a) + parseFloat(b);
    document.querySelector("#txtResult").value = c;
}

function subtraction() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    let c = parseFloat(a) - parseFloat(b);
    document.querySelector("#txtResult").value = c;
}

function multiplication() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    let c = parseFloat(a) * parseFloat(b);
    document.querySelector("#txtResult").value = c;
}


function division() {
    let a = document.querySelector("#txtFirstNumber").value;
    let b = document.querySelector("#txtSecondNumber").value;
    let c = parseFloat(a) / parseFloat(b);
    document.querySelector("#txtResult").value = c;
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