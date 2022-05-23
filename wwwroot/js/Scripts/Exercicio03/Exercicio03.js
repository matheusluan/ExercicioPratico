async function buscarCep() {

    var cep = document.getElementById("cepNumber").value;

    var url = "http://viacep.com.br/ws/" + cep + "/json/"

    const dados = await fetch(url);
    const endereco = await dados.json();

    console.log(endereco)

    $("#logradouro").val(endereco.logradouro)
    $("#cidade").val(endereco.localidade)
    $("#estado").val(endereco.uf)
    $("#bairro").val(endereco.bairro)

}

