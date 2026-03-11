function greet() {
    console.log("Hello yasir!");
}

// Function call
greet();


function addNumbers(a, b) {
    console.log(a + b);
}

addNumbers(4, 3); 
addNumbers(41, 7); 

console.log("Hello world");
Math.max(10,20);

      
function add(a,b) {
    console.log(add(16,18));
}                           

function factorial(n){
    if(n=== 0) return 1;
    return n* factorial(n-1);
}
console.log(factorial(5));


function add(a, b) {  
    alert("Sum = " + (a + b));
}

add(5, 5); 
add(4, 3); 

function add(a, b) {  
    alert("Sum = " + (a + b));
}

add(5, 10);  
add(7, 3);   


function factorial(n) {
    if(n === 0) return 1;
    return n * factorial(n-1);
}

console.log(factorial(5));  


// Interactive 3-number Calculator in JavaScript

// Functions for calculations
function add(a, b, c) {
    console.log("Addition: " + (a + b + c));
}

function subtract(a, b, c) {
    console.log("Subtraction: " + (a - b - c));
}

function multiply(a, b, c) {
    console.log("Multiplication: " + (a * b * c));
}

function divide(a, b, c) {
    if(b !== 0 && c !== 0) {
        console.log("Division: " + (a / b / c));
    } else {
        console.log("Cannot divide by zero!");
    }
}

// Prompt user for 3 numbers
let num1 = Number(prompt("Enter first number:"));
let num2 = Number(prompt("Enter second number:"));
let num3 = Number(prompt("Enter third number:"));

// Call the functions with user input
add(num1, num2, num3);
subtract(num1, num2, num3);
multiply(num1, num2, num3);
divide(num1, num2, num3);