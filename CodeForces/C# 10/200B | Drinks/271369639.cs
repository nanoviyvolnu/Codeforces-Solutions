using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        string[] percentages = Console.ReadLine().Split(" ");
        
        int sum = 0;
        float result = 0;
        
        for(int i=0; i<percentages.Length; i++){
            sum += int.Parse(percentages[i]);
        }
        
        result = (float)sum / (float)n;
        
        Console.WriteLine(result);
    }
}