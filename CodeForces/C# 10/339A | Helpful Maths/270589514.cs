/******************************************************************************
 
Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.
 
*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    String operation = Console.ReadLine();
    String result = "";
    
    if(operation.Length >= 1){
        string[] operationMassive = operation.Split('+');
        int[] operationInts = new int[operationMassive.Length];
        for (int i = 0; i < operationMassive.Length; i++)
        {
            operationInts[i] = int.Parse(operationMassive[i]);
        }
        
        for(int i=0; i<operationInts.Length; i++){
            int tmp = 0;
            for(int j=i+1; j<operationInts.Length; j++){
                if(operationInts[i] > operationInts[j]){
                    tmp = operationInts[i];
                    operationInts[i] = operationInts[j];
                    operationInts[j] = tmp;
                }
            }
        }
        for (int i = 0; i < operationInts.Length; i++){
                result += operationInts[i].ToString();
                if (i < operationInts.Length - 1)
                {
                    result += "+";
                }
        }
        
        Console.WriteLine(result);
    }else{
        Console.WriteLine(operation);
    }
  }
}