using System;
 
class HelloWorld {
    static void Main() {
        string[] input = Console.ReadLine().Split(" ");
        
        int n = Convert.ToInt32(input[0]);
        int k = Convert.ToInt32(input[1]);
        
        int result = 0;
        
        if (n % 10 == k) {
            result = 1;
        }
        else {
            int originalN = n;
            bool found = false;
            for (int i = 1; i <= 1000; i++) {
                n = originalN * i;
                if (n % 10 == k) {
                    result = i;
                    found = true;
                    break;
                }
                else if(n % 10 == 0){
                    result = i;
                    found = true;
                    break;
                }
            }
        }
        
        Console.WriteLine(result);
    }
}