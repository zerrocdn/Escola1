
function loadCabecalhos() {
    document.writeln("<h1 class='uc'>Unidade Curricular - TWAM</h1>");
    document.writeln("<h2>Engenharia Inform�tica - Ano Lectivo 2017-2018</h2>");
    document.writeln("<h3>Exemplos de Javascript:</h3>");
}

function verificaIdade(idade,idNode){
	var msg=document.getElementById(idNode);
	if (idade < 18){
		msg.innerHTML="<b>Não</b>, sou menor.";
	}
	else{
		msg.innerHTML="<b>Sim</b>, sou Maior.";	
	}
}

function selecaoPais(codPais) {

    msg=document.getElementById(codPais);
	//Obt�m o valor do c�digo do pa�s atrav�s do elemento select
    var valor = document.getElementById("pais").value;
    /*
	Forma alternativa de obter o c�digo do pa�s atrav�s do elemento select
    indice = window.document.forms[0].pais.selectedIndex;
	valor = window.document.forms[0].pais.options[indice].value;
	*/

    msg.innerHTML="<b>"+valor+"</b>";
}

function validation(idNode){

    //nome = getElementById("nome").value; //Obt�m o nome
    var n=document.querySelector('#nome').value; //Outra forma alternativa de obter o nome
    var p=document.getElementById("pais").options[pais.selectedIndex].text; //Obt�m o texto do item da dropdownbox
    var msg="Nome: "+n+"<br>Pa�s Selecionado:"+p+"";
    document.getElementById(idNode).innerHTML = msg;
	return false;
}