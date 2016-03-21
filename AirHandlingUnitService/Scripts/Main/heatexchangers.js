var heatexchangerlist = [];

var getHeatExchangerFromCache = function(index) {
    return heatexchangerlist[index];
}

var addNewRow = function (he) {
    var html = "<option>" + he.ProductCode + " (" + he.Description + ")</option>";
    $("#HeatExchangerList").append(html);
}

var getAllHeatExchangerParts = function () {

    getAllHeatExchangerPartsFromBackend().then(function (data) {

        $("#HeatExchangerList").empty();
        heatexchangerlist = [];

        $.each(data, function (i, he) {

            addNewRow(he);
            heatexchangerlist.push(he);
        });
    });
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