import java.util.Scanner;
 
public class Main
{
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
  
  int k = sc.nextInt();
  int l = sc.nextInt();
  int m = sc.nextInt();
  int n = sc.nextInt();
  int d = sc.nextInt();
  
  int result = 0;
  for (int i = 1; i <= d; i++) {
            if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0) {
                result++;
            }
        }
  
  System.out.print(result);
  
  sc.close();
 }
}