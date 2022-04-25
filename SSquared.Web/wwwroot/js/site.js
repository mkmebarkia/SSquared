// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function closeModal() {

    $('#employeeModal').modal('hide');
    alert('New employee was successfully added!', 'success')
}

function alert(message, type) {

    var EmployeeAddedAlert = document.getElementById('EmployeeAddedAlert')
    var wrapper = document.createElement('div')
    wrapper.innerHTML = '<div class="alert alert-' + type + ' alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>'

    EmployeeAddedAlert.append(wrapper)
}