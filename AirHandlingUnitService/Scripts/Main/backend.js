var getAllAirHandlingUnitsFromBackend = function() {
    var promise = $.Deferred();
    $.get("api/AirHandlingUnit/GetAll", function (data) {
        promise.resolve(data.AirHandlingUnits);
    });
    return promise;
};

var getAllPartsOfTypeFromBackend = function (parttype)
{
    var url = "api/"+parttype+"/GetAll";
    var promise = $.Deferred();
    $.get(url, function (data) {
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

var sendPartToBackend = function (data, parttype) {

    var promise = $.Deferred();
    var url = "api/"+parttype+"/Get";

    $.ajax({
        url: url,
        type: "get", //send it through get method
        data: data,
        success: function (response) {
            promise.resolve(response);
        },
        error: function (xhr) {
            alert("save failed!" + xhr);
            promise.reject(xhr);
        }
    });
    return promise;
}