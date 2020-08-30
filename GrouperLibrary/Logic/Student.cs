using System;

namespace GrouperLibrary
{
    public class Student
    {
        private string name;
        private int[] formAnswers;
        private string[] positives;
        private string[] negatives;

        public string Name
        {
            get {return name;}
        }

        public int[] Answers
        {
            get {return formAnswers;}
        }

        public Student(string name, int priority, int[] answers, string[] positives, string[] negatives)
        {
            if (priority < 0 || priority > 5)
            {
                throw new System.ArgumentException("Priority index must be between 0 and 5.", "priority");
            }
            else if (answers.Length != 6)
            {
                throw new System.ArgumentException("Answer list must be of length 6.", "answers");
            }

            this.name = name;
            answers[priority] *= 2;
            this.formAnswers = answers;
            this.positives = positives;
            this.negatives = negatives;
        }

        public int GetBonus(string s)
        {
            int res = 0;

            if (Array.Exists(positives, elm => elm.Equals(s))) res -= 10;
            if (Array.Exists(negatives, elm => elm.Equals(s))) res += 10;

            return res;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
