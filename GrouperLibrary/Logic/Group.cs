using System;
using System.Text;

namespace GrouperLibrary
{
    public class Group : IComparable<Group>
    {
        private Student[] students;
        private int score;

        public Student[] Students
        {
            get {return students;}
        }

        public int Score
        {
            get {return score;}
        }

        public Group(Student s1, Student s2, Student s3)
        {
            this.score = GetScore(s1, s2, s3);
            this.students = new Student[] {s1,s2,s3};
        }

        private static int GetScore(Student s1, Student s2, Student s3)
        {
            int score = 0;

            score += StudentCompare(s1, s2);
            score += StudentCompare(s1, s3);
            score += StudentCompare(s2, s3);

            return score;
        }

        private static int StudentCompare(Student s1, Student s2)
        {
            int res = 0;

            int[] arr1 = s1.Answers;
            int[] arr2 = s2.Answers;

            for (int i = 0; i < 6; i++)
            {
                res += AbsDiff(arr1[i], arr2[i]);
            }

            res += s1.GetBonus(s2.Name);
            res += s2.GetBonus(s1.Name);

            return res;
        }

        private static int AbsDiff(int n1, int n2)
        {
            return Math.Abs(n1-n2);
        }

        public override string ToString()
        {
            return String.Format("score: {0}\ngroup:\n\t{1}\n\t{2}\n\t{3}\n\n",
                    score, students[0].Name, students[1].Name, students[2].Name);
        }

        public int CompareTo(Group g)
        {
            return score-g.score;
        }
    }
}
