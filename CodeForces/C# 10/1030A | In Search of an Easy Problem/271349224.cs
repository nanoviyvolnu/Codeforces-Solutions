using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        
        string[] answers = Console.ReadLine().Split(" ");
        int[] answersConverted = Array.ConvertAll(answers, int.Parse);
        
        string result = "";
        
        for(int i=0; i<answersConverted.Length; i++){
            if(answersConverted[i] == 1){
                result = "HARD";
                break;
            }else{
                result = "EASY";
            }
        }
        
        Console.WriteLine(result);
    }
}