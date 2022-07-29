using System;
using System.Linq;

namespace SubjectMarks
{
    class StudentResult
    {
        int[] cSharp;
        int[] html;
        int[] sql;
        public StudentResult(int n)
        {
            cSharp = new int[n];
            html = new int[n];
            sql = new int[n];
            
        }
        public void acceptMarks(int n)
        {
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter c# marks of student {0}", i + 1);
                cSharp[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter HTML marks of student {0}", i + 1);
                html[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter SQL marks of student {0}", i + 1);
                sql[i] = int.Parse(Console.ReadLine());
            }

        }
        public void displayResult(int n)
        {
            for(int i=0; i < n; i++)
            {
                int total = cSharp[i] + html[i] + sql[i];
                int avg = total / 3;
                
                if (avg > 50)
                {
                    Console.WriteLine("Student {0} Total Marks: {1} Avg. Marks: {2}  Result: Pass", i + 1, total, avg);
                }
                else
                {
                    Console.WriteLine("Student {0} Total Marks: {1} Avg. Marks: {2}  Result: Fail", i + 1, total, avg);
                }
            }
        }
        public static void Main(String[] args)
        {
            
            int num;
            Console.WriteLine("Enter number of students: ");
            num = int.Parse(Console.ReadLine());
            StudentResult s = new StudentResult(num);

            s.acceptMarks(num);
            s.displayResult(num);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}