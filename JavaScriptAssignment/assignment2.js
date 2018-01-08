//return current date:

function formatDate(date) {
    var month = date.getMonth();
    var day = date.getDate();
    var year = date.getFullYear();

    return (month + 1) + "//" + day + "//" + year;
}

//check for leap year
function LeapYear(year) {
    if (year % 4 == 0 && year % 100 != 0) {
        return true;
    } else if (year % 400 == 0) {
        return true;
    } else {
        return false;
    }
}

//cheack to see if array is contains consecutive numbers
var myArray = [4, 5, 6, 7, 8, 9, 10, 11, 12];
var myBadArray = [2, 1, 4, 3];
var result = false;

function Consecutive(array) {

    for (var i = 0; i < array.length - 1; i++)

        if (array[i] + 1 == array[i + 1]) {
            result = true;
        } else {
            return false;
        }
    return result;
}


//check to see if a number appears multiple times in an array
var myArray2 = [2, 3, 4, 5];
var myOtherArray2 = [2, 4, 5, 6, 4];
var count = 0;

function Multiple(array) {
    for (var i = 0; i < array.length - 1; i++) {
        for (var j = i; j < array.length - 1; j++) {
            if (array[i] == array[j + 1]) {
                count += 1;
            }
        }
    }
    if (count >= 1) {
        count = 0;
        return true;
    } else {
        count = 0;
        return false;
    }
}

//write a function return the first element.  passing a parameter n will return the n elements of the array
var myArray3 = [1, 2, 3, 4, 5, 8, 10, 9, 11];
var myOtherArray3 = [];

function First(array, num) {

    if (num == null) {
        return array[0];
    } else if (num <= 0) {
        return [];
    } else {
        for (var i = 0; i <= num - 1; i++) {
            myOtherArray3[i] = array[i];
        }
    }
    return myOtherArray3;
}

//join the all of the elements of an array into a string

var myColor = ["red", "orange", "yellow", "green", "blue", "indigo", "violet"];

function stringJoin(array) {
    return array.join();
}

//most frequent item
var myArray4 = [3, 'a', 'a', 'a', 2, 3, 'a', 3, 'a', 2, 4, 9, 3];

function FindFrequent(array) {
    var count = 0;
    var frequency = 1;
    var item;
    for (var i = 0; i <= array.length - 1; i++) {
        for (var j = i; j <= array.length - 1; j++) {
            if (array[i] == array[j]) {
                count += 1;
            }
            if (frequency < count) {
                frequency = count;
                item = array[i];
            }

        }
        count = 0;
    }
    return item;
}

//find duplicates in array
function FindDuplicates(arr) {
    var len = arr.length,
        out = [],
        counts = [];

    for (var i = 0; i < len; i++) {
        var item = arr[i];
        counts[item] = counts[item] >= 1 ? counts[item] + 1 : 1;
        if (counts[item] === 2) {
            out.push(item);
        }
    }

    return out;
}

//reverse a string
function ReverseString(string) {
    var result = "";
    for (var i = string.length - 1; i >= 0; i--) {
        result += string[i];
    }
    return result;
}

//check if a palindrome
function Palindrome(string) {
    var forwards = string.replace(/[^0-9a-zA-Z]/g, '');
    //forwards = forwards.replace(/,/g, '');
    forwards = forwards.toLowerCase();
    var backwards = ""
    for (var i = forwards.length - 1; i >= 0; i--) {
        backwards += forwards[i];
    }
    if (forwards == backwards) {
        return true;
    } else {
        return false;
    }
}

//return all combinations of a string
function StringCombo(string) {
    var stringArray = [];
    stringArray.push(string);

    for (var i = 0; i < string.length; i++) {
        stringArray.push(string[i]);
    }

    for (var j = 0; j < string.length - 1; j++) {

        for (var k = 0; k < string.length - 1; k++) {
            stringArray.push(string[j] + string[k + 1])

            if (stringArray[j] == undefined || stringArray[k] == undefined) {
                stringArray.pop(string[j]);
                stringArray.pop(string[k]);
            }
        }
    }

    return stringArray;

}

//alphabetize characters
function Alphabetize(string) {
    string = string.split("");
    string = string.sort();
    string = string.join("");
    return string;
}

//return second highest and second lowest
function findSecondLowestAndSecondHighest(arr) {
    //    var i, smallest, largest, secondSmallest, secondLargest;
    //
    //    var smallest = arr[0];
    //    var largest = arr[0]
    //    for(i = 1; i < arr.length; i++){
    //        if(smallest > arr[i]){
    //            smallest = arr[i];
    //        }
    //        if(largest < arr[i]){
    //            largest = arr[i];
    //        }
    //    }
    //
    //    var secondSmallest = largest;
    //    var secondLargest = smallest;
    //    for(i = 0; i < arr.length; i++){
    //        if(arr[i] > smallest && arr[i] < secondSmallest){
    //            secondSmallest = arr[i];
    //        }
    //
    //        if(arr[i] < largest && arr[i] > secondLargest){
    //            secondLargest = arr[i];
    //        }
    //    }
    //
    //    return [secondSmallest, secondLargest];
    //
    //OR
    var sortedArray = arr.sort(function (a, b) {
        return a - b
    });
    return [sortedArray[1], sortedArray[sortedArray.length - 2]];

}


//remove duplicate letters in an array
function RemoveDuplicates(arr) {
    var len = arr.length,
        out = [],
        counts = [];

    for (var i = 0; i < len; i++) {
        var item = arr[i];
        counts[item] = counts[item] >= 1 ? counts[item] + 1 : 1;
        if (counts[item] === 1) {
            out.push(item);
        }
    }
    var str = out.join('');
    var result = str.replace(" ", "");
    return result;
}
