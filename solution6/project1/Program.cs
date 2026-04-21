namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number of rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter number of columns: ");
            //int cols = Convert.ToInt32(Console.ReadLine());

            //int[,] numbers = new int[rows, cols];

            //// إدخال القيم
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter value for [{i},{j}]: ");
            //        numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nArray values:");

            //// طباعة القيم
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //    Console.WriteLine(); // سطر جديد بعد كل صف





            //*******************Student Management System Using Arrays (C#) ********************

            // Part 1: Student Names
            #region students names
            string[] students = new string[5];

            Console.WriteLine("Enter 5 student names:");
            for (int i = 0; i < students.Length; i++)
            {
                Console.Write($"Student {i + 1}: ");
                students[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudent Names:");
            foreach (string name in students)
            {
                Console.WriteLine(name);
            }


            #endregion


            // Part 2: Student Grades
            #region Student Grades
            int[,] grades = new int[5, 3]; // 5 students, 3 subjects

            string[] subjects = { "Math", "Science", "English" };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"\nEnter grades for {students[i]}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{subjects[j]}: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }


            #endregion

            // Part 3: Display Grades
            #region Display Grades
            Console.WriteLine("\nStudent Grades:");
            Console.WriteLine("Name\tMath\tScience\tEnglish");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(students[i] + "\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + "\t");
                }
                Console.WriteLine();
            }

            #endregion

            // Part 4: Average
            #region Average
            Console.WriteLine("\nStudent Averages:");
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += grades[i, j];
                }

                double avg = (double)sum / 3;
                Console.WriteLine($"{students[i]} Average = {avg}");
            }

            #endregion

        }
    }
}
