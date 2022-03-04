uuu# NJAU Master Apprentice Information Management System
## Description
In ancient times, Confucius said, "if three people walk, there must be my teacher." With the popularity of the Internet, people in need can find their own teachers through various channels. You can choose to swim the academic ocean with preaching and teaching teachers in college classes; You can also choose to follow the online teacher to expand your learning in the webcast class; You can even learn life experience, knowledge and skills from your friends, elders and sisters. Although the "master apprentice system" is becoming more and more important and necessary in today's increasingly large flow of knowledge, the previous master apprentice system is often a subsidiary product of a certain software. It is rare to see a specially developed system with "master apprentice management" as the main function in the market, which is thought to help the students of our school obtain knowledge more conveniently, all grades, Students of various majors can have more extensive exchanges. I have developed this Nannong apprentice information management system, which can find and screen suitable teachers according to user needs, allow users to publish questions for help, create a good learning atmosphere through mutual evaluation between teachers and students, and encourage teachers and students to learn interactively through ranking and other mechanisms.

This is a project based on **Database Course Design**. It aims to develop an apprentice information management system for college students, taking the campus of Nanjing Agricultural University as the test subject.The file named **Instructions.pdf** is the system specification, which includes the introduction of all functions realized by the system, the installation process of the system and the demonstration of various functions.The file named **DevLog.md** is the development log of the system, which records in detail the completion of each stage and problems encountered in the development of the whole system.The file named **Report.pdf** is the report of course design, which records all E-R diagrams, database relations, information of each module, SQL statements used and so on in detail.  
You may download as follows.
> + DatabaseFile: Database files and script files
> + Example: Some pictures
> + Project: Engineering documents
> + DevLog.md
> + Readme.md
> + Instructions.pdf
> + Report.pdf
## Language
The programming languages used are as follows.
> + SQL
> + C#

The IDE used is Microsoft Visual Studio 2019. And the database used is SQL Server 2008.
## Requirement Analysis
In ancient times, Confucius said, "if three people walk, there must be my teacher." With the popularity of the Internet, people in need can find their own teachers through various channels. You can choose to swim the academic ocean with preaching and teaching teachers in college classes; You can also choose to follow the online teacher to expand your learning in the webcast class; You can even learn life experience, knowledge and skills from your friends, elders and sisters. Although the "master apprentice system" is becoming more and more important and necessary in today's increasingly large flow of knowledge, the previous master apprentice system is often a subsidiary product of a certain software. It is rare to see a specially developed system with "master apprentice management" as the main function in the market, which is thought to help the students of our school obtain knowledge more conveniently, all grades, Students of various majors can have more extensive exchanges. I have developed this Nannong apprentice information management system, which can find and screen suitable teachers according to user needs, allow users to publish questions for help, create a good learning atmosphere through mutual evaluation between teachers and students, and encourage teachers and students to learn interactively through ranking and other mechanisms.
## Function Introduction
The system realizes different functions for administrators and users.
> For Administrators  
> 1. View the login log
> 2. Clear the login log
> 3. Add a new administrator
> 4. View or search the user name, password and registered telephone number of a user
> 5. View or modify the status of a user account 
> 6. View all fields and their classifications in the system
> 7. View all colleges in the system
> 8. View all learning places in the system

> For Users  
> 1. Retrieve or change password
> 2. Register a new account
> 3. View basic personal information
> 4. Modify basic personal information
> 5.View the current ranking list (teachers / students with the highest scores, users who have completed the most entrustment / learning, and high-frequency problem areas)
> 6. View personal learning history
> 7. View personal history master
> 8. View personal history apprentice
> 9. Issue release
> 10. View published issues
> 11. Filter users by criteria and view their non private information
> 12. View learning in progress
> 13. View or agree to the teacher worship application received by the user
> 14. View the teacher worship application once approved by the user
> 15. View the teacher worship application sent by the user and check whether it has passed
> 16. Send teacher worship application to other users
## Basic Table Design
The system consists of 10 basic tables. The main code of each table is underlined and the outer code is bold and 
italic.
> + Administrator Table (<u>Administrator Name</u>, Administrator Password)
> + User Table (Identification, <u>User Name</u>, login Password, Real Name, Gender, Age, ***College ID***, Contact Information, ***Domain ID***, ***Place ID***, Potential Value of Lecturer, Potential Value of Apprentice, Number of Completed Commissions, Number of Completed Studies, User Status)
> + College Table (<u>College ID</u>, College name)
> + Domain Table (<u>Domain ID</u>, ***Class ID***, Domain name)
> + Domain Classification Table (<u>Class ID</u>, Class name)
> + Learning Place Table (<u>Place ID</u>, Place Name)
> + Learning Record Table (<u>ID</u>, ***Teacher User Name***, ***Student User Name***, ***Domain ID***, Start Time, End Time, Students' Evaluation of Teachers, Teachers' Evaluation of Students)
> + Teacher Worship Record Table (<u>ID</u>, ***Applicant's User Name***, ***Respondent's User Name***, ***Domain ID***, Pass or Not)
> + Question Record Table (<u>ID</u>, ***Questioner***, Question Time, ***Question Domain ID***, Description, Status)
> + Login log Table (<u>ID</u>, ***login Name***, login Type, login Time, login Status)

