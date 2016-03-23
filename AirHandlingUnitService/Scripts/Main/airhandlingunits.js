var addNewRowToAirHandlingUnitList = function (unit) {

    var optiontext = unit.Description + " ( parts:";
    var parts = unit.Partcollection.Parts;
    if (parts) {
        $.each(parts, function (i, part) {
            optiontext = optiontext + part.ProductCode + " ";
        })
    }
    optiontext = optiontext + ")";
    var html = "<option>" + optiontext + "</option>";
    $("#AirHandlingUnitList").append(html);
}

function getSelectIndexes(options) {
    var indexes = [];
    options.each(function (i, o) {
        if (this.selected) {
            indexes.push(i);
        }
    });
    return indexes;
}

var addAirHandlingUnit = function () {

    var parts = [];
    var heselect = $("#HeatExchangerList option");
    var heselected = getSelectIndexes(heselect)
    $.each(heselected, function (i, heindex) {
        var he = getHeatExchangerFromCache(heindex);
        parts.push(he);
    })

    var fanselect = $("#FanList option");
    var fanselected = getSelectIndexes(fanselect)
    $.each(fanselected, function (i, fanindex) {
        var fan = getFanFromCache(fanindex);
        parts.push(fan);
    })

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
