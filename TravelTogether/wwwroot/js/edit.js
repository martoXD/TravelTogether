
// RemoveImg from user profile
var removeImg = function (imageId, userId) {

    var image_Id = imageId;
    var user_Id = userId;

    var params = { image_Id: image_Id, user_Id: user_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Images/Remove',
        data: serializedData,
        success: function () {
            window.location.reload();
            //$("#loaderDiv").hide();
            //$("#post_Modal").modal("hide");
        }
    });
}