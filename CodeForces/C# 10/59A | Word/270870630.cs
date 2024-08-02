using System;
class HelloWorld {
  static void Main() {
    string word = Console.ReadLine();
    char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
    
    int count = 0;
    string result = "";
    for(int i=0; i<alpha.Length; i++){
        for(int j=0; j<word.Length; j++){
            if(alpha[i] == word[j])
                count++;
        }
    }
    
    if(word.Length - count > count){
        result = word.ToUpper();
    }
    else{
        result = word.ToLower();
    }
    
    Console.WriteLine(result);
    } 
}