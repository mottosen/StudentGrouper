This is a program for dividing students into student groups of 3. It is meant
for creating student groups for the new students at DIKU, and it does so by
looking at the students responses from a survey as well as a white and black
list for each student - if a student has any preferences or problems with the
other students in the course.

The program is implemented using .NetCore 3.1 and therefore you must have the
newest SDK or runtime installed from Microsoft. See link below:

https://docs.microsoft.com/en-us/dotnet/core/install/

At the moment each students information must be manually formatted using the
"Database" class at "StudentGrouper/GrouperLibrary/Logic/StudentDB.cs".

After the students information has been given to the program, the groups can
be made by navigating to the root folder of the project ("StudentGrouper").
Here you can run the command:

dotnet run --project Grouper/Grouper.csproj

This will create and print the groups with the score for each group and the
names of the students in the group. If a group has a low score it means the
group is a good match. The score can be negative, if the students in the
group have white listed eachother. This means the group is an even better
match.

If the amount of students in the "Database" is not dividable with 3 one or
two students will be leftover. These must manually be placed in the created
groups.
