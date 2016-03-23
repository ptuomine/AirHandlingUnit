var filterlist = [];

var getFanFromCache = function(index) {
    return filterlist[index];
}

var addNewRowToFilterList = function (filter) {
    var html = "<option>" + filter.ProductCode + " (" + filter.Description + ")</option>";
    $("#FilterList").append(html);
}

var getAllFilterParts = function () {

    getAllPartsOfTypeFromBackend("Filter").then(function (data) {

        $("#FilterList").empty();
        filterlist = [];

        $.each(data, function (i, filter) {

            addNewRowToFilterList(filter);
            filterlist.push(filter);
        });
    });
}

var addFilter = function () {

    // This data must be in the same format as the FilterController uses 
    var data = {
        Description: $("#FilterDescription").val(),
        FanType: $("#FilterLength").val()
    }

    sendPartToBackend(data, "Filter").then(function () {
        getAllFilterParts(); // Refresh list
    }); // Save to backend

}