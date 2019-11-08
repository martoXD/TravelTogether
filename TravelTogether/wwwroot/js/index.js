
// PostLike
var like = function (postId, userId) {

    var post_Id = postId;
    var user_Id = userId;

    var params = { post_Id: post_Id, user_Id: user_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Posts/Like',
        data: serializedData,
        success: function (post) {
            var postData = jQuery.parseJSON(post);
            var postId = postData.PostId;
            var userId = postData.UserId;
            var likeId = postData.LikeId;
            console.log(postData);
            $('.likes_' + postId).text(postData.PostLikes + ' likes');
            var elements = document.getElementsByClassName("my_like_btn_" + postId);
            Array.from(elements).forEach(function (e) {
                e.children[0].setAttribute("id", "like_icon");
                e.setAttribute("class", "my_dislike_btn_" + postId);
                e.setAttribute("onclick", `dislike('${postId}', '${userId}', '${likeId}')`);
            });

            //window.location.reload();
            //$("#loaderDiv").hide();
            //$("#post_Modal").modal("hide");
        }
    });
}

// PostDislike
var dislike = function (postId, userId, likeId) {

    var post_Id = postId;
    var user_Id = userId;
    var like_Id = likeId;

    var params = { post_Id: post_Id, user_Id: user_Id, like_Id: like_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Posts/Dislike',
        data: serializedData,
        success: function (post) {
            var postData = jQuery.parseJSON(post);
            var postId = postData.PostId;
            var userId = postData.UserId;
            console.log(postData);
            $('.likes_' + postId).text(postData.PostLikes + ' likes');
            var elements = document.getElementsByClassName("my_dislike_btn_" + postId);
            Array.from(elements).forEach(function (e) {
                e.children[0].removeAttribute("id");
                e.setAttribute("class", "my_like_btn_" + postId);
                e.setAttribute("onclick", `like('${postId}', '${userId}')`);
            });

            //window.location.reload();
            //$("#loaderDiv").hide();
            //$("#post_Modal").modal("hide");
        }
    });
}

// Sending a comment thru the modal
var sendCommentModal = function (postId, userId) {
    //$("#loaderDiv").show();

    var currUser_Id = userId;
    var post_Id = postId;
    var comment_data;

    $('textarea.form-control').each(function () {
        if ($(this).val() != undefined && $(this).val() != "" && $(this).val() != null) {
            comment_data = $(this).val();
        }
    });

    var params = { comment_data: comment_data, post_Id: post_Id, user_Id: currUser_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Posts/AddComment',
        data: serializedData,
        success: function (post) {
            var postData = jQuery.parseJSON(post);
            console.log(postData.UserFirstName + ' ' + postData.UserLastName);
            console.log(postData.CommentContent);

            var postIdString = post_Id.toString();
            var selector = 'span#postID-' + postIdString;

            $(selector).each(function (index) {
                var previousCommentValue = postData.PostCommentsNum - 1 + ' ' + 'comments';
                var afterCommentValue = postData.PostCommentsNum + ' ' + 'comments';

                if ($(this).text().trim() == previousCommentValue) {
                    $(selector).text(afterCommentValue);
                    console.log(index + ": " + $(this).text());
                }
            });
            var imgSrc;
            if (postData.UserProfileImgSrc == null) {
                imgSrc = postData.DefaultImgSrc;
            }
            else {
                imgSrc = postData.UserProfileImgSrc;
            }
            var commentElement = [];
            commentElement.push(
                `<div class=\"ui comments\">
                <div class=\"comment\">
                <a href=\"/Account/MyProfile?id=${currUser_Id}\" class=\"avatar\">
                <img class="iP" src="${imgSrc}">
                </a>
                <div class=\"content\">
                <a href=\"/Account/MyProfile?id=${currUser_Id}\" class=\"author my_author\">
                ${postData.UserFirstName} ${postData.UserLastName}
                </a>
                <div class=\"metadata\">
                <div class=\"date\">comment</div>
                </div>
                <div class=\"text\">
                ${postData.CommentContent}
                </div>
                </div>
                </div>
                </div>`
            );
            console.log(commentElement);
            //$(commentElement).insertBefore("#post_comment_section").slideDown();
            //$.each(commentElement, function (index, value) {
            $('#post_comment_section_' + postData.PostId).before(commentElement);
            
            //window.location.reload();
            //$("#loaderDiv").hide();
        }
    });
};

