var fanlist = [];

var getFanFromCache = function(index) {
    return fanlist[index];
}

var addNewRowToFanList = function (fan) {
    var html = "<option>" + fan.ProductCode + " (" + fan.Description + ")</option>";
    $("#FanList").append(html);
}

var getAllFanParts = function () {

    getAllFanPartsFromBackend().then(function (data) {

        $("#FanList").empty();
        fanlist = [];

        $.each(data, function (i, fan) {

            addNewRowToFanList(fan);
            fanlist.push(fan);
        });
    });
}

var addFan = function () {

    var fan = {
        description: $("#FanDescription").val(),
        type: $("#FanType").val()
    }
    sendFanPartToBackend(fan).then(function () {
        getAllFanParts(); // Refresh list
    }); // Save to backend

}