using System;
using GrouperLibrary;

namespace Grouper
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] db = StudentDB.CreateDB();

            Group[] groups = GroupManager.CreateGroups(db);

            int i = 0;
            foreach (Group g in groups)
            {
                Console.WriteLine("Hold {0}:\n"+g, i);
            }
        }
    }
}
