﻿// Write your JavaScript code.

function formOnFail(error) {

    if (error.status == 500)
        toastr.error(error.responseJSON);
}
