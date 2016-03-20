$(document).ready(function () {

    getAllHeatExchangerParts();
});

var addNewRow = function (he) {
    var html = "<option>" + he.ProductCode + " (" + he.Description + ")</option>";
    $("#HeatExchangerList").append(html);
}

var getAllHeatExchangerParts = function () {

    getAllHeatExchangerPartsFromBackend().then(function (data) {

        $("#HeatExchangerList").empty();

        $.each(data, function (i, he) {

            addNewRow(he);
        });
    });
}

var addAirHandlingUnit = function () {

}

var addFan = function () {

}

var addFilter = function () {

}


var addHeatExchangerPart = function () {

    var he = {
        description: $("#HeatExchangerDescription").val(),
        power: $("#HeatExchangerPower").val(),
        type: $("#selectHeatExchangerType").val()
    }
    sendHeatExchangerPartToBackend(he).then(function () {
        getAllHeatExchangerParts(); // Refresh list
    }); // Save to backend
    
}