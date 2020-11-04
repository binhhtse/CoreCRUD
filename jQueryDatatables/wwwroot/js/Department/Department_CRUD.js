
var AddEditDepartmentInfo = function (id) {
    var url = "/Department/AddEditDepartment?id=" + id;
    if (id > 0)
        $('#title').html("Edit Department Info");

    $("#DepartmentFormModelDiv").load(url, function () {
        $("#DepartmentFormModel").modal("show");

    });
};

$('body').on('click', "#btnSubmit", function () {
    var myformdata = $("#DepartmentInfoForm").serialize();

    if ($.trim($('#DepartmentName').val()) === '') {
        Swal.fire({
            title: "Alert", text: "Department Name can not be left blank.",
            icon: "info", closeOnConfirm: false,
            onAfterClose: () => {
                setTimeout(() => $("#DepartmentName").focus(), 110);
            }
        });
        return;
    }
    

    $.ajax({
        type: "POST",
        url: "/Department/AddEditDepartment",
        data: myformdata,
        success: function (result) {
            $("#DepartmentFormModel").modal("hide");

            Swal.fire({
                title: "Alert!",
                text: result,
                type: "Success"
            }).then(function () {
                $('#tblDepartment').DataTable().ajax.reload();
            });
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
});

var DeleteDepartmentInfo = function (id) {
    Swal.fire({
        title: 'Do you want to delete this item?',
        type: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes'
    }).then((result) => {
        if (result.value) {
            $.ajax({
                type: "POST",
                url: "/Department/Delete/" + id,
                success: function () {
                    Swal.fire({
                        title: 'Deleted!', text: 'Item has been deleted.',
                        icon: "success", closeOnConfirm: false,
                        onAfterClose: () => {
                            $('#tblDepartment').DataTable().ajax.reload();
                        }
                    });
                }
            });
        }
    });
};



