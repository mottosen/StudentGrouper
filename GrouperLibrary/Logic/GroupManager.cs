using System;
using System.Collections.Generic;

namespace GrouperLibrary
{
    public static class GroupManager
    {
        public static Group[] CreateGroups(Student[] students)
        {
            List<Group> groups = new List<Group>();
            List<string> taken = new List<string>();

            Group[] allGroups = ScoreGroups(students);

            foreach (Group g in allGroups)
            {
                bool conflict = false;
                Student[] studentsTMP = g.Students;

                foreach (Student s in studentsTMP)
                {
                    if (taken.Contains(s.Name)) conflict = true;
                }

                if (conflict) continue;

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

            groups.Sort();

            return groups.ToArray();
        }

        public static void Function()
        {
            Student[] db = StudentDB.CreateDB();

            Group[] groups = CreateGroups(db);

            foreach (Group g in groups)
            {
                Console.WriteLine(g);
            }
        }
    }
}
