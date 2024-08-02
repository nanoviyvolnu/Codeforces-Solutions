using System;
 
class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        int[][] inputs = new int[n][];
        int[] results = new int[n];
 
        for(int i = 0; i < n; i++){
            inputs[i] = new int[2];
            string[] inputLine = Console.ReadLine().Split(' ');
            for(int j = 0; j < 2; j++){
                inputs[i][j] = int.Parse(inputLine[j]);
            }
        }
    
 
        for(int i = 0; i < inputs.Length; i++) {
            int a = inputs[i][0];
            int b = inputs[i][1];
            int steps = a % b; 
            
            if(steps == 0){  
                steps = 0;
            }else{ 
                results[i] = b - steps; // -1, 
            }
        }
 
        for(int i = 0; i < results.Length; i++) {
            Console.WriteLine(results[i]);
        }
    }
}