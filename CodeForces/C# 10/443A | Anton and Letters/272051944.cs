using System;
using System.Collections.Generic;
using System.Linq;
 
class HelloWorld {
    static void Main() {
        string n = Console.ReadLine().Trim();
        int result = 0;
        if(n == "{}"){
            result = result;
        }
        else{
            string newString = n.Substring(1, n.Length - 2);
            string[] tempArr = newString.Split(',');
    
            HashSet<string> tempHash = new HashSet<string>();
    
            foreach (string s in tempArr) {
                string trimmed = s.Trim();
                tempHash.Add(trimmed);
            }
            
            result = tempHash.Count();
        }
        Console.WriteLine(result);
    }
}