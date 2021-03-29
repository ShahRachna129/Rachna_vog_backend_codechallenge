using System;
using System.Collections.Generic;
using System.Linq;


namespace TestModule
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>()
        {
            "Jimmy",
            "Jeffrey",
            "John",
        };
        static void Main()
        {
            var ids = NamesList;
            var getStudentInfo = NamesList.Where(s => s.StartsWith("J")).ToList();
        }
    }
}
