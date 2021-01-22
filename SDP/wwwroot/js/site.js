// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $("#myCategory").keyup(function () {
        var input, filter, ul, li, a, i, txtValue;
        var array = [];
        var myArr = [];
        input = $("#myCategory");
        filter = input.val().toUpperCase()
        li = $(".col-md-4");
      //  console.log(input);
        console.log(filter);
        //console.log(li);
        a = $(".category");
        for (i = 0; i < li.length; i++) {

            txtValue = a[i].innerText;
            array.push(txtValue);
            console.log(txtValue);
          if (txtValue.toUpperCase().indexOf(filter) > -1) {
              li[i].style.display = "";
              //li[i].classlist.remove("mystyle");
          } else {
                li[i].style.display = "none";
                
                //li[i].classlist.add("mystyle");
          }
        }
        //console.log(array);
        //myArr.filter(array => array.includes(filter));
        //console.log(myArr);
    });
});

$(document).ready(function () {
    $("#myProduct").keyup(function () {
        
        var input, filter, ul, li, a, i, txtValue,txtValue1, input1, filter1;
        input1 = $("#myCategory");
        input = $("#myProduct");
        filter = input.val().toUpperCase();
        filter1 = input1.val().toUpperCase();

        li = $("col-md-4");
        //console.log(input);
        console.log(filter);
        //console.log(li);
        productName = $(".productName");
        category = $(".category");

        for (i = 0; i < li.length; i++) {

            txtValue = productName[i].innerText;
            txtValue1 = category[i].innerText;
            if ((txtValue.toUpperCase().indexOf(filter) > -1) && (txtValue1.toUpperCase().indexOf(filter1)> -1) ) {
                li[i].style.display = "";
            } else {
                li[i].style.display = "none";
            }
        }
    });
});