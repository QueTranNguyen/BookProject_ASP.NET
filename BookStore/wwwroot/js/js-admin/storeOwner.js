﻿$(document).ready(function () {
    $('.btn-warning').on('click', function () {
        var userId = $(this).data('userid'); // Lấy giá trị data-userid từ nút
        $('#userId').val(userId); // Đặt giá trị userId vào trường input ẩn
    });

    $('#passwordChangeForm').submit(function (e) {
        e.preventDefault();

        var userId = $('#userId').val();
        var newPassword = $('#newPassword').val();
        var confirmPassword = $('#confirmPassword').val();
        if (newPassword !== confirmPassword) {
            alert('Passwords do not match. Please try again.');
            return;
        }

        var data = {
            newPassword: newPassword
        };
        console.log(data)
        $.ajax({
            url: apiUrl + '/api/Users/' + userId,
            type: 'PUT',
            contentType: 'application/json',
            data: JSON.stringify(newPassword), // Chuyển mật khẩu mới thành một chuỗi JSON
            success: function (response) {
                Swal.fire({
                    icon: 'success',
                    title: 'Your work has been saved',
                    showConfirmButton: false,
                    timer: 1500
                })
                var closeButton = document.querySelector('.modal-footer button[data-dismiss="modal"]');
                closeButton.click();

                $('#userId').val('');
                $('#newPassword').val('');
                $('#confirmPassword').val('');
            },
            error: function (xhr, status, error) {
                alert('Error: ' + error);
            }
        });
    });

    $('#searchInput').on('input', function () {
        var searchText = $(this).val().toLowerCase();
        var found = false;

        // Loop through each row in the authors table
        $('#storeOwnerAccountTable tbody tr').each(function () {
            var rowText = $(this).text().toLowerCase();

            // Compare text of each row with the search text
            if (rowText.includes(searchText)) {
                $(this).show();
                found = true;
            } else {
                $(this).hide();
            }
        });
        // Display message when no results are found
        if (!found) {
            $('#noResultsMessage').show();
        } else {
            $('#noResultsMessage').hide();
        }
    });
});

function deleteStoreOwnerAccount(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: 'You won\'t be able to revert this!',
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: 'Yes, delete it!',
        cancelButtonText: 'No, cancel'
    }).then((result) => {
        if (result.isConfirmed) {
            // If the user agrees to delete, perform an AJAX request to send the delete request
            $.ajax({
                type: 'DELETE',
                url: apiUrl + '/api/Users/' + id,
                success: function () {
                    // If deletion is successful, update the user interface by removing the row from the table
                    $('#row_' + id).remove();
                    Swal.fire('Deleted!', 'Your record has been deleted.', 'success');
                },
                error: function (xhr, status, error) {
                    console.log(xhr);
                    Swal.fire('Error!', 'An error occurred while deleting the record.', 'error');
                }
            });
        }
    });
}