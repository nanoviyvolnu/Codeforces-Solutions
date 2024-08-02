using System;
 
class HelloWorld {
    static void Main() {
        string[] input = Console.ReadLine().Split(" ");
        
        int n = int.Parse(input[0]); 
        int k = int.Parse(input[1]);
        
        int result = 0;
        
        string[] marks = Console.ReadLine().Split(" ");
        int[] scores = Array.ConvertAll(marks, int.Parse);
        
        int kthScore = scores[k - 1];
        
        for(int i = 0; i < n; i++) {
            if(scores[i] > 0 && scores[i] >= kthScore) {
                result++;
            } else {
                break;
            }
        }
        
        Console.WriteLine(result);
    }
}