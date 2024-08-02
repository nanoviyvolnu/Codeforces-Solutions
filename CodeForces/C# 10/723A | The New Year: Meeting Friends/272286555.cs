using System;
class HelloWorld {
  static void Main() {
    string[] input = Console.ReadLine().Split(" ");
    int[] numbers = Array.ConvertAll(input, int.Parse);
    
    int medNumber = 0;
    int result = 0;
    
    for(int i=0; i<numbers.Length; i++){
        for(int j=i+1; j<numbers.Length; j++)
        if(numbers[i] > numbers[j]){
            int tmp = numbers[i];
            numbers[i] = numbers[j];
            numbers[j] = tmp;
        }
    }
    
    for(int i=0; i<numbers.Length; i++){
        int aux = numbers.Length / 2;
        medNumber = numbers[aux];
    }
    
    for(int i=0; i<numbers.Length; i++){
        if(numbers[i] != medNumber){
            result += Math.Abs(numbers[i] - medNumber);
        }
    }
    Console.WriteLine(result);
  }
}