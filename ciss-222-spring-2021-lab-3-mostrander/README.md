# CISS222 Spring 2021 - Lab 3

## Purpose
The purpose of this lab is to continue to build familiarity with control structures, loops, data types, equality operations, arithmetic operations, user input, and user display.

## Objective
Write a program that takes in a series of integers (type `int`, can be positive, negative, or zero) typed in one at a time by the user. When all numbers the user wants to enter are entered, the program then displays the number of integers entered, the largest of all numbers entered AND the second largest of all numbers entered. 

Write the program so that it can read in and process an unlimited number of input values from the user. The user will need to enter a non-numeric sentinel value that you specify and display on screen to indicate when they are done. Validate the numbers that are input to make sure they are numeric (you do not need to do range validation). If an invalid input is entered, prompt the user to that effect with an error message and allow the user to continue to enter values. Once the sentinel value has been entered, display the count of the number of numbers entered, the largest number entered, and the second largest number entered.

The program should look similar to the following:

```
Enter in an integer, or enter q to stop:
5
Enter in an integer, or enter q to stop:
7
Enter in an integer, or enter q to stop:
e
Sorry, that is not an integer.
Enter in an integer, or enter q to stop:
3
Enter in an integer, or enter q to stop:
8
Enter in an integer, or enter q to stop:
q

The total number of integers entered is: 4
The highest integer entered is: 8
The second highest integer entered is: 7
```

## Implementation Details and Additional Notes

* This program will be written by implementing a single class with an appropriate name of your choosing. 
* The class should expose a public method with an appropriate signature (appropriate return type, name, and parameters - *HINT: do you need each of those?*) invoked by the `Main()` method that accepts the user input and returns control to the `Main()` method. 
* Once the control is returned to `Main()`, the `Main()` method will access three public properties (that cannot be modified by the caller of the object) for the number of integers entered, the largest number, and the second largest number entered and display them to the user with appropriate text providing context to the user.
 * The public method should encapsulate its functionality in appropriate private method(s) within the class.
 * *IMPORTANT*: Do NOT use arrays or any similar constructs, or any other concepts that have yet to be covered in class.

## Expectations and Grading
1. (6 pts) Implement a class that is appropriately modeled based on the requirements.
1. (7 pts) Accept an arbitrary number of valid integers to be entered by the user.
1. (3 pts) Allow the user to re-enter an integer when an invalid integer is entered by the user. (*HINT*: a truncated decimal would be considered an invalid integer.)
1. (3 pts) Allow the user to stop entry by entering a non-numeric sentinel.
1. (3 pts) Determine and capture the number of integers entered by the user.
1. (5 pts) Determine and capture the largest integer entered by the user.
1. (5 pts) Determine and capture the second largest integer entered by the user.
1. (3 pts) Display the number of integers, largest integer, and the second largest integer entered by the user after the input is complete.

## Assignment Retrieval, Testing, and Submission
1. Pull down this repository from GitHub to your local machine.
1. You can check in your work, as well as push to GitHub, as infrequently or as often as you wish. However, you must ensure that your work is checked in and pushed, as that will be how your assignment is turned in. The code as of the due date and time will be the version that will be graded.
