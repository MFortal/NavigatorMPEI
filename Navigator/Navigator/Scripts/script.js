document.getElementById("btn-reset").onclick = function(e) {
  document.getElementById("search-from").value = "";
  document.getElementById("search-to").value = "";
}

document.getElementById("change-btn").onclick = function(e){
  var value1=document.getElementById("search-from").value;
  var value2=document.getElementById("search-to").value;
   
  document.getElementById("search-from").value = value2;
  document.getElementById("search-to").value = value1;
}

document.getElementById("search-btn").onclick = function(e){
  alert("Отправка данных...");
}

// var object = document.getElementById("object"); //получаем элмент object
// var svgDocument = object.contentDocument; //получаем svg элемент внутри object
// var svgElement = svgDocument.getElementById("RU-KYA"); //получаем любой элемент внутри svg
// svgElement.
// setAttribute("fill", "yellow"); //меняем атрибуты выбранного элемента

//  for (var p of document.getElementsByTagName('path')) {
//      p.onclick = function() {
//      this.style.fill = this.style.fill === 'red' ? 'black' : 'red';
//    }
//  }
