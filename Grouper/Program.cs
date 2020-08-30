using System;
using GrouperLibrary;

namespace Grouper
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list of students is created and returned by
            // the "Database" class.
            Student[] db = StudentDB.CreateDB();

            // The list of students can be passed to the group
            // manager class which will find the best possible
            // combination of groups of 3 students.
            Group[] groups = GroupManager.CreateGroups(db);

            // After finding the best possible combination of
            // groups the groups are printed showing the score
            // of each group as well as the names of the students
            // in the group.
            int i = 0;
            foreach (Group g in groups)
            {
                Console.WriteLine("Hold {0}:\n"+g, i);
                i++;
            }
        }
    }
}
