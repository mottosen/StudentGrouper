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
            // When we create an instance of a group the
            // score is automatically calculated.
            this.score = GetScore(s1, s2, s3);
            this.students = new Student[] {s1,s2,s3};
        }

        private static int GetScore(Student s1, Student s2, Student s3)
        {
            int score = 0;

            // The group is scored by matching the different
            // combinations of students to check how each pair
            // matches eachother.
            score += StudentCompare(s1, s2);
            score += StudentCompare(s1, s3);
            score += StudentCompare(s2, s3);

            // The group gets a better score if all students
            // in the group attended the intro week.
            if (s1.Intro && s2.Intro && s3.Intro) score -= 10;

            // The total score of the group is returned. The
            // higher the score the worse the group is. The
            // score can be negative which means the group is
            // very good.
            return score;
        }

        private static int StudentCompare(Student s1, Student s2)
        {
            int res = 0;

            int[] arr1 = s1.Answers;
            int[] arr2 = s2.Answers;

            // Two students are first matched based on their
            // answers to the survey.
            for (int i = 0; i < 6; i++)
            {
                int diff = AbsDiff(arr1[i], arr2[i]);

                if (s1.IsPriority(i) || s2.IsPriority(i))
                {
                    diff *= 2;
                }

                res += diff;
            }

            // Next the students are matched by looking at
            // each of their white and black lists to check
            // for their preferences.
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
