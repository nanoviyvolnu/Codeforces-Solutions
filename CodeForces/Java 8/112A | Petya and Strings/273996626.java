import java.util.Scanner;
 
public class Main {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        
        String a = sc.nextLine().toLowerCase();
        String b = sc.nextLine().toLowerCase();
        
        int res = a.compareTo(b);
        
        if(res < 0){
            System.out.println("-1");
        }else if(res > 0){
            System.out.println("1");
        }else{
            System.out.println("0");
        }
    }
}