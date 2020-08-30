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
                    new int[] {1,2,3,4,5,4},
                    new string[] {},
                    new string[] {},
                    false),

                new Student(
                    "test2",
                    1,
                    new int[] {1,2,3,4,5,4},
                    new string[] {},
                    new string[] {"test1","test3"},
                    true),

                new Student(
                    "test3",
                    1,
                    new int[] {1,2,3,4,5,4},
                    new string[] {},
                    new string[] {},
                    true),

                new Student(
                    "test4",
                    4,
                    new int[] {1,2,3,2,3,2},
                    new string[] {},
                    new string[] {},
                    false),

                new Student(
                    "test5",
                    3,
                    new int[] {2,3,3,4,3,4},
                    new string[] {},
                    new string[] {},
                    true),

                new Student(
                    "test6",
                    2,
                    new int[] {3,1,3,4,1,2},
                    new string[] {},
                    new string[] {},
                    true),

                new Student(
                    "test7",
                    5,
                    new int[] {2,2,2,2,2,2},
                    new string[] {},
                    new string[] {},
                    false),

                new Student(
                    "test8",
                    3,
                    new int[] {4,1,1,4,3,5},
                    new string[] {},
                    new string[] {},
                    false),

                new Student(
                    "test9",
                    4,
                    new int[] {4,2,1,4,3,4},
                    new string[] {},
                    new string[] {},
                    false)
            };
        }
    }
}
