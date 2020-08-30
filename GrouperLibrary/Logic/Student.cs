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
            // The input is tested for mistakes
            if (priority < 0 || priority > 5)
            {
                throw new System.ArgumentException(
                    "Priority index must be between 0 and 5.", "priority");
            }
            else if (answers.Length != 6)
            {
                throw new System.ArgumentException(
                    "Answer list must be of length 6.", "answers list");
            }
            else
            {
                foreach (int n in answers)
                {
                    if (n < 1 || n > 5)
                    {
                        throw new System.ArgumentException(
                            "The individual answers must be an integer between 1 and 5.",
                            "individual answers");
                    }
                }
            }

            // We create the student instance using the given
            // input tested before
            this.name = name;
            answers[priority] *= 2; // The prioritized answer is given a greater weight
            this.formAnswers = answers;
            this.positives = positives;
            this.negatives = negatives;
        }

        public int GetBonus(string s)
        {
            int res = 0;

            // The two lines below checks whether two students are
            // a good match by looking at the white and black lists.
            // If the student we are matching with is on the white
            // list the score is reduced, meaning the score will be
            // better, and opposite if the student being matched is
            // on the black list the score will be increased giving
            // a worse score.
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
