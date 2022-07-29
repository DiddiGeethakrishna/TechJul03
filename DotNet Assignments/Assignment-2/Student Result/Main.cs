using System;
using System.Linq;

namespace Student
{
    public class Marks
    {
        int rollNo;
        string name;
        int sem;
        string batch;
        string branch;
        int[] marks;
        bool flag=true;
        int subjectCount;
        public Marks(int rollNo, string name, int sem, string branch, string batch)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.sem = sem;
            this.branch = branch;
            this.batch = batch;
        }
        public void insertMarks(int num)
        {
            this.subjectCount = num;
            marks = new int[num];
            for(int i=0; i < num; i++)
            {
                Console.WriteLine("Enetr marks for subject {0} :",i+1);
                marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void displayResult()
        {
            Console.WriteLine("Marks for the all subjects are as below:");
            Console.WriteLine();
            int total=0;
            foreach(int j in marks)
            {
                Console.Write(j + ", ");
                if (j > 35)
                {
                    total += j;
                }
                else
                {
                    flag = false;
                    total += j;
                }
            }
            Console.WriteLine("Total Marks: {0}",total);
            if (flag == false)
            {
                Console.WriteLine("Result: FAIL. One or more subject has <= to 35 marks");
            }
            else if (total/subjectCount<50)
            {
                Console.WriteLine("Result: FAIL. Average score <= 50: {0}",total/subjectCount);
            }
            else{
                Console.WriteLine("Result: PASS, Score: {0}%",total/subjectCount);
            }
        }

        public void displayDetails()
        {
            
            Console.WriteLine("Student Name: {0}",name);
            Console.WriteLine("Roll No: {0}",rollNo);
            Console.WriteLine("Class/ Branch: {0}",branch);
            Console.WriteLine("Sem: {0}",sem);
            Console.WriteLine("Batch: {0}", batch);

            displayResult();
           
        }
    }
    class StudentResult
    {
        public static void Main()
        {
            int rollNo;
            string name;
            int sem;
            string batch;
            string branch;
            int subjectCount;
            Console.WriteLine("Enetr Student Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Roll.no: ");
            rollNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Branch Name");
            branch = Console.ReadLine();
            Console.WriteLine("Enter Sem.No: ");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("Enetr Batch: ");
            batch = Console.ReadLine();
            Console.WriteLine("Enter total subject count: ");
            subjectCount = int.Parse(Console.ReadLine());

            Marks m = new Marks(rollNo, name, sem,branch,  batch);
            m.insertMarks(subjectCount);
            int ch;
            do
            {
                Console.WriteLine("Select your choice:\n1. Display Result \n2. Display all details with result \n3. Exit");
                ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        m.displayResult();
                        break;
                    case 2:
                        m.displayDetails();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            } while (ch!= 2);
        }
    }
}