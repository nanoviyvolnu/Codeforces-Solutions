import java.util.Scanner;
 
public class Main
{
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
  
  int n = sc.nextInt();
  int[] gifts = new int[n];
  int[] giftsResult = new int[n];
  
  int index = 0;
  
  for(int i=0; i<n; i++){
      gifts[i] = sc.nextInt();
  }
  
  for(int i=0; i<gifts.length; i++){
      giftsResult[gifts[i] - 1] = i + 1; // 2 -1 = 0 + 1 = 1 gift[1] = 1 // 3 - 1 = 1 + 1 gift[2] = 2 // 4 - 1 = 2 + 1 gift[3] = 3 // 1 - 1 = 3 + 1 gift[0] = 4
  }
  
  for(int i=0; i<giftsResult.length; i++){
      System.out.print(giftsResult[i] + " ");
  }
 }
}