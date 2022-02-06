using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAssignment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Question1\n Enter 2 for Question2\nEnter 3 for Question3\nEnter 8 for Question8\nEnter 5 for Question5\nEnter 6 for Question6\n Enter 7 for Question7");
            var input = int.Parse(Console.ReadLine());
            if (input==1)
            {
                Question1();
            }
            else if (input==2)
            {
                Question2();
            }
            else if (input==3)
            {
                Question3();
            }
            else if (input==4)
            {
                Question4();
            }
            else if (input==5)
            {
                Question5();
            }
            else if (input==6)
            {
                Question6();
            }
            else
            {
                Question7();
            }
        }

        public static void Question1()
        {
            var le = "Hello World";
            var sub = le.Substring(0, 8);
            Console.WriteLine(sub);
        }

        public static void Question2()
        {
            int[] arr = new[] {1, 5, 9, 5, 9};
            Console.WriteLine($"The sum is {arr.Sum()}");
            Console.WriteLine($"The min is {arr.Min()}");
            Console.WriteLine($"The Max is {arr.Max()}");
            Console.WriteLine($"The Average is {arr.Average()}");
        }

        public static void Question3()
        {
            var students = new List<Student>()
            {
                new Student(){FirstName = "Adebayo", LastName = "Sobowale", Age = 43},
                new Student(){FirstName = "Bayo", LastName = "Wale", Age = 32},
                new Student(){FirstName = "Tayo", LastName = "Ife", Age = 87},
            };
            var num = students.Where(s => s.FirstName.CompareTo(s.LastName) == -1).ToList();
            foreach (var item in num)
            {
                Console.WriteLine(item.FirstName);
            }
        }

        public static void Question4()
        {
            var students = new List<Student>()
            {
                new Student(){FirstName = "Adebayo", LastName = "Sobowale", Age = 15},
                new Student(){FirstName = "Bayo", LastName = "Wale", Age = 16},
                new Student(){FirstName = "Tayo", LastName = "Ife", Age = 20},
                new Student(){FirstName = "Ayo", LastName = "Sodiq", Age = 43},
                new Student(){FirstName = "Mariam", LastName = "Femi", Age =21},
                new Student(){FirstName = "Baseet", LastName = "Ife", Age = 19},
            };
            var num = from student in students where (student.Age > 18) where (student.Age<24) select student;
            foreach (var item in num)
            {
                Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName}");
            }
        }

        public static void Question5()
        {
            var students = new List<Student>()
            {
                new Student(){FirstName = "Adebayo", LastName = "Sobowale", Age = 15},
                new Student(){FirstName = "Bayo", LastName = "Wale", Age = 16},
                new Student(){FirstName = "Tayo", LastName = "Ife", Age = 20},
                new Student(){FirstName = "Ayo", LastName = "Sodiq", Age = 43},
                new Student(){FirstName = "Mariam", LastName = "Femi", Age =21},
                new Student(){FirstName = "Baseet", LastName = "Ife", Age = 19},
            };
            var num = students.OrderBy(s => s.FirstName).ThenBy(b => b.LastName);
            foreach (var item in num)
            {
                Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName}");
            }

            var lin = from student in students orderby (student.FirstName) orderby (student.LastName) select student;
            foreach (var item in lin)
            {
                Console.WriteLine($"FirstName:{item.FirstName} LastName:{item.LastName}");
            }
            
        }
        public static void Question6()
        {
            int[] arr = new[] {21, 48, 57};
            var num = from i in arr where i % 7 == 0 where i % 3 == 0 select i;
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

            var nu = arr.Where(s => s % 3 == 0).Where(s => s % 7 == 0);
            foreach (var item in nu)
            {
                Console.WriteLine(item);
            }
            
        }

        public static void Question7()
        {
            string let = "this iS a Sample sentence";
            var num = let.capitalize();
            Console.WriteLine(num);
        }
    }
}