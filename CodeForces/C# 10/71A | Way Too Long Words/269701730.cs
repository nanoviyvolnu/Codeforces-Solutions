using System;
 
class HelloWorld {
    static void Main() {
        int numWords = int.Parse(Console.ReadLine());
        for (int i = 0; i < numWords; i++) {
            string word = Console.ReadLine();
            if (word.Length > 10) {
                int count = word.Length - 2;
                string result = $"{word[0]}{count}{word[word.Length - 1]}";
                Console.WriteLine(result);
            } else {
                Console.WriteLine(word);
            }
        }
    }
}