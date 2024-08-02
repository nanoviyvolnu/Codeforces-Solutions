using System;
class HelloWorld {
  static void Main() {
      int n = int.Parse(Console.ReadLine());
      int sum = 0;
      
      string[] arr = new string[n];
      
      for(int i=0; i<n; i++){
          string s = Console.ReadLine();
          arr[i] = s;
      }
      
      for(int i=0; i<arr.Length; i++){
          if(arr[i] == "X++" || arr[i] == "++X"){
              sum += 1;
          }else{
              sum -= 1;
          }
      }
      
      Console.WriteLine(sum);
  }
}