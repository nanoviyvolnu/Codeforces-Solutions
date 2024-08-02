using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        int[][] matrix = new int[n][];
        int index = 0;
        int result = 0;
        while (index < n)
        {
            string[] arr = Console.ReadLine().Split(" ");
            int p = int.Parse(arr[0]);
            int q = int.Parse(arr[1]);
            
            matrix[index] = new int[] { p, q };
            
            index++;
        }
        
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length - 1; j++)
            {
                int aux = matrix[i][j + 1] - matrix[i][j];
                if (aux >= 2)
                {
                    result++;
                }
            }
        }       
        
        Console.WriteLine(result);
        
        
    }
}