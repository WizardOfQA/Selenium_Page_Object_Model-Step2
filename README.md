# Selenium_UI_Automation_POM
## Description:
Now with all the basic functionalities implemented, this Selenium UI Automatin Framework will show how to structure and implements POM. Since I don't control nor maintain these websites, some tests might be broken as these webistes are being updated. But as of 4/14/2018, every test in this framework works fine!!!  
This is the second part of the entire series of Selenium UI Test Automation.  

### Roadmap for Selenium UI Test Automation Series:
1> Selenium_UI_Automation Without POM - Manily Focus on Selenium API Functionalities  
**2> Selenium_UI_Automation With POM - The Structure and Creating of POM**  
3> Selenium_UI_Automation With Logging and Reporting Functionalities.(Extent Report) - How to Logging and Reporting using Extent Reports in a Selenium framework.          
4> Selenium_UI_Automation With Behavior Driven Development(BDD) Using Specflow - How to implment BDD to the framework using Specflow.

I might add more series as needed to showcase UI Automation with Selenium.  

## Page Object Model
### Background:
Without using POM, if 100 different scripts are using the same page element, all 100 pages must be updated with even a small change on  that element. 
In Page Object Model(POM), each page is map to its own class. These clases then can be reused across the framework. 
With the same scenario, now only the element in a specific class needs to be updated, not 100 different scripts.

### Some Advantages of Using POM
* Code maintenance becomes whole lot easier!!!
* Code becomes easier to be understood.
* Increase Code Reusability
* Decrease Code Duplication
* Decrease the amount of the code.
* Improves Code Readability.

### Implementation 
* Create a class for each web page in a web application.
* Each page has identified WebEelments and page specific methods.
* Create PageBase class and put all the common elements and methods so that these elements and methods can be used across the framework.
* Make each page inherits PageBase class.

## Sameple Test Cases Covered:
### Orbitz.com
* User_Can_Search_Vacation_Rental
* User_Can_Search_Rental_Car_With_Advanced_Options

