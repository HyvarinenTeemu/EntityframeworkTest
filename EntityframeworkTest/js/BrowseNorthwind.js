$(function () {
    $.getJSON("/customer/getcustomers", null, function (json) {
        var jsondata = JSON.parse(json);

        html = "";

        for (var i = 0; i < jsondata.length; i++) {
            html += "<tr>" +
                        "<td>" + jsondata[i].CustomerID + "</td>" +
                        "<td>" + jsondata[i].CompanyName + "</td>" +
                        "<td>" + jsondata[i].ContactName + "</td>" +
                        "<td>" + jsondata[i].ContactTitle + "</td>" +
                        "<td>" + jsondata[i].Address + "</td>" +
                        "<td>" + jsondata[i].City + "</td>" +
                        "<td>" + jsondata[i].Region + "</td>" +
                        "<td>" + jsondata[i].PostalCode + "</td>" +
                        "<td>" + jsondata[i].Country + "</td>" +
                        "<td>" + jsondata[i].Phone + "</td>" +
                        "<td>" + jsondata[i].Fax + "</td>" +
                    "</tr>";
        }

        $("#customertable tbody").html(html);
    });
});