Keys and constraints in each table.
> + The administrator name is primary key; The initial value of administrator password is' 123456 ', which is not unique and can only be six digits; All properties cannot be empty.
> + The identification code is set as the identification quantity, and the user name is the primary key; The initial value of the login password is' 123456 ', which can only be six digits; Age can only be an integer between 0 and 150; Gender is stored in bit type, 1 indicates male and 0 indicates female; The contact information can only be 11 digits; The college code is a foreign key, which is quoted from the college ID of the college table. The update method is cascade and the deletion method is empty; The method of cascade is empty, the method of cascade is empty, and the code of external field is empty; The code of the frequently visited learning place is foreign key, which refers to the place ID of the learning place table. The update method is cascade, and the deletion method is empty; The initial value of lecturer potential value and apprentice potential value is 60; The initial value of the number of completed commissions and the number of completed studies is 0; The user status is bit type, and the initial value is set to false. True indicates that it is frozen, and false indicates that it is not frozen; Except for user name and contact information, they are not unique. Except for student code, good field code and frequent place code, other attributes cannot be empty.
> + College ID is the primary key, which is the identification quantity. The increment is 1 and the seed is 1; All properties cannot be empty and unique.
> + The domain ID is the primary key, is the identification quantity, the increment is 1, and the seed is 1; The class code is a foreign key, which is referenced from the class ID of the domain classification table. The update method is cascade, and the deletion method is set to blank; Except for the class code, other attributes are unique and cannot be empty.
> + Class ID is the primary key, is the identification quantity, the increment is 1, and the seed is 1; All properties cannot be empty and unique.
> + The location ID is the primary key, is the identification quantity, the increment is 1, and the seed is 1; All properties cannot be empty and unique.
> + The identifier is the primary key, is the identification quantity, the increment is 1, and the seed is 1; The teacher user name and student user name refer to the user name in the user table, and the update and deletion method is no operation; The domain code refers to the domain ID of the domain table. The update method is cascade and the deletion method is set to blank; Except for the end time, the student's evaluation of the teacher, the teacher's evaluation of the student and the field code, they cannot be empty, and they are not unique except for the identifier.
> + The identifier is the primary key, is the identification quantity, the increment is 1, and the seed is 1; Both the applicant's user name and the respondent's user name refer to the user name in the user table, and the update and deletion method is no operation; The domain code refers to the domain ID of the domain table. The update method is cascade and the deletion method is set to blank; Whether it is stored by bit type. 1 means pass and 0 means fail; Not unique except identifier. All properties cannot be empty.
> + The identifier is the primary key, is the identification quantity, the increment is 1, and the seed is 1; The questioner refers to the user name of the user table. The update method is cascade and the deletion method is no operation; The problem domain refers to the domain ID of the domain table. The update method is cascade, the deletion method is set to null, and the processing status can be changed into "1" and "0"; Except for the initial identifier, other attributes are not unique, and only the problem field is allowed to be null.
> + The identifier is the primary key, is the identification quantity, the increment is 1, and the seed is 1; The login name refers to the user name of the user table and the administrator name of the administrator table. No operation is performed in the update and deletion methods; The login type is constrained in two values: user and administrator, and the login status is constrained in two values: allow and reject; Not unique except identifier. All properties cannot be empty.

A total of 5 views are designed: FIELD_ FIELDCLASS_ VIEW, USER_ MORE_ VIEW, QUESTION_ MORE_ VIEW, LEARN_ MORE_ VIEW, MASTER_ MORE_ VIEW。
## System Module
The system has six modules: administrator login module, administrator management module, user registration module, user login module, user information module and user learning module.