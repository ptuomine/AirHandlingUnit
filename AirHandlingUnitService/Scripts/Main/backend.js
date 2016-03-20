var getAllHeatExchangerPartsFromBackend = function () {

    var promise = $.Deferred();
    $.get("api/HeatExchanger/GetAll", function (data) {
        promise.resolve(data.CustomHeatExchangers);
    });
    return promise;
}

var sendNewAirHanlingUnitToBackend = function (unit) {

    var promise = $.Deferred();
    var data = {
        Description: encodeURIComponent(he.description),
        Parts: he.parts
    }
    var url = "api/AirHandlingUnit/Get";

    $.ajax({
        url: url,
        type: "get", //send it through get method
        data: data,
        success: function (response) {
            promise.resolve(response);
        },
        error: function (xhr) {
            alert("save failed!"+xhr)
            promise.reject(xhr);
        }
    });
    return promise;
}

var sendHeatExchangerPartToBackend = function (he) {

    var promise = $.Deferred();
    var data = {
        Description: encodeURIComponent(he.description),
        Power: he.power,
        HeatExchangerType: he.type
    }
    var url = "api/HeatExchanger/Get";

    $.ajax({
        url: url,
        type: "get", //send it through get method
        data: data,
        success: function (response) {
            promise.resolve(response);
        },
        error: function (xhr) {
            alert("save failed!" + xhr)
            promise.reject(xhr);
        }
    });
    return promise;
}