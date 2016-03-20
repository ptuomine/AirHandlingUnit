var addAirHandlingUnit = function () {

    var parts = $("#HeatExchangerList").val();

    var unit = {
        description: $("#AirHandlingDescription").val(),
        parts: parts,
    }
    sendNewAirHanlingUnitToBackend(unit);
    addUnitToList(unit);
}
