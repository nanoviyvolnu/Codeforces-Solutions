/******************************************************************************
 
                            Online Java Compiler.
                Code, Compile, Run and Debug java program online.
Write your code in this editor and press "Run" button to execute it.
 
*******************************************************************************/
import java.util.Scanner;
 
public class Main
{
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
  
  int m = sc.nextInt();
  int n = sc.nextInt();
  
  int result = 0;
  
  result = (m * n) / 2;
  
  System.out.print(result);
 }
}