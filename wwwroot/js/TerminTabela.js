var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/Termin/GetAll",
            "dataSrc": "",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "id", "width": "5%" },
            { "data": "ime", "width": "5%" },
            { "data": "prezime", "width": "5%" },
            { "data": "email", "width": "5%" },
            { "data": "datum", "width": "10%","render": DataTable.render.datetime() },
            { "data": "status", "width": "5%" },
            { "data": "brojTelefona", "width": "5%" },
            {
                "data": "id",
                "render": function (data) {
                    return `
                            <div style="display:inline-block">
                                <button class="btn btn-warning" onclick="izmeni(${data})"data-toggle="modal" data-target="#EditModal">Edit</button>
                                <button class="btn btn-danger" onclick="postaviId(${data})" data-toggle="modal" data-target="#DeleteModal">Delete</button>
                            </div>
                                   `;
                }, "width": "5%"
            }
        ]
    });
}
