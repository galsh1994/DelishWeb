$(function () {

    $("#SearchDish").autocomplete({
        source:"/Dishes/Search",
        minLength: 0,
        select: function (event, ui) {
            location.href = '/Dishes/Details/'+ui.item.id;
        }
    });
});

    