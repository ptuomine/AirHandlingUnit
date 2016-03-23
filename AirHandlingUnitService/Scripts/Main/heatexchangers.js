var heatexchangerlist = [];

var getHeatExchangerFromCache = function(index) {
    return heatexchangerlist[index];
}

var heatexchangertypes = ["Shell", "Tube"];

var addNewRowToHeatExchangerList = function (he) {
    var optiontext = he.ProductCode + " (desc:" + he.Description + "; type:" + heatexchangertypes[he.HeatExchangerType] + "; power:" + he.Power;
    var html = "<option title='" + optiontext + "'>" + optiontext + ")</option>";
    $("#HeatExchangerList").append(html);
}

var getAllHeatExchangerParts = function () {

    getAllPartsOfTypeFromBackend("HeatExchanger").then(function (data) {

        $("#HeatExchangerList").empty();
        heatexchangerlist = [];

        $.each(data, function (i, he) {

            addNewRowToHeatExchangerList(he);
            heatexchangerlist.push(he);
        });
    });
}

var addHeatExchangerPart = function () {

    // This data must be in the same format as the HeatExchangerController uses 
    var data = {
        Description: $("#HeatExchangerDescription").val(),
        Power: $("#HeatExchangerPower").val(),
        HeatExchangerType: $("#selectHeatExchangerType").val()
    }

    sendPartToBackend(data, "HeatExchanger").then(function () {
        getAllHeatExchangerParts(); // Refresh list
    }); // Save to backend

}