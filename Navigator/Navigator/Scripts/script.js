document.getElementById("btn-reset").onclick = function(e) {
  document.getElementById("search-from").value = "";
  document.getElementById("search-to").value = "";
}

document.getElementById("change-btn").onclick = function (e) {
    var value1 = document.getElementById("search-from").value;
    var value2 = document.getElementById("search-to").value;

    document.getElementById("search-from").value = value2;
    document.getElementById("search-to").value = value1;
}

// Замена value полей поиска
$('button[name=from]').on('click', function () {
    document.getElementById("search-from").value = $(this).attr('data-value');
});

$('button[name=to]').on('click', function () {
    document.getElementById("search-to").value = $(this).attr('data-value');
});

// Изменение цвета polyline когда мышка над названием
$('.scheme-item').hover(
	function(){
		$('.scheme polyline[data-id=' + $(this).data('id') + ']').attr('id', 'hover');
	},
	function(){
		$('.scheme polyline[data-id=' + $(this).data('id') + ']').attr('id', '');
	}
);	

// Клик по названию - открывается подсказка
$('.scheme-item').on('click', function(){
	$('.scheme-popup').hide();
	$('.scheme polyline').attr('class', '');

	var popup = $(this).find('.scheme-popup');
	$(popup).css('top', '-' + ($(popup).outerHeight(true) + 15) + 'px');
	$(popup).css('left', '-' + (($(popup).outerWidth(true) / 2) - ($(this).outerWidth(true) / 2)) + 'px');
	$('.scheme polyline[data-id=' + $(this).data('id') + ']').attr('class', 'active');
	$(popup).show();
});

// Клик по polyline - также открывается подсказка
$('.scheme polyline').click(function(){
	$('.scheme-popup').hide();
	$('.scheme-item[data-id=' + $(this).data('id') + ']').trigger('click');
});

// Клик вне polyline все закрывает
$("body").click(function(e) {
	if ($(e.target).closest(".scheme polyline, .scheme-item").length == 0) {
		$(".scheme-popup").hide();
		$('.scheme polyline').attr('class', '');
	}
});