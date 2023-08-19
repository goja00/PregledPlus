var element;
function postaviId(id) {
    $('#deleteId').val(id);
}

function izmeni(prodid) {
    $.ajax({
        type: "GET",
        url: "/Termin/GetOne/",
        data: { id: prodid },
        success: function (item) {
            element = item;
            $('#EditModal').modal('show');
        }
    })

}

$(document).ready(function () {
    $('#EditModal').on('show.bs.modal', function (e) {
        $('#prodid').val(element.id);
        $('#ime').val(element.ime);
        $('#prezime').val(element.prezime);
        $('#email').val(element.email);
        $('#datum').val(element.datum);
        $('#brojTelefona').val(element.brojTelefona);
        $('#status').val(element.status);
    })
})

$('.btnCancel').click(function () {
    window.location.href = "/CMS/Index";
})