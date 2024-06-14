// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    showQuantityCart();
});

$(".addtocart").click(function (evt) {
    evt.preventDefault();
    let id = $(this).attr("data-productId");

    $.ajax({
        url: "/customer/cart/addtocartapi",
        data: { "productId": id },
        success: function (data) {
            //Thông báo kết quả
            Swal.fire({
                title: "Product added to Cart",
                text: "You clicked the button!",
                icon: "success"
            });
            //hiển thị số lượng sản phẩm vào cart trong layout_demo
            showQuantityCart();
        }
    });

})

let showQuantityCart = () => {
    $.ajax({
        url: "/customer/cart/getquantityofcart",
        success: function (data) {
            //hiển thị số lượng sản phẩm vào cart trong layout_demo
            $(".showcart").text(data.qty);
        }
    });
}