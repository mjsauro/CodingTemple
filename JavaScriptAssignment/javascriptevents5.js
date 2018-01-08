        function getAttributes() {
            var attributes = document.getElementById("w3r").attributes;
            for (var i = 0; i < attributes.length; i++) {

                console.log(attributes[i].name + ": " + attributes[i].value);
            }
        }
