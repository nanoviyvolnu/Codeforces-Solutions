using System;
 
class HelloWorld {
    static void Main() {
        int n = Convert.ToInt32(Console.ReadLine());
        
        string[] inputs = Console.ReadLine().Split(" ");
        int[] convertedInputs = Array.ConvertAll(inputs, int.Parse);
        
        int result = 0;
        int min = convertedInputs[0];
        int max = convertedInputs[0];
        
        for (int i = 1; i < convertedInputs.Length; i++)
        {
            if (convertedInputs[i] < min) {
                min = convertedInputs[i];
                result++;
            } else if (convertedInputs[i] > max) {
                max = convertedInputs[i];
                result++;
            }
        }
        
        Console.WriteLine(result);
    }
}