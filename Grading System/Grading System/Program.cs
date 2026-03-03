using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("                        GRADING SYSTEM                        ");
            Console.WriteLine("==============================================================");

            String instName;
            String department;
            String course;
            int year;
            int level;
            int sem;
            String regNo;

            Console.WriteLine("\n--------------------------PERSONAL DETAILS------------------------");
            do
            {
                Console.Write("\nEnter the institution's name: ");
                instName = Console.ReadLine().ToUpper();

            } while (String.IsNullOrWhiteSpace(instName));

            do
            {
                Console.Write("\nEnter the department name: ");
                department = Console.ReadLine().ToUpper();

            } while (String.IsNullOrWhiteSpace(department));

            do
            {
                Console.Write("\nEnter the student's course: ");
                course = Console.ReadLine().ToUpper();

            } while (String.IsNullOrWhiteSpace(course));


            Console.Write("\nEnter the student's first name: ");
            String fName = Console.ReadLine().ToUpper();

            Console.Write("\nEnter the student's second name: ");
            String sName = Console.ReadLine().ToUpper();

            while (fName == "" || sName == "")
            {
                Console.WriteLine("\n~Please fill in all the details!");

                Console.Write("\nEnter the student's first name: ");
                fName = Console.ReadLine().ToUpper();

                Console.Write("\nEnter the student's second name: ");
                sName = Console.ReadLine().ToUpper();
            }

            do
            {
                Console.Write("\nEnter the student's Reg NO: ");
                regNo = Console.ReadLine().ToUpper();

            } while (String.IsNullOrWhiteSpace(regNo));

            do
            {
                Console.Write("\nEnter the semester: ");
                sem = Convert.ToInt32(Console.ReadLine());

            } while (sem > 3 || sem < 1);

            do
            {
                Console.Write("\nEnter the student's level: ");
                level = Convert.ToInt32(Console.ReadLine());

            } while (level >= 1 && level > 6);

            //int currentYear = DateTime.Now.Year;

            do
            {
                Console.Write("\nEnter the year: ");
                year = Convert.ToInt32(Console.ReadLine());

            } while (year < 1 || year > 8);


            Console.WriteLine("\n--------------------------UNITS DETAILS------------------------");

            String[] units = new String[5];
            //String[] unitId = new String[5];
            //String[] unitTrainer = new String[5];
            int[] credits = new int[5];
            double[] marks = new double[5];
            String[] grade = new String[5];
            double[] points = new double[5];

            double totalCredits = 0;
            double totalPoints = 0;

            Random random = new Random();

            //Console.WriteLine();

            for (int i = 0; i < units.Length; i++)
            {
                Console.Write($"\nEnter unit {i + 1} name: ");
                units[i] = Console.ReadLine();

                //Console.WriteLine();

                /*Console.Write($"\nEnter unit {i + 1} id: ");
                unitId[i] = Console.ReadLine();*/

                /*Console.Write($"\nEnter unit {i + 1} Trainer: ");
                unitTrainer[i] = Console.ReadLine();*/

                credits[i] = random.Next(2, 6);

                do
                {
                    Console.Write("\nEnter the marks(0-100): ");
                    marks[i] = Convert.ToDouble(Console.ReadLine());

                } while (marks[i] < 0 || marks[i] > 100);

                if (marks[i] >= 85)
                {
                    grade[i] = "A";
                    points[i] = 4.0;
                }
                else if (marks[i] >= 75)
                {
                    grade[i] = "B";
                    points[i] = 3.0;
                }
                else if (marks[i] >= 60)
                {
                    grade[i] = "C";
                    points[i] = 2.0;
                }
                else if (marks[i] >= 40)
                {
                    grade[i] = "D";
                    points[i] = 1.0;
                }
                else
                {
                    grade[i] = "F";
                    points[i] = 0.0;
                }

                totalCredits += credits[i];
                totalPoints += credits[i] * points[i];

            }

            double sgpa = totalPoints / totalCredits;

            Console.WriteLine();

            Console.WriteLine("==============================================");
            Console.WriteLine("                  TRANSCRIPT                  ");
            Console.WriteLine("==============================================");

            Console.WriteLine($"\nInstitution Name: {instName}");
            Console.WriteLine($"Department: {department}");
            Console.WriteLine($"Course: {course}");
            Console.WriteLine($"Student Name: {fName} {sName}");
            Console.WriteLine($"Reg No: {regNo}");
            Console.WriteLine($"Semester: {sem}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Year: {year}");

            Console.WriteLine($"\n{"Unit",-20} {"UnitId",-8} {"Trainer",-8} {"Credits",-8} {"Marks",-8} {"Grade",-8} {"Points",-8}");

            for (int i = 0; i < 5; i++)
            {
                String[] trainers = { "Lorraine", "Moses", "Samuel", "Phillip", "Ogao" };

                Console.WriteLine($"\n{units[i],-20} {i + 1,-8} {trainers[random.Next(trainers.Length)],-11} {credits[i],-7} {marks[i],-8} {grade[i],-8} {points[i],-8}");
            }

            Console.WriteLine($"\n\t\t\t\t\t\tTotal Credits: {totalCredits:10}");
            Console.WriteLine($"\t\t\t\t\t\tSgpa: {sgpa:F2}");

        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("\nError: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("\nError: " + e.Message);
        }

        Console.WriteLine("==============================================");

        Console.WriteLine("\n==============================================================");

    }
}