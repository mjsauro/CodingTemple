function link_mouseover() {
    var bold = document.getElementsByTagName('b');

    for (var i = 0; i < bold.length; i++) {
        bold[i].style.backgroundColor = "red";
    }
}
