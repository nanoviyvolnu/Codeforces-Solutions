import java.util.Scanner;
 
public class Main {
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
 
  int n = sc.nextInt();
 
  int[] enter = new int[n];
  int[] leave = new int[n];
 
  for(int i = 0; i < n; i++) {
   enter[i] = sc.nextInt();
   leave[i] = sc.nextInt();
  }
 
  int currentPeople = 0;
  int maxPeople = 0;
//
  for(int i = 0; i < n; i++) {
   currentPeople -= enter[i] - leave[i];
   if(currentPeople > maxPeople) {
    maxPeople = currentPeople;
   }
  }
 
  System.out.println(maxPeople);
 }
}