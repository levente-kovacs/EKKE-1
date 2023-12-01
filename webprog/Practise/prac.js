const checkLocalStorage = () => {
    return localStorage.getItem('myVariable');
}

const changeVariableBtn = document.querySelector('.change');
const navBar = document.querySelector('nav');
let localStorageValue = checkLocalStorage();
let variable = `<h1>Yoooo</h1>`;

if (localStorageValue) {
    navBar.innerHTML = localStorageValue;
} else {
    navBar.innerHTML = variable;
}

changeVariableBtn.addEventListener('click', () => {
    localStorageValue = checkLocalStorage();
    if (!localStorageValue) {
        variable = `<button><a href="./yooo.html"><strong>Yooo</strong><sub>.html</sub></a></button>`;
        localStorage.setItem('myVariable', variable);
    } else {
        variable = `<h1>Yoooo</h1>`;
        localStorage.removeItem('myVariable');
    }
    navBar.innerHTML = variable;
})



// // https://blog.hubspot.com/website/javascript-interview-questions
// // 21. Write a function to reverse a string in JavaScript.
// const reverseString = (string) => {
//     return string.split('').reverse().join('');
// }
// console.log(reverseString('Hello world!'));

// // 22. Write a function to find the largest number in an array in JavaScript.
// function findMaxInArr(arr) {
//     return Math.max(...arr);
// }
// console.log(findMaxInArr([0, 1, 2, 3, 1.2, 3.00001, 0.999, -5]));

// // 23. Write a function to check if a given number is prime in JavaScript.
// const checkIfPrime = (number) => {
//     if (number == 0 || number == 1) {
//         return false;
//     }
//     for (let i = 2; i <= number / 2; i++) {
//         if (number % i == 0) {
//             return false;
//         }
//     }
//     return true;
// }

// let primes = [];
// for (let i = 0; i < 100; i++) {
//     if (checkIfPrime(i)) {
//         primes.push(i);
//     }
// }
// console.log(`primes: `, primes);

// // STACKOVERFLOW
// const isPrime = num => {
//     for (let i = 2, s = Math.sqrt(num); i <= s; i++) {
//         if (num % i === 0) return false;
//     }
//     return num > 1;
// }

// // 24. Write a function to remove duplicates from an array in JavaScript.
// const removeDuplicates = (arr) => {
//     return [...new Set(arr)];
// }
// console.log(removeDuplicates([1, 1, 'hashtag', 'hashtag', 1, 5, {
//         name: 'John'
//     }, {
//         name: 'John'
//     }, {
//         name: 'John',
//         age: 23
//     },
//     [0, 1],
//     [0, 1]
// ]));

// // 25. Write a function to check if two strings are anagrams in JavaScript.
// const checkAnagrams = (string1, string2) => {
//     if (string1.length !== string2.length) {
//         return false;
//     }
//     return string1.toLowerCase().split('').sort().toString() === string2.toLowerCase().split('').sort().toString() ? true : false;
// }
// console.log(checkAnagrams('oYooo', 'Yooooa'));

// // 26. Write a function to find the factorial of a given number in JavaScript.
// const calcFactorial = (number) => {
//     if (number < 0) {
//         return 'Error';
//     }
//     let factorial = number;
//     if (number > 1) {
//         for (let i = number - 1; i > 0; i--) {
//             factorial *= i;
//         }
//     } else {
//         return 1;
//     }
//     return factorial;
// }
// console.log(calcFactorial(6));

// // 27. Write a function to sort an array in JavaScript.
// const sortDescArr = (arr) => {
//     return arr.sort((a, b) => b - a);
// }
// console.log(sortDescArr([3, 1, 5, 0]));

// // 28. Write a function to implement a stack in JavaScript. ??

// // const implementStack = (arr, item) => {
// //     arr.push(item);
// // }
// // console.log(implementStack([0, 1, 2], 3));

// // function Stack() {
// //     this.items = [];
// // }
// // Stack.prototype.push = function (element) {
// //     this.items.push(element);
// // };
// // Stack.prototype.pop = function () {
// //     if (this.items.length === 0) {
// //         return "Underflow";
// //     }
// //     return this.items.pop();
// // };
// // Stack.prototype.peek = function () {
// //     return this.items[this.items.length - 1];
// // };
// // Stack.prototype.isEmpty = function () {
// //     return this.items.length === 0;
// // };
// // Stack.prototype.print = function () {
// //     console.log(this.items.toString());
// // };

// // 29. Write a function to implement a queue in JavaScript.

// // 31. Write a function to implement bubble sort in JavaScript.
// function bubbleSort(arr) {
//     const len = arr.length;
//     for (let i = 0; i < len; i++) {
//         for (let j = 0; j < len - i - 1; j++) {
//             if (arr[j] > arr[j + 1]) { // swap elements
//                 [arr[j], arr[j+1]] = [arr[j+1], arr[j]];
//                 // const temp = arr[j];
//                 // arr[j] = arr[j + 1];
//                 // arr[j + 1] = temp;
//             }
//         }
//     }
//     return arr;
// }
// console.log(bubbleSort([3, 7, 1, 9, 0, 2]));