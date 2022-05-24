function tabuada() {

    var number = $("#number").val()

    if (number !== null && number !== "") {
        var result = "A tabuada do " + number + ":\n" ;
        for (var i = 0; i < 11; i++) {
            result += number + " x " + i + " = " + number * i + " \n";
        }
        $("#txtTab").val(result)
    } else {
        alert("Nenhum numero para mostrar")
    }

}

