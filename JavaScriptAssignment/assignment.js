//Display the largest int


var a = function DisplayTheLargerInt(int1, int2) {
    if (int1 > int2) {
        return int1;
    } else {
        return int2;
    }
}


//Sort 3 numbers

var b = function SortThree(num1, num2, num3) {
    if (num1 > num2 && num1 > num3) {
        if (num2 > num3) {
            alert(num1 + " " + num2 + " " + num3);
        } else {
            alert
            alert(num1 + " " + num3 + " " + num2);
        }
    } else if (num2 > num3 && num2 > num1) {
        if (num1 > num3) {
            alert(num2 + " " + num1 + " " + num3);
        } else {
            alert(num2 + " " + num3 + " " + num1);
        }
    } else if (num3 > num1 && num3 > num2) {
        if (num1 > num2) {
            alert(num3 + " " + num1 + " " + num2);
        } else {
            alert(num3 + " " + num2 + " " + num1);
        }
    }
}

//Find largest of 5 numbers
var c = function LargestFive(num1, num2, num3, num4, num5) {
    if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5) {
        alert(num1 + " is the greatest number");
    } else if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5) {
        alert(num2 + " is the greatest number");
    } else if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5) {
        alert(num3 + " is the greatest number");
    } else if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5) {
        alert(num4 + " is the greatest number");
    } else {
        alert(num5 + " is the greatest number");
    }
}

//Is the number odd or even?
var d = function OddEven() {
    for (var i = 0; i < 16; i++) {
        if (i == 0) {
            console.log(i + " is neither odd or even");
        } else if (i % 2 == 0) {
            console.log(i + " is even");
        } else {
            console.log(i + " is odd");
        }
    }
}

//FizzBuzz
var e = function FizzBuzz() {
    for (var i = 1; i <= 100; i++) {
        if (i % 3 == 0 && i % 5 == 0) {
            console.log("FizzBuzz");
        } else if (i % 3 == 0) {
            console.log("Fizz");
        } else if (i % 5 == 0) {
            console.log("Buzz");
        } else {
            console.log(i);
        }
    }
}

//Count all numberes between 1 and 1000 that are divisble by three
var count = 0;
var f = function DivisibleByThree() {
    for (var i = 1; i <= 1000; i++) {
        if (i % 3 === 0) {
            count = count + 1;
        }
    }
    console.log(count);
}

//Pyramid
var result = "";
var g = function Pyramid(size) {
    var m = 2;

    for (var d = 1; d <= size; d++) {
        result += " ";
    }

    result += 1;
    console.log(result);
    result = "";
    console.log("\n");

    for (var i = 1; i <= size; i++) {

        for (var y = size - 1; y >= i; y--) {
            result += " ";
        }

        for (var z = 1; z <= i; z++) {
            result += z;
        }
        result += m;
        m++;

        for (var b = i; b >= 1; b--) {
            result += b;
        }
        console.log(result);
        console.log("\n");
        result = "";
    }
}

//Diamond
var space = "";
var result = "";
var h = function Diamond(size) {

    //1st half
    var m = 2;

    for (var d = 1; d <= size; d++) {
        result += " ";
    }

    result += 1;
    console.log(result);
    result = "";

    for (var i = 1; i <= size; i++) {
        result = "";
        for (var y = size - 1; y >= i; y--) {
            result += " ";
        }

        for (var z = 1; z <= i; z++) {
            result += z;
        }
        result += m;
        m++;

        for (var b = i; b >= 1; b--) {
            result += b;
        }
        console.log(result);
        result = "";
    }

    //second half
    m -= 2;
    for (i = size - 1; i >= 1; i--) {

        for (y = size - 1; y >= i; y--) {
            result += " ";
        }

        for (z = 1; z <= i; z++) {
            result += z;
        }
        result += m;
        m--;

        for (b = i; b >= 1; b--) {
            result += b;
        }
        console.log(result);
        result = "";
    }
    for (d = 1; d <= size; d++) {
        result += " ";
    }
    result += m;
    console.log(result);
}



