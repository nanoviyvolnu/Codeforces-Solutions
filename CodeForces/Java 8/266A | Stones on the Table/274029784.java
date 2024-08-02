import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        int n = sc.nextInt();
        sc.nextLine();
        
        String string = sc.nextLine();
        
        String[] chars = string.split("");
        int result = 0;
        
        for(int i=0; i<chars.length - 1; i++){
            if(chars[i].equals(chars[i+1])){
                result++;
            }
        }
        
        System.out.print(result);
    }
}