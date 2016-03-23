var fanlist = [];

var getFanFromCache = function(index) {
    return fanlist[index];
}

var fantypes = ["Box", "Floor"];

var addNewRowToFanList = function (fan) {

    var optiontext = fan.ProductCode + " (desc:" + fan.Description + "; type:" + fantypes[fan.FanType]
    var html = "<option title='"+optiontext+"'>" + optiontext + ")</option>";
    $("#FanList").append(html);
}

var getAllFanParts = function () {

    getAllPartsOfTypeFromBackend("Fan").then(function (data) {

        $("#FanList").empty();
        fanlist = [];

        $.each(data, function (i, fan) {

            addNewRowToFanList(fan);
            fanlist.push(fan);
        });
    });
}

var addFan = function () {

    // This data must be in the same format as the FanController uses 
    var data = {
        Description: $("#FanDescription").val(),
        FanType: $("#selectFanType").val()
    }

    sendPartToBackend(data, "Fan").then(function () {
        getAllFanParts(); // Refresh list
    }); // Save to backend

}