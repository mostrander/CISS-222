# CISS222 Spring 2020 - Lab 1 - Instructions

## Notes

## Instructions

### Create an empty Microsoft Word document
You will be capturing a series of screenshots in the course of this assignment. Create a new Microsoft Word document titled "Lab1-" and your first and last name without a space (for example, I would create it as Lab1-DavidGreen.docx). You will be adding screenshots to this document and uploading it to Canvas upon completion of the assignment.

### Create and commit solution using Visual Studio GUI

#### Clone repository locally
You will need to start this process by cloning this repository and pulling down the code to begin.

- [ ] In this repository, click the green "Clone or download" and copy the repository link provided
- [ ] Open Visual Studio (VS) and click "Clone or check out code"
- [ ] VS will provide you with a path to store the local copy of this repository. Normally, you would just take what is provided here, but we will be using this repository twice. In the Local Path box, after what is provided, which should be "lab-1-(your GitHub username)," enter in "\_GUI" to the end of the folder path. 
- [ ] Take a screenshot of the solution and project
- [ ] Add a heading in the Microsoft Word document called "Clone repository via VS" and paste in the screenshot
- [ ] Click Clone.

At this point, you now have exactly on your computer a copy of this repository as it is in GitHub (it also depends if you've saved changes to this file). 

#### Create text file
GitHub is a source control management system, but it can handle any file - not just code. As an example, we can create a simple text file and track it in GitHub via VS.

- [ ] In VS, go to File > New > File. Choose Text File and click Open. In the text file, type in "My name is (your name here) and this is using GitHub via Visual Studio." Save the file with the file name gui.txt.
- [ ] Look for the Team Explorer window and open the Changes section. You should see the file you just created listed. 
- [ ] Take a screenshot of the Team Explorer window
- [ ] Add a heading in the Microsoft Word document called "Text file created via VS" and paste in the screenshot

GitHub is a hosted version of a source control system called git. Right now, your copy of VS is using a locally installed version of git to manage these files. Neither your local version of git nor GitHub know about this new file. The process of telling the local version of git that a new file (or multiple new files) are available is called "committing." From there, the process of telling GitHub that your local version of git has committed files is known as "pushing."

- [ ] In the Team Explorer, there is a text box that says "Enter a commit message..." In this box, enter in a meaningful commit message - one that describing what changes you are making, and possibly why. Right now, this would be trivial. However, if you are working on a larger project, or with multiple people, or something that spans a long range of time, being able to look back on meaningful commit messages is beneficial.
- [ ] Click Commit All. You will get a message that a commit was created locally. 
- [ ] Go back to the repository in GitHub.
- [ ] Take a screenshot of the listing of files in the repository
- [ ] Add a heading in the Microsoft Word document called "Commit all via VS" and paste in the screenshot

- [ ] After the commit all, there will be a hyperlink to Sync. Click the Sync link. If you do not see the Sync link, click the button that looks like a house in the Team Explorer, and choose Sync. Click the Push link.
- [ ] Go back to the repository in GitHub. Take a screenshot of the listing of files in the repository and paste it between the below slashes.
- [ ] Take a screenshot of the listing of files in the repository
- [ ] Add a heading in the Microsoft Word document called "Push via VS" and paste in the screenshot

#### Create solution and project
While interesting, tracking a text file via VS isn't particularly useful. We need to create a solution and a project to properly manage C# code.

- [ ] Create a new project by going to File > New > Project. Select the C# console app for .NET Core project type. Give it a project name Lab1-(your first and last name without a space)-GUI. In the location, be sure to browse to the location of your repository (*hint*: it will have lab1 in the name).
- [ ] Navigate back to the Team Explorer and switch to the Changes view. 
- [ ] Take a screenshot of the solution and project
- [ ] Add a heading in the Microsoft Word document called "Create project via VS" and paste in the screenshot

- [ ] Using what you've learned so far, commit and push the changes to GitHub with a relevant commit message using VS.
- [ ] Go to GitHub and take a screenshot of the file listing
- [ ] Add a heading in the Microsoft Word document called "Push project via VS" and paste in the screenshot

### Create and commit solution using command line
Both .NET Core and GitHub aren't just accessible from a GUI via Visual Studio. There is also a robust command line interface (CLI) that allows you to perform the same functions you did with the GUI.

#### Clone repository locally

- [ ] In this repository, click the green "Clone or download" and copy the repository link provided.
- [ ] Open a command prompt by going into the Windows Taskbar search box and typing Command Prompt (alternatively, press the Windows key and R at the same time, and enter in cmd)
- [ ] Navigate to the repository folder for your user account. Type `cd %HOMEPATH%\source\repos\LCCC-DGREEN\` and press Enter. Type `mkdir lab-1-CLI` and press Enter. Type `cd lab-1-CLI` and press Enter.
- [ ] Type `git clone`, a space, and paste in the link from GitHub, and press Enter.
- [ ] List the directory by typing `dir` and press Enter.
- [ ] Take a screenshot
- [ ] Add a heading in the Microsoft Word document called "Clone repository via CLI" and paste in the screenshot

At this point, you now have exactly on your computer a copy of this repository as it is in GitHub (it also depends if you've saved changes to this file). This includes the text file and solution you created in VS.

#### Create text file
You can also create and manipulate files via the command line.

- [ ] Open a command prompt and navigate to the repository directory
- [ ] Create a new text file by typing `echo`, a space, "My name is (your name here) and this is using GitHub via the Windows Command line", another space, `>> cli.txt` and pressing Enter.
- [ ] List the directory
- [ ] Take a screenshot
- [ ] Add a heading in the Microsoft Word document called "Text file created via CLI" and paste in the screenshot

Again, like when you created the text file via the GUI, you've created a file, but neither your local version of git nor GitHub are aware of the file's creation. To get them to know about your new file, you need to perform the same tasks - commit and push. The command line offers tools that allow you to perfrom these exact functions.

First, you will need to stage the files. VS handles this for you, [though you can explicitly stage files](https://docs.microsoft.com/en-us/azure/devops/repos/git/commits?view=azure-devops&tabs=visual-studio) if you want to incrementally commit), but when you use the command line, you need to take the explicit step of staging. 

- [ ] Open a command prompt and navigate to the repository directory
- [ ] Type in `git add cli.txt` and press Enter.
- [ ] Type in `git commit -m`, a space, and then in between quotation marks, type in a meaningful commit message, then press Enter.
- [ ] Go back to the repository in GitHub. 
- [ ] Take a screenshot of the listing of files in the repository
- [ ] Add a heading in the Microsoft Word document called "Commit via CLI" and paste in the screenshot

Once you've committed, like with VS, you still need to push changes to GitHub. The concept is the same, but you will use git commands via the command line.

- [ ] Open a command prompt and navigate to the repository directory
- [ ] Type in `git push -u origin master`, then press Enter.
- [ ] Go back to the repository in GitHub. 
- [ ] Take a screenshot of the listing of files in the repository
- [ ] Add a heading in the Microsoft Word document called "Push via CLI" and paste in the screenshot

#### Create solution and project
While interesting, tracking a text file via a command line isn't particularly useful, just like with VS. We need to create a solution and a project to properly manage C# code. This can also be accomplished via the command line, with the dotnet command provided by Microsoft.

- [ ] Open a command prompt and navigate to the repository directory
- [ ] Type in `dotnet new console -n`, a space, and then type in Lab1-(your first and last name without a space)-CLI, then press Enter.
- [ ] Go back to the repository in GitHub. 
- [ ] Take a screenshot of the listing of files in the repository 
- [ ] Add a heading in the Microsoft Word document called "Create project via CLI" and paste in the screenshot

- [ ] Using what you've learned so far, commit and push the changes to GitHub with a relevant commit message using the command line.
- [ ] Go to GitHub and take a screenshot of the file listing
- [ ] Add a heading in the Microsoft Word document called "Push project via CLI" and paste in the screenshot

----

### Questions

Return to the assignment in Canvas and answer the questions.
