using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;

namespace LinqAssignment
{
    public class Question1
    {
        public string Subs(string str, int index, int length)
        {
            return str.Substring(index, length);
        }
    }

    public class Question2
    {
        public int sum(IEnumerable<int> num)
        {
            return num.Sum();
        }
        public int min(IEnumerable<int> num)
        {
            return num.Min();
        }
        public int max(IEnumerable<int> num)
        {
            return num.Max();
        }
        public double ave(IEnumerable<int> num)
        {
            return num.Average();
        }
    }

    public class Student
    {
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public int Age { get; set; }
        public List<Student> Students =new List<Student>();
        
    }

    public static class Question7
    {
        public static string capitalize(this string str)
        {
            return new CultureInfo("en-US", false).TextInfo.ToTitleCase(str);
        }
    }
}