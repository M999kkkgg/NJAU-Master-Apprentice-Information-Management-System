# Development Log
The whole development process lasted six weeks.
## The First Week
Carry out demand analysis according to the selected topic and improve the assignment. It is preliminarily determined that the object-oriented subject of my system is divided into two parts: users and administrators, who can further understand the needs through network data, investigation and other ways. Determine the basic functions of users - view information, modify information, send teacher worship application, learn, end learning and view records; Basic functions of the administrator - view users, manage basic information of the system, and view basic information of the system.
## The Second Week
Further revise the assignment of topic selection, optimize, refine and simplify the system functions according to personal ability.  
In terms of mutual evaluation, users' enthusiasm is increased; And the function of retrieving the password through the telephone number is set to ensure the user's information security; The learning records, apprenticeship records, apprenticeship records and application records that users can view are further subdivided into "completed / issued" and "ongoing / unfinished", which facilitates the user's experience; Add the function of issuing questions, and connect the application for teacher worship with the function of issuing questions.  
In terms of administrators, the function of managing users is added, which can freeze or unfreeze an account; The function of adding, deleting and modifying the basic information of the system is deleted, and only the basic information of the system can be viewed; Added the function of adding a new administrator; The function of viewing / deleting login log is added to ensure the security of the system.  
Considering the possible conflicts at different levels in the use of the system, the following restrictions are added:
> 1. In the same field, each user can only have one unresolved problem at the same time, but can have multiple solved problems at the same time.
> 2. Users can only apply for teacher worship in the field where teachers are good at, and can't cross field teacher worship.
> 3. In the same field, for the same teacher, each user can only have one failed teacher worship application at the same time, but there can be multiple approved teacher worship application records at the same time.
> 4. In the same field, for the same teacher, each user can only have one ongoing learning record at the same time, but there can be multiple completed learning records at the same time.
> 5. When a user sends a teacher worship application, the system will first retrieve whether there are unresolved problems in this field published by the user. If so, modify the attribute to "solved" and then create a teacher worship application record. If not, create a "solved" problem record and then create a teacher worship application record.
## The Third Week
The following objectives have been achieved.
> + Analyze functional dependencies
> + Design ER model
> + Optimized ER model
> + Design basic tables and add related constraints
> + Design view
> + Design trigger
## The Fourth Week
Learn the basic knowledge of c#. Test the connection between database and c#. Design login interface and administrator interface, complete the relevant functions of "login interface" and "administrator interface", and test the logic.
## The Fifth Week
Write the core functions of the system and realize all interactive functions at the front end. Load a large amount of basic data information for the first test. In the view "published problems" interface, the list of "published problems by this user" is added, instead of just displaying all the problems. The function of administrator searching users directly is added. Fixed the bug of conversion between bit type data read out by SQL statement and bool type of C #. Fixed the bug that failed to visit the teacher due to not clicking "show details". Fixed the bug that users failed to register due to adding spaces when registering (spaces are not allowed now). Fixed the bug of retrieving the wrong password (now the registered phone number must be unique). Before the front end realizes a function with SQL statement, the count or select method is used to check whether the user input is legal according to the conditions entered by the user, so as to avoid conflicts with the integrity constraints of the table
## The Sixth Week
Beautify the interface and add tooltip function at some buttons and text boxes to remind users of precautions; Labels are added to all interfaces to indicate the main functions of the interface; The user name / administrator name of the current operation is added to all interfaces; The connection between some interfaces is changed. Clicking the "exit system" or "exit login" button will not close all the interfaces, but return to the original user login interface. According to the common errors of users, add a humanized prompt box in case of errors. Optimize the code. For some strings in the code, the trim function is added to remove the spaces. Three volunteers were found to conduct system test, collect test information and user feedback, and observe whether the changes of the back-end basic table meet the expectations during user use.