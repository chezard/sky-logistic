// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.


// Write your JavaScript code.
$(document).on('click', '.delete', function () {
    var result = confirm('Are you sure to delete?');
    if (!result) {
        return false;
    }
})

$(document).ready(function () {
    $('.index').DataTable({

        "scrollCollapse": true,

    });
});
$(document).ready(function () {
    $('.invoice').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copyHtml5',
            'pdfHtml5'
        ],

    });
});

$(document).ready(function () {
    $('#myTable').DataTable({

        "scrollCollapse": true,

    });
});
$(document).ready(function () {
    $('#myTable2').DataTable({
        dom: 'Bfrtip',
        buttons: [
            'copy',
            'excel',
            'csv',
            /*'pdf',*/
        ],
        "scrollCollapse": true,

    });
});


window.onload = function () {
    document.getElementById("download")
        .addEventListener("click", () => {
            const invoice = this.document.getElementById("invoice");
            console.log(invoice);
            console.log(window);
            var opt = {
                margin: 0,
                filename: 'Invoice.pdf',
                image: { type: 'jpeg', quality: 0.98 },
                html2canvas: { scale: 2 },
                jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
            };
            html2pdf().from(invoice).set(opt).save();
        })
}


function removeExp(e) {
    $("#aznExp").toggle();
    $("#azn-customerExp").toggle();
    $(e).toggleClass("btn-danger")
}
function removeEuroExp(e) {
    $("#euroExp").toggle();
    $("#euro-customerExp").toggle();
    $(e).toggleClass("btn-danger")
}
function removeDollarExp(e) {
    $("#dollarExp").toggle();
    $("#dollar-customerExp").toggle();
    $(e).toggleClass("btn-danger")
}
function removeRubExp(e) {
    $("#rubExp").toggle();
    $("#rub-customerExp").toggle();
    $(e).toggleClass("btn-danger")
}


function removeCus(e) {
    $("#aznCus").toggle();
    $("#azn-customerCus").toggle();
    $(e).toggleClass("btn-danger")
}
function removeEuroCus(e) {
    $("#euroCus").toggle();
    $("#euro-customerCus").toggle();
    $(e).toggleClass("btn-danger")
}
function removeDollarCus(e) {
    $("#dollarCus").toggle();
    $("#dollar-customerCus").toggle();
    $(e).toggleClass("btn-danger")
}
function removeRubCus(e) {
    $("#rubCus").toggle();
    $("#rub-customerCus").toggle();
    $(e).toggleClass("btn-danger")
}
//$(document).ready(function () {
//    $(document).on('click', '#addAssistant', function () {
//        $.ajax({
//            url: '/TransportDocument/GetAssistants',
//            type: 'GET',
//            success: function (res) {
//                if (res.status == 200) {
//                    let guid = res.guid;
//                    let assistant = ` <div data-id="${guid}" class="form-group assistant form-group-float w-lg-50">
//                        <label>Assistant</label>
//                        <select class="custom-select " name="AssistantId" id="assistans">

//                        </select>
//                    </div>`;

//                    let a = $(assistant);

//                    $("#document_form").append(assistant);

//                    for (let d of res.data) {
//                        let option = `<option value="${d.id}" > ${d.name}</option>`;
//                        $(`.assistant[data-id='${guid}'] select`).append(option);
//                    }

//                }

//            }
//        });
//    });

//});







//function add_more_field() {
//    html = `<div class="form-group form-group-float w-lg-50">
//        <label>Assistant</label >
//            <select class="custom-select" name="AssistantId" id="assistans">
//                @foreach (Personal assistant in ViewBag.Personals)
//                {
//                    <option value="@assistant.Id">@assistant.Name</option>
//                }
//            </select>
//                    </div >`
//    var form = document.getElementById('document_form')
//    form.innerHTML += html
//}








