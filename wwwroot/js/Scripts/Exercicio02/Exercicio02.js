$(document).ready(function () {
    
    $("#inputEx01").keypress(function (event) {

        if (event.which == 13) {
            event.preventDefault();
            var textArea = $("#textAreaEx01").val();

            $("#textAreaEx01").val(textArea === '' ? $("#inputEx01").val() : textArea + ";" + $("#inputEx01").val())

            $("#inputEx01").val(null)
        
        }
   
    });

    $("#orderNumbers").click(function () {
        var textArea = $("#textAreaEx01").val();

        if (textArea === '') {
            alert("Sem numeros para ordenar :/")
            return
        }

        var textAreaOrder = textArea.split(";").map(Number);

        textAreaOrder = textAreaOrder.sort((a, b) => {
            if (a > b) return 1;
            if (a < b) return -1;

            return 0;
        })

        $("#textAreaEx02").val(textAreaOrder)
      
    });  

    $("#saveArchiveNumbers").click(function () {
        var textArea = $("#textAreaEx02").val();

        if (textArea === '') {
            alert("Sem numeros para salvar :/")
            return
        }

    });
});