// Sending a comment
var sendComment = function (postId, userId) {
    //$("#loaderDiv").show();

    var currUser_Id = userId;
    var post_Id = postId;
    var comment_data;

    $('input.postInput').each(function () {
        if ($(this).val() != undefined && $(this).val() != "" && $(this).val() != null) {
            comment_data = $(this).val();
        }
    });

    var params = { comment_data: comment_data, post_Id: post_Id, user_Id: currUser_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Posts/AddComment',
        data: serializedData,
        //contentType: 'application/json; charset=utf-8',
        //dataType: 'json',
        success: function (post) {
            var postData = jQuery.parseJSON(post);
            console.log(postData.UserFirstName + ' ' + postData.UserLastName);
            console.log(postData.CommentContent);

            var postIdString = post_Id.toString();
            var selector = 'span#postID-' + postIdString;

            $(selector).each(function (index) {
                var previousCommentValue = postData.PostCommentsNum - 1 + ' ' + 'comments';
                var afterCommentValue = postData.PostCommentsNum + ' ' + 'comments';

                if ($(this).text().trim() == previousCommentValue) {
                    $(selector).text(afterCommentValue);
                    console.log(index + ": " + $(this).text());
                }
            });
            $('input#commentData-' + post_Id).each(function () {
                if ($(this).val() != undefined && $(this).val() != "" && $(this).val() != null) {
                    $(this).val("");
                }
            });
            var imgSrc;
            if (postData.UserProfileImgSrc == null) {
                imgSrc = postData.DefaultImgSrc;
            }
            else {
                imgSrc = postData.UserProfileImgSrc;
            }
            var commentElement = [];
            commentElement.push(
                `<div class=\"ui comments\">
                <div class=\"comment\">
                <a href=\"/Account/MyProfile?id=${currUser_Id}\" class=\"avatar\">
                <img class="iP" src="${imgSrc}">
                </a>
                <div class=\"content\">
                <a href=\"/Account/MyProfile?id=${currUser_Id}\" class=\"author my_author\">
                ${postData.UserFirstName} ${postData.UserLastName}
                </a>
                <div class=\"metadata\">
                <div class=\"date\">comment</div>
                </div>
                <div class=\"text\">
                ${postData.CommentContent}
                </div>
                </div>
                </div>
                </div>`
            );
            console.log(commentElement);
            //$(commentElement).insertBefore("#post_comment_section").slideDown();
            //$.each(commentElement, function (index, value) {
            $('#post_comment_section_' + postData.PostId).before(commentElement);
            //window.location.reload();
            //$("#loaderDiv").hide();
        },
        error: function () {
            console.log("error!");
        }
    });
};

$(document).ready(function () {

    $("#imageBrowes").change(function () {

        var File = this.files;

        if (File && File[0]) {
            ReadImage(File[0]);
        }

    })

})

var ReadImage = function (file) {

    var reader = new FileReader;
    var image = new Image;

    reader.readAsDataURL(file);
    reader.onload = function (_file) {

        image.src = _file.target.result;
        image.onload = function () {

            var height = this.height;
            var width = this.width;
            var type = file.type;
            var size = ~~(file.size / 1024) + "KB";

            $("#targetImg").attr('src', _file.target.result);
            $("#description").text("Size:" + size + ", " + height + "X " + width + ", " + type + "");
            $("#imgPreview").show();

        }

    }

}

var ClearPreview = function () {
    $("#imageBrowes").val('');
    $("#description").text('');
    $("#imgPreview").hide();
}

// Sending a Message
var message = function (receiverId) {
    $('.popup').each(function () {
        if ($(this).attr('id') == receiverId) {
            $(".my_message_btn").addClass("hide");
            return $("#" + receiverId).addClass("show");
        }
    });

    //$(".my_message_btn").addClass("hide");
    //return $(".popup").addClass("show");
};

$(".my_X_btn").on("click", function () {
    $(".my_message_btn").removeClass("hide");
    return $(".popup").removeClass("show");
});

// View Profile
var viewProfile = function (memberId) {

    var member_Id = memberId;

    var params = { id: member_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'GET',
        url: '/Account/ViewProfile',
        data: serializedData,
        success: function (response) {
            if (response.result == 'Redirect') {
                window.location = response.url;
            }
        }
    });
};

// Remove Friend
var removeFriend = function (memberId, userId) {

    var member_Id = memberId;
    var user_Id = userId;

    var params = { memberId: member_Id, currentUserId: user_Id };
    var serializedData = jQuery.param(params);

    $.ajax({
        type: 'POST',
        url: '/Account/RemoveFriendFromIndex',
        data: serializedData,
        success: function (response) {
            if (response.result == 'Redirect') {
                window.location = response.url;
            }
        }
    });
};