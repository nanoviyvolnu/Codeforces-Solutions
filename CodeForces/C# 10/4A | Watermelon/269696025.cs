using System;
class HelloWorld {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
    bool result = n % 2 == 0 && n > 2;
    String result2 = result == true ? "YES" : "NO";
    Console.WriteLine(result2);
  }
}