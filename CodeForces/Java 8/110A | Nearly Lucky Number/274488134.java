import java.util.Scanner;
import java.util.ArrayList;
import java.util.List;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String input = sc.nextLine();
 
        String[] splitedInput = input.split("");
 
        List<Character> luckyNumbers = new ArrayList<>();
 
        boolean finded = false;
        for(int i = 0; i < splitedInput.length; i++) {
            if(splitedInput[i].equals("4") || splitedInput[i].equals("7")){
                finded = true;
                char currentValue = splitedInput[i].charAt(0);
                luckyNumbers.add(currentValue);
            }
        }
        
        if(finded == true && (luckyNumbers.size() == 4 || luckyNumbers.size() == 7)){
            System.out.println("YES");
        }else{
            System.out.println("NO");
        }
    }
}