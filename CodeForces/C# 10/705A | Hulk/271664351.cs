using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        int input = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < input; i++){
            if(i % 2 == 0){
                sb.Append("I hate ");
            }
            else{
                sb.Append("I love ");
            }
            if (i < input - 1) {
                sb.Append("that ");
            }
        }
        
        sb.Append("it");
        
        string result = sb.ToString();
        Console.WriteLine(result);
    }
}