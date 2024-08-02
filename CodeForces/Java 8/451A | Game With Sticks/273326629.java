import java.util.Scanner;
 
public class Main
{
 public static void main(String[] args) {
     Scanner sc = new Scanner(System.in);
  
  int Akshat = sc.nextInt();
  int Malvika = sc.nextInt();
  
  if(Akshat > Malvika){
      Akshat = Malvika;
  }
  
  if(Akshat % 2 == 0){
      System.out.println("Malvika");
  }else{
      System.out.println("Akshat");
  }
 }
}