// Welcome message
console.log("Welcome to JavaScript!");

// Declare and initialize variables
let number = 10;
let name = "Alice";

// Print the variables
console.log("Number: " + number);
console.log("Name: " + name);

// Use a loop to print numbers from 1 to 5
console.log("Printing numbers from 1 to 5:");
for (let i = 1; i <= 5; i++) {
    console.log(i);
}

// Use a conditional statement to check if a number is even or odd
let checkNumber = 7;
if (checkNumber % 2 === 0) {
    console.log(checkNumber + " is even.");
} else {
    console.log(checkNumber + " is odd.");
}

// Function to calculate the square of a number
function square(num) {
    return num * num;
}

// Call the square function
let squareResult = square(4);
console.log("Square of 4 is: " + squareResult);

