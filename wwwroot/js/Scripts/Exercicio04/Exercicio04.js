function verificaNumber() {

    var number = $("#number").val()

    if (number !== null && number !== "" && number > 0) {
        $.ajax({
            type: "GET",
            url: 'Exercicio04/verificaNumber?number='+number,
            success: function (result) {
                if (result === true) {
                    $("#numeroPerfeito").html("O numero " + number + " eh perfeito!")
                    $("#numeroPerfeito").removeClass("alert alert-primary")
                    $("#numeroPerfeito").removeClass("alert alert-danger")
                    $("#numeroPerfeito").addClass("alert alert-success")
                } else {
                    $("#numeroPerfeito").html("O numero " + number + " nao eh perfeito!")
                    $("#numeroPerfeito").removeClass("alert alert-primary")
                    $("#numeroPerfeito").removeClass("alert alert-success")
                    $("#numeroPerfeito").addClass("alert alert-danger")
                }
            },
            error: function (result) {
                console.log("erro");
            }
        });
    } else {
        alert("Nenhum numero para verificar")
    }

}

