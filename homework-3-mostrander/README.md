# CISS222 Spring 2021 - Homework 3

## Purpose
The purpose of this assignment is to re-acquaint yourself with the concepts from CISS 160 and integrate them with concepts in chapters 1 and 2 of the textbox.

## Objective
The objective of this assignment is to walk through various code concepts that have been (re-)introduced at a high level. This is done by finding bugs and inefficiencies in code that is being provided:

### Lines

* Many of the lines in the USConstitution.cs file are in bad shape - they aren't indented logically, some are too long, some are too short, and the use of blank spaces doesn't make sense. Go through the USConstitution.cs file and make sure that the lines are displayed in a way that makes sense to you. This means the indentation is consistent, there isn't too much use of word wrap, and blank lines are used to logically group code lines together (*HINT try hitting <ENTER> in between quotation marks and see what happens*)
* There are no comments in the Program.cs or USConstition.cs files. Remember, comments are used to help describe why something is done in a certain way, and not necessarily how. Attempt to add 2-3 relevant comments to the code where it makes sense. You may use either single-line comment syntax or multi-line comment syntax. (*HINT: think about how you can group variables together logically in the USConstitution.cs file and write a comment for each grouping*)
* There is a line that is commented out in the Program.cs class that makes you press <ENTER> before moving to the next step. Uncomment this line out.
* We want to reduce the amount of content that the program handles. Use single-line commment syntax to comment out the display for article 6, and multi-line syntax to comment out the display for the amendments.
   
### Variables and data types
* There is a compilation error because of a data type issue with a variable. Identify the error and find a better data type for the variable.
* There is another variable with an inefficient data type. Identify that variable and select a better data type.
* There is a variable name that is far too long. Identify it and come up with a better variable name.
* There is a variable name that is too short and non-descriptive. Identify it and come up with a better variable name, and then use the `Console.WriteLine()` syntax to display it in a similar manner to other fact data.
* There is a variable that uses the "var" keyword in the Program.cs file. C# still assigns a data type to this varaible. Using the debugger, determine the data type it is being set to and then update the var keyword to that data type.
* Convert the string that states "Constitution of the United States of America" to a constant string variable and use it in the `Console.WriteLine()` statement.
* There is a try/catch block to catch an exception. Based on the type of exception caught, modify a value in the program to cause the exception to be thrown (*HINT* check to see if you need to change a value in the USFacts.cs file*)

### Additional
* Place the following comment in the line above the control structure in the project (normally, this would be classified as an "unhelpful" comment): // This is a control structure
* Place the following comment in the line above the instantiation (new keyword) of an array in the project (normally, this would also be an "unhelpful" comment: // This is an array
* We want to compute and display the Gross Domestic Product (GDP) per capita, which means the average GDP per person. Calculate the GDP per capita and print it out in the `Console.WriteLine("GDP per capita: ");` after the colon.

## Expectations and Grading
1. (4 pts) Complete the requested items in the Lines section
1. (4 pts) Complete the requested items in the Variables and data types section
1. (2 pts) Complete the requested items in the Additional section

## Assignment Retrieval, Testing, and Submission
1. Pull down this repository from GitHub to your local machine and open the solution in Visual Studio.
1. You can check in your work, as well as push to GitHub, as infrequently or as often as you wish. However, you must ensure that your work is checked in and pushed, as that will be how your assignment is turned in. The code as of the due date and time will be the version that will be graded.
