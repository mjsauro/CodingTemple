//factorial
function Factorial(number) {

    if (number == 0) {
        return 1;
    } else {
        return number * Factorial(number - 1);
    }
}

//range
var rangeArray = [];

function Range(num1, num2) {

    if (num1 < num2) {
        if (num1 == num2 - 1) {
            return rangeArray;
        } else {
            rangeArray.push(num1 + 1);
            return Range(num1 + 1, num2);
        }
    }

    if (num1 > num2) {
        if (num2 == num1 - 1) {
            return rangeArray;
        } else {
            rangeArray.push(num2 + 1);
            return Range(num1, num2 + 1);
        }
    }
}

var result = 0;
var count = 1;
//find the exponent
function Power(base, exp) {

    if (count == exp) {
        base = 1;
        count = 1;
        return result;
    } else {
        result = base * base;
        var newBase = result;
        //base = base * base;
        count += 1;
        return (Power(newBase, exp));
    }
}


function MergeSort(array) {
    if (array.length < 2) {
        return array;
    }
    var middle = Math.floor(array.length / 2);
    var farLeft = MergeSort(array.slice(0, middle));
    var farRight = MergeSort(array.slice(middle));

    return Merge(farLeft, farRight);
}

function Merge(node1, node2) {
    var result = [];
    while (node1.length > 0 && node2.length > 0) {
        if (node1[0] < node2[0]) {
            result.push(node1[0]);
            node1.shift();
        } else {
            result.push(node2[0]);
            node2.shift();
        }
    }
    return result.concat(node1.length ? node1 : node2);
}
