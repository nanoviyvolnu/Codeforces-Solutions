using System;
 
class HelloWorld {
    static void Main() {
        string[] input = Console.ReadLine().Split(" ");
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        
        for (int i = 0; i < a; i++) {
            if (i % 2 == 0) {
                for (int j = 0; j < b; j++) {
                    Console.Write("#");
                }
            } else {
                if ((i / 2) % 2 == 0) {
                    for (int j = 0; j < b - 1; j++) {
                        Console.Write(".");
                    }
                    Console.Write("#");
                } else {
                    Console.Write("#");
                    for (int j = 1; j < b; j++) {
                        Console.Write(".");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}