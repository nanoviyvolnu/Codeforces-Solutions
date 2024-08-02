using System;
using System.Linq;
using System.Collections.Generic;
 
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string word = Console.ReadLine();
        bool isPangram = IsPangram(word);
        Console.WriteLine(isPangram ? "YES" : "NO");
    }
 
    static bool IsPangram(string word)
    {
        word = new string(word.ToLower().Where(char.IsLetter).ToArray());
 
        HashSet<char> letterSet = new HashSet<char>(word);
 
        return letterSet.Count == 26;
    }
}