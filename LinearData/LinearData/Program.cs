using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinearData
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Question1\n Enter 2 for Question2\nEnter 3 for Question3\n Enter 5 for Question5\nEnter 6 for Question6\n Enter 7 for Question7\nEnter 8 for Question8");
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
            else if (input==5)
            {
                Question5();
            }
            else if (input==6)
            {
                Question6();
            }
            else if (input==7)
            {
                Question7();
            }
            else
            {
                Question8();
            }
        }
        public static void Question1()
        
        {
            List<int> num = new List<int>();
            Console.WriteLine("Enter positive numbers");
            for (int i = 0; true; i++)
            {
                string en =(Console.ReadLine());
                if (en==string.Empty)
                {
                    break;
                }
                else
                {
                    num.Add(int.Parse(en));
                }
            }

            Console.WriteLine($"The sum of positive integer numbesrs is {num.Sum()}");
            Console.WriteLine($"The sum of positive integer numbesrs is {num.Average()}");

        }

        public static void Question2()
        {
            var stack = new Stack<int>();
            var arr = new[] {1, 2, 3, 4, 5};
            for (int i = 0; i < arr.Length; i++)
            {

                stack.Push(arr[i]);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }

        public static void Question3()
        {
            List<int> ne = new List<int>();
            int temp= 0;
            Console.WriteLine("Enter positive numbers");
            for (int i = 0; true; i++)
            {
                string num =(Console.ReadLine());
                if (num==string.Empty)
                {
                    break;
                }
                else
                {
                    ne.Add(int.Parse(num));
                }
            }
            for (int i = 0; i < ne.Count; i++)
            for (int j = i+1; j < ne.Count; j++)
            {
                if (ne[i]>ne[j])
                {
                    temp = ne[i];
                    ne[i] = ne[j];
                    ne[j] = temp;
                }   
            }

            foreach (var item in ne)
            {
                Console.WriteLine(item);
            }
        }

        public static void Question5()
        {
            List<int> nu = new List<int>();
            Console.WriteLine("Enter numbers");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter nummm");
                int sd = int.Parse(Console.ReadLine());
                if (sd>0)
                {
                    nu.Add(sd);
                }
            }
            foreach (var item in nu)
            {
                Console.WriteLine(item);
            } 
        }

        public static void Question6()
        {
            Hashtable nu =new Hashtable();
            int[] arr = new[] {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
            foreach (var item in arr)
            {
                if (nu.ContainsKey(item))
                {
                    nu[item] = (int) nu[item] + 1;
                }
                else
                {
                    nu.Add(item, 1);
                }
            }
            
            foreach (DictionaryEntry item in nu)
            {
                if ((int) item.Value%2==0)
                {
                    for (int i = 0; i < (int)item.Value; i++)
                    {
                        Console.WriteLine(item.Key);
                    }
                }
            }
        }

        public static void Question7()
        {
            Hashtable nu =new Hashtable();
            int[] arr = new[] {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2};
            foreach (var item in arr)
            {
                if (nu.ContainsKey(item))
                {
                    nu[item] = (int) nu[item] + 1;
                }
                else
                {
                    nu.Add(item, 1);
                }
            }
            
            foreach (DictionaryEntry item in nu)
            {
                        Console.WriteLine($" the number{item.Key} and appeared{item.Value}");
            }
        }

        public static void Question8()
        {
            Hashtable num = new Hashtable();
            int[] arr = new[] {2, 2, 3, 3, 2, 3, 4, 3, 3};
            foreach (var item in arr)
            {
                if (num.ContainsKey(item))
                {
                    num[item] = (int) num[item] + 1;
                }
                else
                {
                    num.Add(item, 1);
                } 
            }

            foreach (DictionaryEntry item in num)
            {
                if ((int)arr.Length / 2+1 == (int)item.Value)
                {
                     Console.WriteLine(item.Key);
                } 
            }
        }

        public static void Question9()
        {
            
        }
    }
}