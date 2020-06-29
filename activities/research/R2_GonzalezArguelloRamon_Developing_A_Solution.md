**[ Update this research document where indicated. Update all bracket symbols [ ] below and replace with your own text. Also delete this first sentence. ]**

## Project & Portfolio 1

* **Developing a solution**
* **Ramón González Argüello**
* **21/10/2019**

This research paper summarizes my time and effort looking into the topic matter outlined below. I have included links and references to research information used for this activity.    

## Topic: Diagram a Process
There are certain techniques used in the industry that can help a developer think through and diagram a logical process. After research into this topic, here's what I have learned...  

**1. UML Stands for...**

Unified Modelling Language	

**2. Common Symbols used in UML include...**.

* Beginning Node: control node at which flow starts when the activity is invoked.
* Final Node: control final node that stops all flows in an activity/ control final node that terminates a flow. It destroys all tokens that arrive at it but has no effect on other flows in the activity. (Fakhroutdinov, K. (2019))
* Decision: control node that accepts tokens on one or two incoming edges and selects one outgoing edge from one or more outgoing flows.
* Process:  a series of actions or steps taken in order to achieve a particular end.
* Action: The Action symbol contains the action being performed, actions can be put in sequence connected by control flows to show the order of
operations.
* Control Flow: The control flow shows the direction of the process.


**3. An action in a UML diagram is usually followed by...**

a decision.
 
 
**4. An action is a verb, something that takes place. Write a line of code that can represent an action that occurs after a decision point in a program (think of an if/else statement).**

``` C#

if (decision == true)
{
	Console.WriteLine("that is the correct decision 						 +10 points");
}
else
{
	Console.WriteLine("incorrect, -10 points");
}
 
```

**5. How many actions are in this statement? "Open the container, pour the fudge, and close the container.**
 
There are 3 actions in this statement.


## Topic: Document a Process
There are certain techniques used in the industry that can help a developer think through and document a logical process. After research into this topic, here's what I have learned...   

**1. What is an algorithm?**

An algorithm is defined as a set of rules that must be followed when solving a particular problem.("algorithm noun - Definition, pictures, pronunciation and usage notes | Oxford Advanced Learner's Dictionary at OxfordLearnersDictionaries.com", n.d.)

An example of an algorithm is trying to access your email account, you have to enter the correct email and password combination in order to access your email, otherwise you will be denied access.

**2. Is there one way to write pseudo-code?**

There is no set way of writing pseudo-code it is just a way to find a solution without worrying of what programming language and what syntax is used. It mostly just an outline of what needs to be done and how an algorithm should work.

Example:

1. set total to zero
2. get list of numbers
3. loop through each number in list
4. 	add each number to total
5. end loop
6. if number is larger than zero
7. print "it's a positive number"
8. else
9. print "it's zero or negative"
10. end if

**3. Provide an example of a simple control-structure used in C#.**

``` 

int EquipmentTest;
switch (EquipmentTest)
{
	case 30:
	Console.WriteLine(“Replace.”);
		break;
	case 60:
	Console.WriteLine(“Perform service.”);
		break;
	case 90:
	Console.WriteLine(“No service required.”);
		break;
	default:
	Console.WriteLine(“Perform another test.”);
		break;
}
 
```
("C# Tutorial - Control Statements", n.d.)

# References

Fakhroutdinov, K. (2019). UML activity diagram controls are activity nodes coordinating the flows between other nodes: initial node, flow final, activity final, decision, merge, fork, join.. Uml-diagrams.org. Retrieved 21 October 2019, from https://www.uml-diagrams.org/activity-diagrams-controls.html#initial-node

algorithm noun - Definition, pictures, pronunciation and usage notes | Oxford Advanced Learner's Dictionary at OxfordLearnersDictionaries.com. Retrieved 21 October 2019, from https://www.oxfordlearnersdictionaries.com/definition/english/algorithm?q=algorithm


C# Tutorial - Control Statements. Retrieved 21 October 2019, from https://freeasphosting.net/csharp-tutorial-control-statements.html

