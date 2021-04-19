$(document).ready(function () {
    console.log("Document ready from included JS Script | movei.js");
});

$("#addNewActor").click(function () {
    var data = {

    };

    $.ajax({
        type: "POST",
        url: "/Actor/CreateActorAJAX",
        data: data,
        dataType: "json",
        success: function (data) {
            if (data.data == '') {
                $(#actorModal).modal('toggle');
                setTimeout(() => {
                    alert("Error: Actor has NOT been added! Please enter data in All fields !");
                }, 500);
            } else {
                $("#ActorId").append("<option value =" + data.data.id + ">" + data.data.name + "</option>");
                $("#ActorId").val(data.data.id);
                var newOptionSelected = $("#ActorId option:selected").text();
                $("#ActoreName").val(newOptionSelected);
                $('#actorModal').modal('toggle');
            }
        },
        error: function () { alert("Error adding new Actor!"); }
    });
});
