# Project & Portfolio 1 

* **Assignment: Impact of Version Control**
* **Ramón González Argüello**
* **13/10/2019**	

This research paper summarizes my time and effort looking into the topic matter outlined below. I have included links and references to research information used for this activity.    

## Topic: Terminal
Professional developers use Terminal daily. It's essential to understand some fundamental commands to use the application. Here's what I have learned...  

**1. Using Terminal, there are essential Linux commands I must know.**

* **clear**: Clear the Screen 
* **pwd**: Print the "Working Directory" **(Hassan, n.d.)**
* **ls**: List files and folders
* **ls -a**: List files and folders, including invisible files
* **ls -l**: List all files and folders, in human readable form
* **cd**: Change directory
* **cd /**: Change directory, go to root
* **cd..**: Change directory, go up one folder level
* **cd ../..**: Change directory, go up two folder levels
* **cd ~/Desktop/**: Change directory to my desktop! 

**2. After Trying this in Terminal, I learned...**

**Folder Drop:** When you simply drop a file into terminal and press enter it will show the following: **"/Users/ramongonzalezarguello/Documents/GitHub/dvp1-1910-RamonG2017/activities/research: is a directory".** Now when you put **"cd"** before whatever folder you drop, it will go to the directory of the folder and then you can access whatever you want.
 
## Topic: Version Control & Git
Version control, also known as revision control, records changes to a file or set of files over time so that you can recall specific versions later. In this class, we are learning Git. Here's what I have learned. 

**1. There are three types of version control.**

* **Local Version Control System**: Maintains track of files within the local system. A widespread and straightforward approach to version control. Error-prone meaning that the chances of accidentally writing to the wrong data are higher. **("Learn The Three Different Types Of Version Control Systems", 2018)**
* **Centralized Version Control Systems**: All the changes in the files are tracked under the centralized server. The centralized server includes all the information of versioned files and list of clients that check out data from the central place.
* **Distributed Version Control System**: The clients completely clone the repository including its full history. If any server dies, any of the client repositories can be copied on to the server with help restore the server.

**2. Using Terminal, there are essential Git commands I must know.**

* **git clone [url]**: Clone a repository
* **git config --global user.name “[firstname lastname]”**: Set-up a global user name
* **git config --global user.email “[valid-email]”**: Set-up a global email address (to match my GitHub account eMail)
* **git status**: Show modified files
* **git add [file]**: Add modified files to the next commit
* **git commit -m “[descriptive message]”**: Make a commit with a new message **("GIT CHEAT SHEET", n.d.)**
* **git log**: Show my commit history
* **git help**: This command will bring up Git's help screen in Terminal!
    
**3. Authenticating with GitHub from Git.**

First you have to open terminal and then accessing the desired repository where you want to clone your repository. Then, you use the command **git clone** followed by the URL of your repository. Terminal will then ask you for your GitHub username and password to clone.


# References
GIT CHEAT SHEET. Retrieved 10 October 2019, from https://education.github.com/git-cheat-sheet-education.pdf

Hassan, M. The 50 Most Useful Linux Commands To Run in the Terminal. Retrieved 10 October 2019, from https://www.ubuntupit.com/the-50-best-linux-commands-to-run-in-the-terminal/

Learn The Three Different Types Of Version Control Systems. (2018). Retrieved 10 October 2019, from https://blog.eduonix.com/software-development/learn-three-types-version-control-systems/

Which remote URL should I use? - GitHub Help. Retrieved 10 October 2019, from https://help.github.com/en/articles/which-remote-url-should-i-use#cloning-with-https-urls-recommended



