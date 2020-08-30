using System;
using System.Collections.Generic;

namespace GrouperLibrary
{
    public static class GroupManager
    {
        public static Group[] CreateGroups(Student[] students)
        {
            // This list will be used to store the best groups in.
            List<Group> groups = new List<Group>();

            // This list will be used to store the names of
            // students already placed in a group.
            List<string> taken = new List<string>();

            // This array holds all possible combinations
            // of groups. Each group instance contains the
            // names of students in the group as well as
            // the score for the group.
            Group[] allGroups = ScoreGroups(students);

            // The loop below finds the best possible groups
            // by using a greedy approach. The list of all
            // combinations is sorted, with the best groups
            // first, and we can therefore find the best
            // groups by always choosing the next group in
            // the array with no students in other created
            // groups.
            foreach (Group g in allGroups)
            {
                bool conflict = false;
                Student[] studentsTMP = g.Students;

                // This check makes sure there is no overlap
                // in students in the created groups. A student
                // should and will only be placed in one group.
                foreach (Student s in studentsTMP)
                {
                    if (taken.Contains(s.Name)) conflict = true;
                }

                if (conflict) continue;

                // If there is no overlap between the students
                // in the group we are looking at and the already
                // created groups, we store the group and the
                // names of the students in the group.
                groups.Add(g);

                foreach (Student s in studentsTMP)
                {
                    taken.Add(s.Name);
                }
            }

            return groups.ToArray();
        }

        private static Group[] ScoreGroups(Student[] students)
        {
            int limit = students.Length;
            List<Group> groups = new List<Group>();

            // The loops below make sure to find all combinations
            // of groups with no duplicates.
            for (int i = 2; i < limit; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    for (int k = 0; k < j; k++)
                    {
                        groups.Add(new Group(students[i], students[j], students[k]));
                    }
                }
            }

            // The groups are sorted using their score.
            groups.Sort();

            return groups.ToArray();
        }
    }
}
