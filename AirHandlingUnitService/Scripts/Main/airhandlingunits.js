var addNewRow = function (unit) {
    var html = "<option>" + unit.Description + "</option>";
    $("#AirHandlingUnitList").append(html);
}

var addAirHandlingUnit = function () {

    var parts = [];
    var heindex = $("#HeatExchangerList option:selected").index();
    var he = getHeatExchangerFromCache(heindex);
    parts.push(he);

    var unit = {
        description: $("#AirHandlingDescription").val(),
        parts: parts,
    }
    sendNewAirHanlingUnitToBackend(unit);
    addNewRow(unit);
}
