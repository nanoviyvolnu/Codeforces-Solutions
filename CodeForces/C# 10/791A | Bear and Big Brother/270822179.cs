using System;
class HelloWorld {
  static void Main() {
      string[] inp = Console.ReadLine().Split(' ');
      
      int l = int.Parse(inp[0]);
      int b = int.Parse(inp[1]);
      int count = 0;
      while(l <= b){
            ++count;
            l*=3;
            b*=2;
        }
      Console.WriteLine(count);
  }
}