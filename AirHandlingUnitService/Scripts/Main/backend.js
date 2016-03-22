var getAllAirHandlingUnitsFromBackend = function() {
    var promise = $.Deferred();
    $.get("api/AirHandlingUnit/GetAll", function (data) {
        promise.resolve(data.AirHandlingUnits);
    });
    return promise;
};

var getAllHeatExchangerPartsFromBackend = function () {

    var promise = $.Deferred();
    $.get("api/HeatExchanger/GetAll", function (data) {
        promise.resolve(data.CustomHeatExchangers);
    });
    return promise;
}

var getAllFanPartsFromBackend = function () {

    var promise = $.Deferred();
    $.get("api/Fan/GetAll", function (data) {
        promise.resolve(data.Parts);
    });
    return promise;
}

var sendNewAirHanlingUnitToBackend = function (unit) {

    var promise = $.Deferred();
    var data = {
        Description: unit.description,
        Parts: unit.parts
    }
    var url = "api/AirHandlingUnit/Get";

    $.ajax({
        url: url,
        type: "get", //send it through get method
        data: $.param(data),
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
        Description: he.description,
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

var sendFanPartToBackend = function (fan) {

    var promise = $.Deferred();
    var data = {
        Description: fan.description,
        FanType: fan.type
    }
    var url = "api/Fan/Get";

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