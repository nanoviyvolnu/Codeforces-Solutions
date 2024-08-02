using System;
class HelloWorld {
  static void Main() {
    int n = int.Parse(Console.ReadLine());
    
    int result = 0;
    
    int[] nominals = new int[5]{1, 5, 10, 20, 100};
    
    for(int i = nominals.Length - 1; i >= 0; i--){
        while(n >= nominals[i]){
            n -= nominals[i];
            result++;
        }    
    }
    Console.WriteLine(result);
  }
}