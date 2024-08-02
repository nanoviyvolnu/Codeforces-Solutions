using System;
using System.Collections.Generic;
 
class HelloWorld {
  static void Main() {
    string[] input = Console.ReadLine().Split(" ");
    int result = 0;
    int lengthOfHorseShoes = input.Length;
    
    List<string> temp = new List<string>();
    
    for(int i=0; i<input.Length; i++){
        if(!temp.Contains(input[i])){
            temp.Add(input[i]);
        }
    }
    
    string[] distinctArray = temp.ToArray();
    int countOfHorseShoes = distinctArray.Length;
    
    result = lengthOfHorseShoes - countOfHorseShoes;
    
    Console.WriteLine(result);
  }
}