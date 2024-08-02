using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        StringBuilder sb = new StringBuilder();
        for (int i = b.Length - 1; i >= 0; i--){
            sb.Append(b[i]);
        }
        
        string temp = sb.ToString();
        
        if(a == temp){
            Console.WriteLine("YES");
        }else{
            Console.WriteLine("NO");
        }
    }
}