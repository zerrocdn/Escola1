function loadHeader() {
    document.writeln("<h1>O Meu Sítio Web Pessoal</h1>");
}

function navBar(currentPage){

    var home = "<a href='index.htm'>Início</a>";
    var schedule = "<a href='horario.htm'>Horário</a>";
    var cv = "<a href='cv.htm'>CV</a>";
    var contacts = "<a href='contacto.htm'>Contactos</a>";
    
    if(currentPage == "Início"){
        document.writeln(currentPage + " | "+ cv +" | " + schedule +" | " + contacts + " | ");
    }else if(currentPage == "CV")
    {
        document.writeln(home + " | "+ currentPage +" | " + schedule +" | " + contacts + " | ");
    }else if(currentPage == "Horário"){
        document.writeln(home + " | "+ cv +" | " + currentPage +" | " + contacts + " | ");
    }else if(currentPage == "Contactos"){
        document.writeln(home + " | "+ cv +" | " + schedule +" | " + currentPage + " | ");
    }
}

function loadFooter(){
    document.writeln("Última actualização: 20/04/2018.<br>The HTML code of this page is validated by <a href='https://validator.w3.org/'>HTML W3C Validator</a>.<br>The CSS code is validated by <a href='https://jigsaw.w3.org/css-validator/'>CSS W3C Validator</a>.");
}

