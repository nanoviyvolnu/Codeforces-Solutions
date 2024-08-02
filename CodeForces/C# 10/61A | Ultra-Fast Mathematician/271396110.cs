using System;
using System.Text;
 
class HelloWorld {
    static void Main() {
        string aInput = Console.ReadLine();
        string bInput = Console.ReadLine();
        
        char[] a = aInput.ToCharArray();
        char[] b = bInput.ToCharArray();
        
        StringBuilder sb = new StringBuilder();
        for(int i=0; i<a.Length; i++){
            if(a[i] == '1' && b[i] == '0' || a[i] == '0' && b[i] == '1'){
                sb.Append("1");
            }
            else if(a[i] == '0' && b[i] == '0' || a[i] == '1' && b[i] == '1'){
                sb.Append("0");
            }
        }
        
        string result = sb.ToString();
        Console.Write(result);
    }
}