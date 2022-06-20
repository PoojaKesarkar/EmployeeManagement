$(document).ready(function () {
    $('#empList').DataTable({
        "pagingType": "simple",
        "scrollY": "450px",
        "scrollCollapse": true,
        columns: [
            null,
            { orderable: false, /*searchable: false*/ },
            { orderable: false, /*searchable: false*/ },
            { orderable: false, /*searchable: false*/ },
            null,
            { orderable: false, /*searchable: false*/ }
        ]
    });
});

$(function () {
    $("form[name='formValidate']").validate({
        rules: {
            name: {
                required: true,
                maxlength: 150
            },
            location: {
                required: true,
                maxlength: 150
            },
            email: {
                required: true,
                maxlength: 50,
                email: true
            },
            mobile: {
                required: true,
                number: true,
                minlength: 10,
                maxlength: 10
            },
            DeptID: {
                required: true
            }
        },
        messages: {
            name: {
                required: "Please enter Name.",
                maxlength: "Name can only be 150 characters long."
            },
            location: {
                required: "Please enter Location.",
                maxlength: "Location can only be 150 characters long."
            },
            mobile: {
                required: "Please enter Mobile No.",
                number: "Please enter a valid Mobile No.",
                minlength: "Mobile No. must be 10 characters long.",
                maxlength: "Mobile No. must be 10 characters long."
            },
            email: {
                required: "Please enter Email ID.",
                email: "Please enter a valid Email ID.",
                maxlength: "Email ID can only be 50 characters long."
            },
            DeptID: {
                required: "Please select a Department."
            }
        },
        submitHandler: function (form) {
            form.submit();
        },
        highlight: function (element) {
            $(element).parent().addClass('error');
        },
        unhighlight: function (element) {
            $(element).parent().removeClass('error');
        },
    });
});


