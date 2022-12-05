# Java Graded Assignment #4 Rubric (TechJobs, Persistent Edition)

For [this assignment](https://education.launchcode.org/csharp-web-development/assignments/tech-jobs-persistent.html) students are tested for their understanding of SQL database management and the mechanics of object relational mapping. Students will demonstrate their knowledge of these topics by making updates again to the TechJobs application.
They will be asked to create the database connection, finish what has been started to persist several model classes, 
create a one-to-many and a many-to-many relationship between objects, and answer a few simple SQL questions.

Grading will be done via demonstrations. Students will be asked to give a walkthrough of their source code,
as well as the running application.

## Assignment Requirements

1. Connect a `Database` to an ASP.NET application
2. Add Employers
3. Work with Many-To-Many Relationships

## Unit Tests

The starter code contains 3 unit test projects.

`TestTaskOne.Tests` contains the test class that verifies the connection between the database and the application.

`TechJobsPersistent.Tests` has over 25 tests within different test classes and covers all of Task 2. If any of these tests fails, students need to carefully explore the test results for where an error occured.  

This test project verifies the following:
   * `AddJobViewModel` - Does it exist? How does it handle information?
   * `Employer` and `Skill` - Do they contain the correct fields, correct accessors, correct validation annotations, constructors, and persistence.
   * Controllers - Do controller methods route properly? Do they properly handle data inputs, different methods, and storing data?

`TestTaskThree.Tests` contains the test class that verifies that students have set up the one-to-many relationship between jobs and skills properly.

### Performance and Code Check:

[Working Demo App](https://techjobs-persistent.launchcodetechnicaltraining.org/)

Use the checks below to explore the working app.

1. Start the application and navigate to the *Add Job* view.
1. Create a new employer from the form and view the resulting object in the employer table.
1. Create at least two new skills from the form and view the objects in the skill table.
1. Create a new Job from the form, selecting at least two skills. 

   a. Once created, view the job table and verify that there is an ``employer_id`` column in it. 
     
   b. Confirm that a mapped table is present for ``job_skills`` and that at least two rows are now in it
      for the job just created.

## Submitting Your Work

To submit your work please follow the [Submission Instructions](https://education.launchcode.org/csharp/assignments/hello-world.html#submitting-your-work)
