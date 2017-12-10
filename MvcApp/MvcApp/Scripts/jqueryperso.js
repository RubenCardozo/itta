
        $(document).ready(function () {
            var divs = $("div");
            divs
                .html(
                function (index, text) {
                    return ('-'+index+text).toUpperCase();
                })
                .click(function () {
                    console.log(this.innerHTML);//$(this).text()
                });
            console.log(divs.text());
            $("#div1").addClass("red");
            $("div.red").append(" en rouge");
            $("div").addClass("redtext");//3eme div de la page
            $("div > p").css("border", "2px solid black");//les p enfant directs des div
            $("div:eq(2) > div:first-child").css("border", "2px solid blue");
            //le 1er div enf. direct du 3eme div du doc
            $("div:eq(2) > div:odd").css("border", "2px solid pink");
            $("div:eq(2) > div:odd").click(
                function () {
                    $(this).fadeToggle(1000,"swing", function () {
                        $(this).fadeToggle(1000, function () {
                           // $(this).click();//boucle infinie
                        });
                    });
                }
            );
            $("div:eq(2)").append("<div>nouvelle 1</div>");
            $("<div>").text("nouvelle 2").css("border", "2px solid pink").appendTo($("div:eq(2)"));
            $("<div>").text("nouvelle 3").css("border", "4px solid violet").insertAfter($("div:eq(2)"));
            $("div:eq(2)").wrap($("<div>").css("border", "4px solid darkgreen"));


        });