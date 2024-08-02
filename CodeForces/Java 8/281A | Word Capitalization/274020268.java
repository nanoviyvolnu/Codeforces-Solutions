import java.util.Scanner;
 
public class Main
{
 public static void main(String[] args) {
  Scanner sc = new Scanner(System.in);
  
  String word = sc.nextLine();
  
        char firstLetter = word.toUpperCase().charAt(0);
  String otherCharacters = word.substring(1);
  
  System.out.println(firstLetter + otherCharacters);
  
 }
}