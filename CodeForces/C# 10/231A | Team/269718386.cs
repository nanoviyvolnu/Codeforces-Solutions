using System;
 
class HelloWorld {
  static void Main() {
    try {
      int n = Convert.ToInt32(Console.ReadLine());
      int[,] matrix = new int[n, 3];
      int countLine = 0;
      int result = 0;
      
      for (int i = 0; i < n; i++) {
          string[] inputs = Console.ReadLine().Split(' ');
          if (inputs.Length != 3) {
              throw new FormatException("Each line must contain exactly 3 integers.");
          }
          for (int j = 0; j < 3; j++) {
              matrix[i, j] = Convert.ToInt32(inputs[j]);
          }
      }
 
      for (int i = 0; i < n; i++) {
          for (int j = 0; j < 3; j++) {
              countLine = (matrix[i, j] == 1) ? countLine + 1 : countLine;
          }
          result = countLine >= 2 ? result + 1 : result;
          countLine = 0;
      }
      
      Console.WriteLine(result);
    } catch (FormatException ex) {
      Console.WriteLine("Input error: " + ex.Message);
    } catch (Exception ex) {
      Console.WriteLine("An error occurred: " + ex.Message);
    }
  }
}