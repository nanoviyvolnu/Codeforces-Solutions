using System;
 
class HelloWorld {
    static void Main() {
        int n = int.Parse(Console.ReadLine()); 
        string[] input = Console.ReadLine().Split(" "); 
 
        int currentFreeOfficers = 0; 
        int result = 0; 
 
        for (int i = 0; i < input.Length; i++) {
            int eventValue = int.Parse(input[i]); 
 
            if (eventValue > 0) {
                currentFreeOfficers += eventValue;
            } else {
                if (currentFreeOfficers > 0) {
                    currentFreeOfficers--;
                } else {
                    result++;
                }
            }
        }
 
        Console.WriteLine(result); 
    }
}