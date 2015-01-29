/* Your JS codes here */
$(document).ready(function () {

    $(document).on("click", "#contactUs", function () {
        $.ajax({
            url: "ContactUs",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#aboutUs", function () {
        $.ajax({
            url: "AboutUs",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#news", function () {
        $.ajax({
            url: "News",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#blog", function () {
        $.ajax({
            url: "Blogging",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#ourServices", function () {
        $.ajax({
            url: "ourServices",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#myFavourite", function () {
        $.ajax({
            url: "MyFavourite",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
    $(document).on("click", "#home", function () {
        $.ajax({
            url: "AboutUs",
            type: "Get",
            success: function (data) {
                $('#MainContentFromServer').html(data);
            },
            complete: function () {
            },
            error: function (data) {
            }
        });
    });
});
