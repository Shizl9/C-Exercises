namespace project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows :");
            int rows =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns :");
            int cols =Convert.ToInt32(Console.ReadLine());
            int [,] numbers = new int[rows, cols];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    // user Enter the number of rows and coloms
                    Console.WriteLine($"Enter Value for row {i}, column {j}:");
                numbers[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }
             Console.WriteLine("\n array values are :");
            //print the array values:
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    Console.Write(numbers[i, j] + " ");
                }

             }  
            
            Console.WriteLine();
        }
    }
}
