using System;

namespace GrouperLibrary
{
    public static class StudentDB
    {
        public static Student[] CreateDB()
        {
            return new Student[]
            {
                new Student(
                    "test1",
                    1,
                    new int[] {1,2,3,4,5,6},
                    new string[] {"test4", "test3"},
                    new string[] {"test2"}),

                new Student(
                    "test2",
                    1,
                    new int[] {1,2,3,4,5,6},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test3",
                    1,
                    new int[] {1,2,3,4,5,6},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test4",
                    4,
                    new int[] {1,2,3,2,3,6},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test5",
                    3,
                    new int[] {6,3,3,4,3,6},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test6",
                    2,
                    new int[] {3,1,3,4,6,2},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test7",
                    5,
                    new int[] {2,2,2,2,2,2},
                    new string[] {},
                    new string[] {}),

                new Student(
                    "test8",
                    3,
                    new int[] {4,1,1,4,3,6},
                    new string[] {},
                    new string[] {})
            };
        }
    }
}
