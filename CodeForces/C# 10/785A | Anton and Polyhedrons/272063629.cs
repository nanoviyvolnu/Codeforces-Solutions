using System;
using System.Collections.Generic;
using System.Linq;
 
class HelloWorld {
    static void Main() {
        Dictionary<string, int> figures = new Dictionary<string, int>();
        figures.Add("Tetrahedron", 4);
        figures.Add("Cube", 6);
        figures.Add("Octahedron", 8);
        figures.Add("Dodecahedron", 12);
        figures.Add("Icosahedron", 20);
        
        int n = int.Parse(Console.ReadLine());
        string[] figuresInput = new string[n];
        int result = 0;
        
        for(int i=0; i<n; i++){
            figuresInput[i] = Console.ReadLine();
        }
        
        foreach(string i in figuresInput){
            foreach(KeyValuePair<string, int> j in figures){
                if(i == j.Key){
                    result += j.Value;
                }
            }
        }
        
        Console.WriteLine(result);
    }
}