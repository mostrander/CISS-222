# CISS222 Spring 2021 - Homework 6

## Purpose
The purpose of this assignment is to consider the role that modeling plays when creating objects for use in your program.

## Objective
You will need to create a single class in a C# console app. This class is to be modeled after a real-life object. 

Remember: 
  * Modeling is the process of taking the attributes and behaviours of a concept and representing them as properties and methods
  * Practically any noun can be modeled into an object

In this assignment, you will need to decide what (appropriate for school) real-life object to model, and:

 * Create a C# class with a name of the object you are modeling
 * Have at least five (5) properties for the class that represent some relevant attributes to the object
 * Set the value of at least two (2) of the properties in a constructor for the class
 * Create at least three (3) methods for the class that represent some relevant behaviours to the object
   * The methods should return a string that will be available for output to the user (it should not be responsible for displaying to the user directly)
   * At least one (1) of the methods should use a value of a property set by the constructor to make sure that the method is valid to use (as an example, if you have a `Car` class with a `Start()` method, make sure that the `FuelAmount` property is greater than zero, otherwise return an error message in the string)
   * At least one (1) of the methods should contain a parameter that is somehow used by the method
   
Once you have modeled the object, in your `Main()` program:

  * `new` up your class prompt the user to set all of the remaining un-set properties
  * Create a menu to allow the methods to be accessed (ex. in the `Car` example, entering 1 will invoke a `Start()` method, entering 2 will execute a `Drive()` method, etc.)
  * Allow a user to use as many methods as they want, and enter a `-1` to exit the program (HINT: review the `while()` loop we discussed in class)

## Expectations and Grading
1. (4 pts) Model the object's attributes into properties based on the assignment guidelines
1. (4 pts) Model the object's behaviours into methods based on the assignment guidelines
1. (2 pts) Create a menu structure in place to interact with the class

## Assignment Retrieval, Testing, and Submission
1. Pull down this repository from GitHub to your local machine and open the solution in Visual Studio.
1. You can check in your work, as well as push to GitHub, as infrequently or as often as you wish. However, you must ensure that your work is checked in and pushed, as that will be how your assignment is turned in. The code as of the due date and time will be the version that will be graded.
