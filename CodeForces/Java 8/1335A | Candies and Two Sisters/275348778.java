import java.util.Scanner;
 
public class Main {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
 
  int n = sc.nextInt();
  int[] candys = new int[n];
 
  for (int i = 0; i < n; ++i) {
   candys[i] = sc.nextInt();
  }
 
  for (int i = 0; i < candys.length; ++i) {
 
   if (candys[i] % 2 != 0) {
    candys[i] += 1;
   }
 
   System.out.println(candys[i] / 2 - 1);
  }
  sc.close();
 }
}