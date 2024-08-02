using System;
class HelloWorld {
  static void Main() {
      string[] arr = Console.ReadLine().Split(" ");
      
      int k = int.Parse(arr[0]);
      int n = int.Parse(arr[1]);
      int w = int.Parse(arr[2]);
      
      int currentSum = 0;
      int result = 0;
      
      for(int i=0; i<=w; i++){
          currentSum+=i*k;
      }
      
      if(n >= currentSum){
          result = result;
      }else{
        result = currentSum - n;
      }
      Console.WriteLine(result);
  } 
}