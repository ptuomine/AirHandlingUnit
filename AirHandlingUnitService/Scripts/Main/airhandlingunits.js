var addNewRowToAirHandlingUnitList = function (unit) {
    var html = "<option>" + unit.Description + "</option>";
    $("#AirHandlingUnitList").append(html);
}

var addAirHandlingUnit = function () {

    var parts = [];
    var heindex = $("#HeatExchangerList option:selected").index();
    var he = getHeatExchangerFromCache(heindex);
    parts.push(he);

    var unit = {
        description: $("#AirHandlingUnitDescription").val(),
        parts: parts
    }
    sendNewAirHanlingUnitToBackend(unit).then(function() {
        getAllAirHandlingUnits();
    });
}

var getAllAirHandlingUnits = function () {

    getAllAirHandlingUnitsFromBackend().then(function (data) {

        $("#AirHandlingUnitList").empty();
        var airhandlingunitlist = [];

        $.each(data, function (i, unit) {

            addNewRowToAirHandlingUnitList(unit);
            airhandlingunitlist.push(unit);
        });
    });
}
