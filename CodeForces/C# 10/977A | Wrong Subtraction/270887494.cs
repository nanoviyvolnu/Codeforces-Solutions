using System;
class HelloWorld {
  static void Main() {
      string[] input = Console.ReadLine().Split(" ");
      int result = int.Parse(input[0]);
      
      for(int i=0; i<int.Parse(input[1]); i++){
          int temp = result % 10;
        //   Console.WriteLine(" r " + result + " t " + temp);
          if(temp != 0){
             result = result - 1;
             temp = result - 1;
          }else{
              result = result / 10;
          }
      }
      Console.WriteLine(result);
    } 
}